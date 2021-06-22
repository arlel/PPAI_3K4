﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            HorarioEmpleado = new HashSet<HorarioEmpleado>();
            ReservaVisita = new HashSet<ReservaVisita>();
        }

        public long Id { get; set; }
        public string Apellido { get; set; }
        public long? CodigoValidacion { get; set; }
        public string Cuit { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public long? IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual ICollection<HorarioEmpleado> HorarioEmpleado { get; set; }
        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }
    }
}