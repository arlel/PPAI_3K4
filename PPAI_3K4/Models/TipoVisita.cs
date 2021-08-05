using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class TipoVisita
    {
        public long Id { get; set; }
        public string Nombre { get; set; }

        public bool esPorExposicion()
        {
            return Nombre.Equals("Por exposicion", StringComparison.OrdinalIgnoreCase);
        }

        public bool esCompleta()
        {
            return Nombre.Equals("Completa", StringComparison.OrdinalIgnoreCase);
        }

        public string getNombre()
        {
            return this.Nombre;
        }
    }
}
