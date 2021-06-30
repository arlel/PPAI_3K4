﻿using Microsoft.EntityFrameworkCore;
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
        IList<Escuela> escuelas { get; set; }
        IList<Sede> sede { get; set; }
        IList<TipoVisita> tipoVisitas { get; set; }
        IList<Exposicion> exposiciones { get; set; }
        List<Empleado> empleados { get; set; }
        TipoVisita tipoVisitaSeleccionada { get; set; }
        int cantidadParticipantes { get; set; }
        DateTime horaFechaActual { get; set; }
        IList<Exposicion> exposicionesSeleccionada { get; set; }
        DateTime fechaHoraReserva { get; set; }

        TimeSpan duracionReserva { get; set; }

        public void nuevaReservaGuiada(PantallaRegistrarReserva pantallaRegistrarReserva)
        {
            this.pantallaRegistrarReserva = pantallaRegistrarReserva;

            // Obtenemos una lista de escuelas de la base de datos
            this.escuelas = obtenerEscuelas();

            this.pantallaRegistrarReserva.mostrarEscuelas(escuelas);
        }

        public IList<Escuela> obtenerEscuelas()
        {
            // Mediante entity framework se obtienen todos los objetos de clase Escuela
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
            sede = obtenerSedes();

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

            tipoVisitas = obtenerTiposVisita();

            this.pantallaRegistrarReserva.mostrarTipoVisita(tipoVisitas);

        }

        public IList<TipoVisita> obtenerTiposVisita()
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
            exposiciones = buscarExposicionesTemporalesVigentes();

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
                    if(empleado.sosGuia())
                    {
                        // buscaremos todas las instancias de asignaciones de reserva y verificaremos si es de nuestro empleado
                        // si lo es: verifico si la asignacion NO ES durante el tiempo de nuestra reserva, de ser el caso
                        // guias.add(empleado)

                        // O hacemos que el empleado conozca sus asignaciones?????
                        // en ese caso deberiamos explicitarlo en el diagrama de clases
                    }
                }
                
            }

        }

        public List<Empleado> obtenerGuiasSedeSeleccionada(Sede sede)
        {
            using(ppaiContext context = new ppaiContext())
            {
                empleados = context.Empleado.Include(e => e.IdCargoNavigation).Where(e => e.IdSede == sede.Id).ToList();

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
