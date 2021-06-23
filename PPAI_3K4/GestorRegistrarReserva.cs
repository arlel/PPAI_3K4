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
            this.setEscuelaSeleccionada(escuela);

            pantallaRegistrarReserva.solicitarCantidadVisitantes();
        }

        public void setEscuelaSeleccionada(Escuela escuela)
        {
            this.escuelaSeleccionada = escuela;
        }

        public void tomarCantidadParticipantes(int cantidadParticipantes)
        {
            setCantidadParticipantes(cantidadParticipantes);
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

        public void setCantidadParticipantes(int cantidadParticipantes)
        {
            this.cantidadParticipantes = cantidadParticipantes;
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
            setTipoVisitaSeleccionada(tipoVisita);
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
                sede.Exposicion = context.Exposicion.Include(e => e.IdTipoExposicionNavigation).Include("PublicoDestino").Where(e => e.IdSede == sede.Id).ToList();
            }
        }

        public void setTipoVisitaSeleccionada(TipoVisita tipoVisita)
        {
            this.tipoVisitaSeleccionada = tipoVisita;
        }

        public DateTime obtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public void tomarSeleccionExposiciones(IList<Exposicion> exposicionesSel)
        {
            setExposicionSeleccionada(exposicionesSel);
            pantallaRegistrarReserva.solicitarFechaHoraReserva();
        }

        public void setExposicionSeleccionada(IList<Exposicion> exposicionesSel)
        {
            exposicionesSeleccionada = exposicionesSel;
        }

        public void tomarSeleccionFechaHora(DateTime fechaHoraReserva)
        {
            this.fechaHoraReserva = fechaHoraReserva;
            }
    }
 
}
