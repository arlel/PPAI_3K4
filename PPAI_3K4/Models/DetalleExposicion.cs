using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class DetalleExposicion
    {
        public long Id { get; set; }
        public string LugarAsignacion { get; set; }
        public long? IdObra { get; set; }
        public long? IdExposicion { get; set; }

        public virtual Exposicion IdExposicionNavigation { get; set; }
        public virtual Obra IdObraNavigation { get; set; }

        public TimeSpan buscarDuracExtObra()
        {
            if (IdObraNavigation == null)
                obtenerObra();

            return IdObraNavigation.getDuracionExtendida();
        }

        public void obtenerObra()
        {
            using(ppaiContext context = new ppaiContext())
            {
                this.IdObraNavigation = context.Obra.Where(o => o.Id == this.IdObra).FirstOrDefault();
            }
        }
    }
}
