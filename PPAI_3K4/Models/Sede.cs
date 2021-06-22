using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Sede
    {
        public Sede()
        {
            ReservaVisita = new HashSet<ReservaVisita>();
        }

        public long Id { get; set; }
        public int? CantMaximaVisitantes { get; set; }
        public int? CantMaxPorGuia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }

        public IList<Sede> ObtenerSedes()
        {
            using(ppaiContext context = new ppaiContext())
            {
                return context.Sede.ToList();
            }
        }
    }
}
