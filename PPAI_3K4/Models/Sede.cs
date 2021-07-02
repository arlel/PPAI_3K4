using Microsoft.EntityFrameworkCore;
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
            Empleado = new HashSet<Empleado>();
            Exposicion = new HashSet<Exposicion>();
            HorarioSede = new HashSet<HorarioSede>();
            ReservaVisita = new HashSet<ReservaVisita>();
        }

        public long Id { get; set; }
        public int? CantMaximaVisitantes { get; set; }
        public int? CantMaxPorGuia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Exposicion> Exposicion { get; set; }
        public virtual ICollection<HorarioSede> HorarioSede { get; set; }
        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }

        public IList<Exposicion> mostrarExposicionesTemporalesVigentes()
        {
            if (this.Exposicion.Count == 0)
                obtenerExposiciones();

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

        public void obtenerExposiciones()
        {
            using (ppaiContext context = new ppaiContext())
            {
                this.Exposicion = context.Exposicion.Include(e => e.IdTipoExposicionNavigation).Include(e => e.DetalleExposicion).Include("PublicoDestino").Where(e => e.IdSede == this.Id).ToList();
            }
        }

        public int calcularCantidadGuias(int cantidadVisitantes)
        {
            return cantidadVisitantes / CantMaxPorGuia.Value;
        }


        public bool verificarCapacidadMaxima(int visitantes) 
        {
            return CantMaximaVisitantes >= visitantes;
        }

    }
}
