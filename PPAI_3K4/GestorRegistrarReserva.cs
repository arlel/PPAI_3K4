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
        String[] exposiciones { get; set; }
        List<Empleado> empleados { get; set; }
        TipoVisita tipoVisitaSeleccionada { get; set; }
        int cantidadVisitantes { get; set; }
        DateTime horaFechaActual { get; set; }
        DateTime fechaFinEstimada { get; set; }
        IList<Exposicion> exposicionesSeleccionada { get; set; }
        DateTime fechaHoraReserva { get; set; }
        int cantidadGuiasNecesarios { get; set; }
        TimeSpan duracionReserva { get; set; }
        public IList<Empleado> guiasSeleccionados { get; private set; }
        int cantidadVisitantesAcumulados { get; set; }
        List<ReservaVisita> reservaVisitas { get; set; }
        List<Empleado> guias { get; set; }

        public GestorRegistrarReserva()
        {

        }

        public void nuevaReservaGuiada(PantallaRegistrarReserva pantallaRegistrarReserva)
        {
            this.pantallaRegistrarReserva = pantallaRegistrarReserva;

            // Obtenemos una lista de escuelas de la base de datos
            this.escuelas = obtenerEscuelas();
            List<String> vectorEscuelas = new List<string>();
            foreach (Escuela e in this.escuelas){
                vectorEscuelas.Add(e.getNombre());
            }
            // Se solicita a la pantalla mostrar el listado de escuelas
            this.pantallaRegistrarReserva.mostrarEscuelas(vectorEscuelas.ToArray());
        }

        public IList<Escuela> obtenerEscuelas()
        {
            // Mediante entity framework se obtienen todos los objetos de clase Escuela
            using (ppaiContext context = new ppaiContext())
            {
                return context.Escuela.ToList();
            }
        }

        public void tomarSeleccionEscuela(int indiceEscuela)
        {
            // Se establece el atributo con la escuela seleccionada
            this.escuelaSeleccionada = escuelas[indiceEscuela];

            // Se pide a la pantalla que solicite la cantidad de visitantes
            pantallaRegistrarReserva.solicitarCantidadVisitantes();
        }


        public void tomarCantidadVisitantes(int cantidadVisitantes)
        {
            this.cantidadVisitantes = cantidadVisitantes;

            // Se solicita un listado de sedes de la base de datos
            List<String> vecSedes = new List<String>();
            sede = obtenerSedes();
            foreach (Sede s in this.sede)
            {
                vecSedes.Add(s.getNombre());
            }

            // Se solicita a la pantalla mostrar las sedes
            pantallaRegistrarReserva.mostrarSedes(vecSedes.ToArray());
        }

        public IList<Sede> obtenerSedes()
        {
            using (ppaiContext context = new ppaiContext())
            {
                return context.Sede.ToList();
            }
        }



        public void tomarSeleccionSede(int iSedeSel)
        {
            this.sedeSeleccionada = sede[iSedeSel];

            // Se obtiene de la base de datos un listado de tipo de visita
            tipoVisitas = obtenerTiposVisita();
            List<string> strTipoVisitas = new List<string>();
            foreach (TipoVisita t in tipoVisitas)
            {
                strTipoVisitas.Add(t.getNombre());
            }

            // Se solicita a la pantalla mostrar los tipo de visita
            this.pantallaRegistrarReserva.mostrarTipoVisita(strTipoVisitas.ToArray());

        }

        public IList<TipoVisita> obtenerTiposVisita()
        {
            using(ppaiContext context = new ppaiContext())
            {
                return context.TipoVisita.ToList();
            }
        }

        public void tomarSeleccionTipoVisita(int iTipoVisita)
        {
            this.tipoVisitaSeleccionada = tipoVisitas[iTipoVisita];

            // Se solicita a la sede seleccionada las exposiciones temporales vigentes
            exposiciones = sedeSeleccionada.mostrarExposicionesTemporalesVigentes();

            // Si la cantidad de exposiciones es mayor a cero se le pide a la pantalla mostrarlas, sino se muestra un mensaje de error
            if (exposiciones.Length > 0)
            {
                pantallaRegistrarReserva.mostrarExposiciones(exposiciones);

            } else
            {
                pantallaRegistrarReserva.mostrarMensaje("No hay exposiciones temporales vigentes en la sede seleccionada.");
            }

        }


        public DateTime obtenerFechaHoraActual()
        {
            // Retorna un objeto datetime con la fecha de hoy
            return DateTime.Now;
        }

        public void tomarSeleccionExposiciones(List<int> exposicionesSel)
        {
            sedeSeleccionada.setExposicionesSeleccionadas(exposicionesSel);

            pantallaRegistrarReserva.solicitarFechaHoraReserva();
        }

        public void obtenerAcumuladoReserva(List<ReservaVisita> reservaVisitas)
        {
            int visitantesAcumulados = 0;
            foreach(ReservaVisita reservaVisita in reservaVisitas)
            {
                // Las reservas que intercedan entre la fechaHoraReserva y fechaFinEstimada se obtiene la cantidad de alumnos y se los suma al acumulador
                if(reservaVisita.estasEntreFechas(fechaHoraReserva, fechaFinEstimada))
                {
                    visitantesAcumulados += reservaVisita.getCantidadAlumnos();
                }
            }

            cantidadVisitantesAcumulados = visitantesAcumulados;
            verificarCapacidadMaxima();
        }

        public void obtenerGuiasSedeSeleccionada()
        {
            // Se consulta a la BD la lista de empleados
            List<Empleado> empleados = obtenerEmpleadosSedeSeleccionada();

            // Se inicializa una lista vacia de guias a mostrar
            guias = new List<Empleado>();

            foreach (Empleado empleado in empleados)
            {
                // consulta al objeto empleado si es un empleado con cargo Guia
                if (empleado.sosGuia())
                {
                    bool esValido = true;

                    // Recorre la lista de reservas y consulta si el guia tiene un horario que se solapa en la fecha de la nueva reserva
                    // En ese caso no incluimos al guia en la lista de guias
                    foreach (ReservaVisita reservaVisita in reservaVisitas)
                    {
                        if (reservaVisita.tenesUnGuiaEntreHorarios(empleado, fechaHoraReserva, fechaFinEstimada))
                        {
                            esValido = false;
                            break;
                        }
                    }

                    if (esValido)
                        guias.Add(empleado);
                }
            }

            // En caso de que hayan guias disponibles se muestran los guias y la cantidad de guias necesarios
            // En caso contrario se muestra un mensaje de error
            if (guias.Count > 0)
            {
                calcularGuiasNecesarios(guias);
            }
            else
            {
                pantallaRegistrarReserva.mostrarMensaje("No hay guías disponibles para asignar a la visita");
            }
        }

        public void verificarCapacidadMaxima()
        {
            // Se calcula la fecha fin estimada, sumandole a la fecha y hora de la reserva, la duracion calculada
            fechaFinEstimada = fechaHoraReserva.Add(duracionReserva);

            // Se verifica si la cantidad de visitantes acumulados más la cantidad de visitantes (de la reserva nueva)
            // No sobrepasa la cantidad maxima de visitantes de la sede
            if (sedeSeleccionada.verificarCapacidadMaxima(cantidadVisitantesAcumulados + cantidadVisitantes))
            {
                obtenerGuiasSedeSeleccionada();
            }
            else
            {
                pantallaRegistrarReserva.mostrarMensaje("La capacidad máxima de visitantes por sede se sobrepasa para la duración de la visita.");
            }
        }


        public void tomarSeleccionFechaHora(DateTime fechaHoraReserva)
        {
            this.fechaHoraReserva = fechaHoraReserva;

            // Se calcula la duracion de la reserva
            calcularDuracionEstimadaReserva();
        }

        public void tomarSeleccionGuias(List<int> indicesGuias) // HASTA ACA ESTA TODO BIEN
        {
            guiasSeleccionados = new List<Empleado>();
            if (indicesGuias.Count == cantidadGuiasNecesarios)
            {
                foreach (int i in indicesGuias)
                {
                    guiasSeleccionados.Add(guias[i]);
                }

                // Se solicita a la pantalla la confirmacion de la reserva
                pantallaRegistrarReserva.solicitarConfirmacion();
            } else
            {
                MessageBox.Show("Debe seleccionar " + cantidadGuiasNecesarios.ToString() + " guías.");
                pantallaRegistrarReserva.mostrarPanelGuias();

            }
        }

        public void obtenerReservaVisitasSedeSeleccionada() { 
            using(ppaiContext context = new ppaiContext())
            {
                // Internamente en la consulta a base se obtienen las Asignaciones
                // por consiguiente se sustituye el lamado al metodo con esta consulta en base
                reservaVisitas =  context.ReservaVisita.Include("AsignacionVisita").Where(e => e.IdSede == sedeSeleccionada.Id).ToList();
            }

            obtenerAcumuladoReserva(reservaVisitas);
        }

        public List<Empleado> obtenerEmpleadosSedeSeleccionada()
        {
            using(ppaiContext context = new ppaiContext())
            {
                // A traves de Entity framework consultamos a la base los empleados de la sede, de esta manera se le pregunta al empleado su sede a nivel de base
                empleados = context.Empleado.Include(e => e.IdCargoNavigation).Where(e => e.IdSede == sedeSeleccionada.Id).ToList();

                return empleados;
            }
        }


        public void calcularDuracionEstimadaReserva()
        {
            if (tipoVisitaSeleccionada.esPorExposicion())
            {
                duracionReserva = sedeSeleccionada.calcularDuracionEstimadaReserva(tipoVisitaSeleccionada.esPorExposicion());
            }

            // Se solicita a la BD las ReservaVisitas de la sede seleccionada
            obtenerReservaVisitasSedeSeleccionada();

        }

        public void calcularGuiasNecesarios(List<Empleado> guias)
        {
            cantidadGuiasNecesarios = sedeSeleccionada.calcularCantidadGuias(cantidadVisitantes);

            pantallaRegistrarReserva.mostrarCantidadGuiasNecesarias(cantidadGuiasNecesarios); // agregar al diagrama de secuencia
            List<String> guiasAMostrar = new List<string>();
            foreach (Empleado guia in guias)
            {
                guiasAMostrar.Add(guia.getNombre());
            }

            pantallaRegistrarReserva.mostrarGuias(guiasAMostrar.ToArray());
        }

        public void tomarConfirmacion()
        {
            using(ppaiContext context = new ppaiContext())
            {
                // Se obtiene de la BD el listado de todos los objetos
                List<Estado> estados = obtenerEstados();

                foreach(Estado estado in estados)
                {
                    if (estado.esAmbitoReserva() && estado.esPendienteConfirmacion())
                    {
                        this.horaFechaActual = obtenerFechaHoraActual();

                        // Se instancia un nuevo objeto ReservaVisita, y este a su vez va a crear las Asignaciones de las reservas y el cambio de estado
                        ReservaVisita reservaVisita = new ReservaVisita(cantidadVisitantes, null, duracionReserva, horaFechaActual, fechaHoraReserva, null, null, null, escuelaSeleccionada, sedeSeleccionada, null, guiasSeleccionados, fechaFinEstimada, estado, horaFechaActual);

                        // Se inserta en la BD la reserva, el cambio de estado y las asignaciones
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
