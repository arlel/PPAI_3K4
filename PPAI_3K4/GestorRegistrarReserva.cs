using Microsoft.EntityFrameworkCore;
using PPAI_3K4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPAI_3K4
{
    public class GestorRegistrarReserva
    {
        PantallaRegistrarReserva pantallaRegistrarReserva { get; set; }
        Escuela escuelaSeleccionada { get; set; }
        Sede sedeSeleccionada { get; set; }
        TipoVisita tipoVisitaSeleccionada { get; set; }
        int cantidadParticipantes { get; set; }
        DateTime horaFechaActual { get; set; }
        IList<Exposicion> exposicionesSeleccionada { get; set; }
        DateTime fechaHoraReserva { get; set; }

        TimeSpan duracionReserva { get; set; }

        public void nuevaReservaGuiada(PantallaRegistrarReserva pantallaRegistrarReserva)
        {
            this.pantallaRegistrarReserva = pantallaRegistrarReserva;

            IList<Escuela> escuelas = obtenerEscuelas();

            this.pantallaRegistrarReserva.mostrarEscuelas(escuelas);
        }

        public IList<Escuela> obtenerEscuelas()
        {
            using (ppaiContext context = new ppaiContext())
            {
                return context.Escuela.ToList();
            }
        }

        public void tomarSeleccionEscuela(Escuela escuela)
        {
            this.escuelaSeleccionada = escuela;

            pantallaRegistrarReserva.solicitarCantidadVisitantes();
        }


        public void tomarCantidadParticipantes(int cantidadParticipantes)
        {
            this.cantidadParticipantes = cantidadParticipantes;
            IList<Sede> sede = obtenerSedes();

            pantallaRegistrarReserva.mostrarSedes(sede);
        }

        public IList<Sede> obtenerSedes()
        {
            using (ppaiContext context = new ppaiContext())
            {
                return context.Sede.ToList();
            }
        }



        public void tomarSeleccionSede(Sede sedeSel)
        {
            this.sedeSeleccionada = sedeSel;

            IList<TipoVisita> tipoVisitas = obtenerTipoVisita();

            this.pantallaRegistrarReserva.mostrarTipoVisita(tipoVisitas);

        }

        public IList<TipoVisita> obtenerTipoVisita()
        {
            using(ppaiContext context = new ppaiContext())
            {
                return context.TipoVisita.ToList();
            }
        }

        public void tomarSeleccionTipoVisita(TipoVisita tipoVisita)
        {
            this.tipoVisitaSeleccionada = tipoVisita;
            this.horaFechaActual = obtenerFechaHoraActual();
            IList<Exposicion> exposiciones = buscarExposicionesTemporalesVigentes();

            pantallaRegistrarReserva.mostrarExposiciones(exposiciones);
        }

        public IList<Exposicion> buscarExposicionesTemporalesVigentes()
        {
            obtenerExposicionesPorSede(sedeSeleccionada);
            return sedeSeleccionada.mostrarExposicionesTemporalesVigentes();
        }

        public void obtenerExposicionesPorSede(Sede sede)
        {
            using(ppaiContext context = new ppaiContext())
            {
                sede.Exposicion = context.Exposicion.Include(e => e.IdTipoExposicionNavigation).Include(e => e.DetalleExposicion).Include("PublicoDestino").Where(e => e.IdSede == sede.Id).ToList();

                foreach(Exposicion expo in sede.Exposicion)
                {
                    foreach(DetalleExposicion detalle in expo.DetalleExposicion)
                    {
                        detalle.IdObraNavigation = context.Obra.Where(o => o.Id == detalle.IdObra).FirstOrDefault();
                    }
                }
            }
        }


        public DateTime obtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public void tomarSeleccionExposiciones(IList<Exposicion> exposicionesSel)
        {
            exposicionesSeleccionada = exposicionesSel;

            pantallaRegistrarReserva.solicitarFechaHoraReserva();
        }


        public void tomarSeleccionFechaHora(DateTime fechaHoraReserva)
        {
            this.fechaHoraReserva = fechaHoraReserva;

            duracionReserva = calcularDuracionEstimadaReserva();

            if (sedeSeleccionada.verificarCapacidadMaxima(cantidadParticipantes)) // revisar paso 15
            {
                List<Empleado> empleados = obtenerGuiasSedeSeleccionada(sedeSeleccionada);
                List<Empleado> guias = new List<Empleado>();
                foreach(Empleado empleado in empleados)
                {
                    if(empleado.)
                }
                
            }

        }

        public List<Empleado> obtenerGuiasSedeSeleccionada(Sede sede)
        {
            using(ppaiContext context = new ppaiContext())
            {
                List<Empleado> empleados = context.Empleado.Include(e => e.IdCargoNavigation).Where(e => e.IdSede == sede.Id).ToList();

                return empleados;
            }
        }


        public TimeSpan calcularDuracionEstimadaReserva()
        {
            TimeSpan duracionReserva = new TimeSpan();
            if (tipoVisitaSeleccionada.esPorExposicion())
            {
                foreach(Exposicion exposicion in exposicionesSeleccionada)
                {
                    duracionReserva = duracionReserva.Add(exposicion.calcularDuracionObrasExpuestas());
                }
            } 

            return duracionReserva;
        }
    }
 
}
