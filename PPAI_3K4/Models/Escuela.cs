using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Escuela
    {
        public long? Id { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }

        public IList<Escuela> mostrarEscuelas()
        {
            using(ppaiContext context = new ppaiContext())
            {
                return context.Escuela.ToList();
            }
        }
    }
}
