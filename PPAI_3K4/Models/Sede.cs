using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Sede
    {
        public Sede()
        {
            Exposicion = new HashSet<Exposicion>();
            ReservaVisita = new HashSet<ReservaVisita>();
        }

        public long Id { get; set; }
        public int? CantMaximaVisitantes { get; set; }
        public int? CantMaxPorGuia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Exposicion> Exposicion { get; set; }
        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }

        public IList<Exposicion> mostrarExposicionesTemporalesVigentes()
        {
            IList<Exposicion> expocionesTemporalesVigentes = new List<Exposicion>() { };
            foreach (Exposicion exposicion in this.Exposicion)
            {
                if(exposicion.sosTemporal() && exposicion.sosVigente())
                {
                    expocionesTemporalesVigentes.Add(exposicion);
                }
            }

            return expocionesTemporalesVigentes;
        } 



    }
}
