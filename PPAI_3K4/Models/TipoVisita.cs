﻿using System;
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

        public string mostrarNombre()
        {
            return Nombre;
        }
    }
}
