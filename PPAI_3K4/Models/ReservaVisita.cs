using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class ReservaVisita
    {
        public ReservaVisita()
        {
            AsignacionVisita = new HashSet<AsignacionVisita>();
            CambioEstadoReservaVisita = new HashSet<CambioEstadoReservaVisita>();
        }

        public ReservaVisita(int? cantidadAlumnos, int? cantidadAlumnosConfirmada, TimeSpan? duracionEstimada, DateTime? fechaHoraCreacion, DateTime? fechaHoraReserva, TimeSpan? horaFinReal, TimeSpan? horaInicioReal, long? numeroReserva, Escuela escuela, Sede sede, Empleado empleado, IList<Empleado> guiasSeleccionados, DateTime fechaFinEstimada, Estado estadoInicio, DateTime fechaActual)
        {
            CantidadAlumnos = cantidadAlumnos;
            CantidadAlumnosConfirmada = cantidadAlumnosConfirmada;
            DuracionEstimada = duracionEstimada;
            FechaHoraCreacion = fechaHoraCreacion;
            FechaHoraReserva = fechaHoraReserva;
            HoraFinReal = horaFinReal;
            HoraInicioReal = horaInicioReal;
            NumeroReserva = numeroReserva;
            IdEscuela = escuela.Id;
            IdSede = sede.Id;
            IdEmpleado = 1;
            AsignacionVisita = new List<AsignacionVisita>();
            CambioEstadoReservaVisita = new List<CambioEstadoReservaVisita>();

            crearCambioDeEstado(estadoInicio, fechaActual);
            crearAsignacionesVisitas(fechaHoraReserva.Value, fechaFinEstimada, guiasSeleccionados);
        }

        private void crearCambioDeEstado(Estado estadoInicio, DateTime fechaActual)
        {
            this.CambioEstadoReservaVisita.Add(new CambioEstadoReservaVisita(null, fechaActual, this, estadoInicio));
        }

        private void crearAsignacionesVisitas(DateTime fechaHoraReserva, DateTime fechaHoraFin, IList<Empleado> guiasSeleccionados)
        {

            foreach (Empleado guia in guiasSeleccionados)
            {
                this.AsignacionVisita.Add(new AsignacionVisita(fechaHoraReserva, fechaHoraFin, guia, this));
            }
        }

        public bool estasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime FechaHoraFinEstimada = FechaHoraReserva.Value.Add(DuracionEstimada.Value);
            // Si la fecha de la reserva es distinta de la fechaInicio (reserva nueva) se devuelve false
            if (FechaHoraReserva?.Date != fechaInicio.Date)
            {
                return false;
            }

            // Se valida que las fechas no se solapen
            return FechaHoraReserva?.TimeOfDay <= fechaInicio.TimeOfDay && FechaHoraFinEstimada.TimeOfDay >= fechaInicio.TimeOfDay
                || FechaHoraReserva?.TimeOfDay <= fechaFin.TimeOfDay && FechaHoraFinEstimada.TimeOfDay >= fechaFin.TimeOfDay;
        }

        public long Id { get; set; }
        public int? CantidadAlumnos { get; set; }
        public int? CantidadAlumnosConfirmada { get; set; }
        public TimeSpan? DuracionEstimada { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraReserva { get; set; }
        public TimeSpan? HoraFinReal { get; set; }
        public TimeSpan? HoraInicioReal { get; set; }
        public long? NumeroReserva { get; set; }
        public long? IdEscuela { get; set; }
        public long? IdSede { get; set; }
        public long? IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Escuela IdEscuelaNavigation { get; set; }
        public virtual Sede IdSedeNavigation { get; set; }
        public virtual ICollection<AsignacionVisita> AsignacionVisita { get; set; }
        public virtual ICollection<CambioEstadoReservaVisita> CambioEstadoReservaVisita { get; set; }


        public bool tenesUnGuiaEntreHorarios(Empleado empleado, DateTime fechaInicio, DateTime fechaFin)
        {
            foreach(AsignacionVisita asignacionVisita in this.AsignacionVisita)
            {
                // Le consulta a la asignacion visita si la fecha de inicio o fecha fin de la reserva se solapa con la fecha de la asignacion de la visita
                if(asignacionVisita.checkearValidezGuia(empleado, fechaInicio, fechaFin))
                {
                    return true;
                }

            }

            return false;
        }
    }
}
