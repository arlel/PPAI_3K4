using Microsoft.EntityFrameworkCore;
using PPAI_3K4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        IList<Exposicion> exposicionesSeleccionada { get; set; }
        DateTime fechaHoraReserva { get; set; }

        int cantidadGuiasNecesarios { get; set; }

        TimeSpan duracionReserva { get; set; }
        public IList<Empleado> guiasSeleccionados { get; private set; }

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
            // this.horaFechaActual = obtenerFechaHoraActual(); esto hay que borrarlo del diagrama de sucuencia no va
            exposiciones = buscarExposicionesTemporalesVigentes();

            pantallaRegistrarReserva.mostrarExposiciones(exposiciones);
        }

        public IList<Exposicion> buscarExposicionesTemporalesVigentes()
        {
            obtenerExposicionesPorSede(sedeSeleccionada);
            return sedeSeleccionada.mostrarExposicionesTemporalesVigentes();
        }

        public void obtenerExposicionesPorSede(Sede sede)
        {
            using(ppaiContext context = new ppaiContext())
            {
                sede.Exposicion = context.Exposicion.Include(e => e.IdTipoExposicionNavigation).Include(e => e.DetalleExposicion).Include("PublicoDestino").Where(e => e.IdSede == sede.Id).ToList();

                foreach(Exposicion expo in sede.Exposicion)
                {
                    foreach(DetalleExposicion detalle in expo.DetalleExposicion)
                    {
                        detalle.IdObraNavigation = context.Obra.Where(o => o.Id == detalle.IdObra).FirstOrDefault();
                    }
                }
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


        public void tomarSeleccionFechaHora(DateTime fechaHoraReserva)
        {
            this.fechaHoraReserva = fechaHoraReserva;


            duracionReserva = calcularDuracionEstimadaReserva();

            DateTime fechaFinEstimada = fechaHoraReserva.Add(duracionReserva);

            if (sedeSeleccionada.verificarCapacidadMaxima(cantidadParticipantes)) // revisar paso 15
            {
                List<Empleado> empleados = obtenerGuiasSedeSeleccionada();
                List<ReservaVisita> reservaVisitas = obtenerReservaVisitasSedeSeleccionada();
                List<Empleado> guias = new List<Empleado>();
                foreach(Empleado empleado in empleados)
                {
                    if(empleado.sosGuia())
                    {
                        foreach(ReservaVisita reservaVisita in reservaVisitas)
                        {
                            if(!reservaVisita.tenesUnGuiaEntreHorarios(empleado, fechaHoraReserva, fechaFinEstimada)) {
                                guias.Add(empleado);
                            }

                        }
                    }
                }

                cantidadGuiasNecesarios = sedeSeleccionada.calcularCantidadGuias(cantidadParticipantes);

                pantallaRegistrarReserva.mostrarCantidadGuiasNecesarias(cantidadGuiasNecesarios); // agregar al diagrama de secuencia
                pantallaRegistrarReserva.mostrarGuias(guias);
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
                        ReservaVisita reservaVisita = new ReservaVisita(cantidadParticipantes, null, duracionReserva, horaFechaActual, fechaHoraReserva, null, null, null, escuelaSeleccionada, sedeSeleccionada, null);

                        context.ReservaVisita.Add(reservaVisita);
                        context.SaveChanges();

                        List<AsignacionVisita> asignacionVisitas = new List<AsignacionVisita>();
                        foreach(Empleado guia in guiasSeleccionados)
                        {
                            AsignacionVisita asignacionVisita = new AsignacionVisita(fechaHoraReserva, fechaHoraReserva.Add(duracionReserva), guia, reservaVisita);
                            context.Add(asignacionVisita);
                        }

                        CambioEstadoReservaVisita cambioEstadoReservaVisita = new CambioEstadoReservaVisita(null, horaFechaActual, reservaVisita, estado);

                        context.Add(cambioEstadoReservaVisita);
                        context.SaveChanges();
                    }
                }
            }
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
