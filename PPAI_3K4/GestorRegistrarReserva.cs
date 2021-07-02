using Microsoft.EntityFrameworkCore;
using PPAI_3K4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPAI_3K4
{
    public class GestorRegistrarReserva
    {
        PantallaRegistrarReserva pantallaRegistrarReserva { get; set; }
        Escuela escuelaSeleccionada { get; set; }
        Sede sedeSeleccionada { get; set; }
        IList<Escuela> escuelas { get; set; }
        IList<Sede> sede { get; set; }
        IList<TipoVisita> tipoVisitas { get; set; }
        IList<Exposicion> exposiciones { get; set; }
        List<Empleado> empleados { get; set; }
        TipoVisita tipoVisitaSeleccionada { get; set; }
        int cantidadParticipantes { get; set; }
        DateTime horaFechaActual { get; set; }
        DateTime fechaFinEstimada { get; set; }
        IList<Exposicion> exposicionesSeleccionada { get; set; }
        DateTime fechaHoraReserva { get; set; }

        int cantidadGuiasNecesarios { get; set; }

        TimeSpan duracionReserva { get; set; }
        public IList<Empleado> guiasSeleccionados { get; private set; }

        public GestorRegistrarReserva()
        {

        }

        public void nuevaReservaGuiada(PantallaRegistrarReserva pantallaRegistrarReserva)
        {
            this.pantallaRegistrarReserva = pantallaRegistrarReserva;

            // Obtenemos una lista de escuelas de la base de datos
            this.escuelas = obtenerEscuelas();

            this.pantallaRegistrarReserva.mostrarEscuelas(escuelas);
        }

        public IList<Escuela> obtenerEscuelas()
        {
            // Mediante entity framework se obtienen todos los objetos de clase Escuela
            using (ppaiContext context = new ppaiContext())
            {
                return context.Escuela.ToList();
            }
        }

        public void tomarSeleccionEscuela(Escuela escuela)
        {
            this.escuelaSeleccionada = escuela;

            pantallaRegistrarReserva.solicitarCantidadVisitantes();
        }


        public void tomarCantidadParticipantes(int cantidadParticipantes)
        {
            this.cantidadParticipantes = cantidadParticipantes;
            sede = obtenerSedes();

            pantallaRegistrarReserva.mostrarSedes(sede);
        }

        public IList<Sede> obtenerSedes()
        {
            using (ppaiContext context = new ppaiContext())
            {
                return context.Sede.ToList();
            }
        }



        public void tomarSeleccionSede(Sede sedeSel)
        {
            this.sedeSeleccionada = sedeSel;

            tipoVisitas = obtenerTiposVisita();

            this.pantallaRegistrarReserva.mostrarTipoVisita(tipoVisitas);

        }

        public IList<TipoVisita> obtenerTiposVisita()
        {
            using(ppaiContext context = new ppaiContext())
            {
                return context.TipoVisita.ToList();
            }
        }

        public void tomarSeleccionTipoVisita(TipoVisita tipoVisita)
        {
            this.tipoVisitaSeleccionada = tipoVisita;
            exposiciones = sedeSeleccionada.mostrarExposicionesTemporalesVigentes();

            if (exposiciones.Count > 0)
            {
                pantallaRegistrarReserva.mostrarExposiciones(exposiciones);

            } else
            {
                pantallaRegistrarReserva.mostrarMensaje("No hay exposiciones temporales vigentes en la sede seleccionada.");
            }

        }


        public DateTime obtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public void tomarSeleccionExposiciones(IList<Exposicion> exposicionesSel)
        {
            exposicionesSeleccionada = exposicionesSel;

            pantallaRegistrarReserva.solicitarFechaHoraReserva();
        }

        public int obtenerAcumuladoReserva(List<ReservaVisita> reservaVisitas)
        {
            int visitantesAcumulados = 0;
            foreach(ReservaVisita reservaVisita in reservaVisitas)
            {
                if(reservaVisita.estasEntreFechas(fechaHoraReserva, fechaFinEstimada))
                {
                    visitantesAcumulados += reservaVisita.CantidadAlumnos.Value;
                }
            }

            return visitantesAcumulados;
        }


        public void tomarSeleccionFechaHora(DateTime fechaHoraReserva)
        {
            this.fechaHoraReserva = fechaHoraReserva;
            duracionReserva = calcularDuracionEstimadaReserva();
            fechaFinEstimada = fechaHoraReserva.Add(duracionReserva);

            List<ReservaVisita> reservaVisitas = obtenerReservaVisitasSedeSeleccionada();

            int cantidadParticipantesAcumulado = obtenerAcumuladoReserva(reservaVisitas);

            if (sedeSeleccionada.verificarCapacidadMaxima(cantidadParticipantesAcumulado + cantidadParticipantes)) // revisar paso 15
            {
                List<Empleado> empleados = obtenerGuiasSedeSeleccionada();
                List<Empleado> guias = new List<Empleado>();
                foreach(Empleado empleado in empleados)
                {
                    if(empleado.sosGuia())
                    {
                        bool esValido = true;

                        foreach(ReservaVisita reservaVisita in reservaVisitas)
                        {
                            if(reservaVisita.tenesUnGuiaEntreHorarios(empleado, fechaHoraReserva, fechaFinEstimada)) {
                                esValido = false;
                            }

                        }

                        if(esValido)
                            guias.Add(empleado);

                    }
                }

                if(guias.Count > 0)
                {
                    cantidadGuiasNecesarios = sedeSeleccionada.calcularCantidadGuias(cantidadParticipantes);

                    pantallaRegistrarReserva.mostrarCantidadGuiasNecesarias(cantidadGuiasNecesarios); // agregar al diagrama de secuencia
                    pantallaRegistrarReserva.mostrarGuias(guias);
                } else
                {
                    pantallaRegistrarReserva.mostrarMensaje("No hay guías disponibles para asignar a la visita");
                }
            } else
            {
                pantallaRegistrarReserva.mostrarMensaje("La capacidad máxima de visitantes por sede se sobrepasa para la duración de la visita.");
            }

        }

        public void tomarSeleccionGuias(IList<Empleado> guias)
        {
            this.guiasSeleccionados = guias;

            pantallaRegistrarReserva.solicitarConfirmacion();
        }

        public bool validarCantidadGuiasSeleccionados(int cantidadGuias)
        {
            return cantidadGuias == cantidadGuiasNecesarios;
        }

        public List<ReservaVisita> obtenerReservaVisitasSedeSeleccionada() { 
            using(ppaiContext context = new ppaiContext())
            {
                return context.ReservaVisita.Include("AsignacionVisita").Where(e => e.IdSede == sedeSeleccionada.Id).ToList();
            }
        
        }

        public List<Empleado> obtenerGuiasSedeSeleccionada()
        {
            using(ppaiContext context = new ppaiContext())
            {
                // A traves de Entity framework consultamos a la base los empleados de la sede, de esta manera se le pregunta al empleado su sede a nivel de base
                empleados = context.Empleado.Include(e => e.IdCargoNavigation).Where(e => e.IdSede == sedeSeleccionada.Id).ToList();

                return empleados;
            }
        }


        public TimeSpan calcularDuracionEstimadaReserva()
        {
            TimeSpan duracionReserva = new TimeSpan();
            if (tipoVisitaSeleccionada.esPorExposicion())
            {
                foreach(Exposicion exposicion in exposicionesSeleccionada)
                {
                    duracionReserva = duracionReserva.Add(exposicion.calcularDuracionObrasExpuestas());
                }
            } 

            return duracionReserva;
        }

        public void tomarConfirmacion()
        {
            using(ppaiContext context = new ppaiContext())
            {
                List<Estado> estados = obtenerEstados();

                foreach(Estado estado in estados)
                {
                    if (estado.esAmbitoReserva() && estado.esPendienteConfirmacion())
                    {
                        this.horaFechaActual = obtenerFechaHoraActual();
                        ReservaVisita reservaVisita = new ReservaVisita(cantidadParticipantes, null, duracionReserva, horaFechaActual, fechaHoraReserva, null, null, null, escuelaSeleccionada, sedeSeleccionada, null, guiasSeleccionados, fechaFinEstimada, estado, horaFechaActual);

                        context.ReservaVisita.Add(reservaVisita);
                        context.SaveChanges();

                        break;
                    }
                }

                finCU();
            }
        }

        public void finCU()
        {
            pantallaRegistrarReserva.mostrarMensaje("La reserva ha sido creada con exito");
        }

        public List<Estado> obtenerEstados()
        {
            using (ppaiContext context = new ppaiContext()) 
            {
                return context.Estado.ToList();
            }
        }
    }
 
}
