using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class TipoExposicion
    {
        public TipoExposicion()
        {
            Exposicion = new HashSet<Exposicion>();
        }

        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Exposicion> Exposicion { get; set; }

        public bool esTemporal()
        {
            return Nombre == "Temporal";
        }
    }
}
