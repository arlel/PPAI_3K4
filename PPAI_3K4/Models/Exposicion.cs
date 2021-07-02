using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Exposicion
    {
        public Exposicion()
        {
            DetalleExposicion = new HashSet<DetalleExposicion>();
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
        public virtual ICollection<DetalleExposicion> DetalleExposicion { get; set; }
        public virtual ICollection<PublicoDestino> PublicoDestino { get; set; }

        public bool sosTemporal()
        {
            return this.IdTipoExposicionNavigation.esTemporal();
        }

        public bool sosVigente()
        {
            DateTime fechaActual = DateTime.Now;
            return FechaInicio <= fechaActual && FechaFin >= fechaActual;
        }

        public void obtenerDetalleExposicion()
        {
            using(ppaiContext context = new ppaiContext())
            {
                this.DetalleExposicion = context.DetalleExposicion.Where(d => d.IdExposicion.Value == this.Id).ToList();
            }
        }

        public TimeSpan calcularDuracionObrasExpuestas()
        {
            TimeSpan duracionSumada = new TimeSpan();

            if (DetalleExposicion == null || DetalleExposicion.Count == 0)
                obtenerDetalleExposicion();


            foreach(DetalleExposicion detalle in DetalleExposicion)
            {
                duracionSumada = duracionSumada.Add(detalle.buscarDuracExtObra());
            }

            return duracionSumada;
        }


    }
}
