using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class AsignacionVisita
    {
        public AsignacionVisita()
        {

        }
        public AsignacionVisita(DateTime? fechaHoraInicio, DateTime? fechaHoraFin, Empleado empleado, ReservaVisita reserva)
        {
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraFin = fechaHoraFin;
            IdEmpleado = empleado.Id;
            IdReservaNavigation = reserva;
        }

        public long Id { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public long? IdEmpleado { get; set; }
        public long? IdReserva { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ReservaVisita IdReservaNavigation { get; set; }

        public bool checkearValidezGuia(Empleado empleado, DateTime fechaInicio, DateTime fechaFin)
        {
            return esTuGuia(empleado) && estaEnReservaEnHorario(fechaInicio, fechaFin);
        }

        public bool esTuGuia(Empleado empleado)
        {
            // Al hacer empleado.Id se accede al campo Id mediante un get
            return IdEmpleado.Value == empleado.Id;
        }

        public bool estaEnReservaEnHorario(DateTime fechaInicio, DateTime fechaFin)
        {
            // Valida que la fecha de la asignacion sea distinta que la fecha de la reserva
            if(FechaHoraInicio?.Date != fechaInicio.Date)
            {
                return false;
            }

            // Valida que la fecha de inicio y fecha fin de la reserva no se solape con las fechas de la asignacion
            return FechaHoraInicio?.TimeOfDay <= fechaInicio.TimeOfDay && FechaHoraFin?.TimeOfDay >= fechaInicio.TimeOfDay
                || FechaHoraInicio?.TimeOfDay <= fechaFin.TimeOfDay && FechaHoraFin?.TimeOfDay >= fechaFin.TimeOfDay;
        }
    }
}
