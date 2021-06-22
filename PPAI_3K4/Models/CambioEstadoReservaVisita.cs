using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class CambioEstadoReservaVisita
    {
        public long Id { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public long? IdReserva { get; set; }
        public long? IdEstado { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual ReservaVisita IdReservaNavigation { get; set; }
    }
}
