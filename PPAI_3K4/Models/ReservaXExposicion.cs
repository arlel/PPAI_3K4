using System;
using System.Collections.Generic;
using System.Text;

namespace PPAI_3K4.Models
{
    public partial class ReservaXExposicion
    {
        public long ReservaId { get; set; }
        public long ExposicionId { get; set; }
        public ReservaVisita ReservaVisita { get; set; }
        public Exposicion Exposicion { get; set; }

        public ReservaXExposicion() { }
        public ReservaXExposicion(ReservaVisita r, Exposicion e)
        {
            this.ReservaVisita = r;
            this.Exposicion = e;

        }
    }
}
