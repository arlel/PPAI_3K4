using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Obra
    {
        public Obra()
        {
            DetalleExposicion = new HashSet<DetalleExposicion>();
        }

        public long Id { get; set; }
        public int? Alto { get; set; }
        public int? Ancho { get; set; }
        public int? CodigoSensor { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan? DuracionExtendida { get; set; }
        public TimeSpan? DuracionResumida { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaPrimerIngreso { get; set; }
        public string NombreObra { get; set; }
        public int? Peso { get; set; }
        public decimal? Valuacion { get; set; }

        public virtual ICollection<DetalleExposicion> DetalleExposicion { get; set; }

        public TimeSpan getDuracionExtendida()
        {
            return this.DuracionExtendida.Value;
        }
    }
}
