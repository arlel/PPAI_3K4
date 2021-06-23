using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Exposicion
    {
        public Exposicion()
        {
            PublicoDestino = new HashSet<PublicoDestino>();
        }

        public long Id { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaFinReplanificada { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaInicioReplanificada { get; set; }
        public TimeSpan? HoraApertura { get; set; }
        public TimeSpan? HoraCierre { get; set; }
        public string Nombre { get; set; }
        public long? IdTipoExposicion { get; set; }
        public long? IdSede { get; set; }

        public virtual Sede IdSedeNavigation { get; set; }
        public virtual TipoExposicion IdTipoExposicionNavigation { get; set; }
        public virtual ICollection<PublicoDestino> PublicoDestino { get; set; }
    }
}
