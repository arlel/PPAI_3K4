using PPAI_3K4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPAI_3K4
{
    public class GestorRegistrarReserva
    {
        PantallaRegistrarReserva pantallaRegistrarReserva { get; set; }
        public void nuevaReservaGuiada(PantallaRegistrarReserva pantallaRegistrarReserva) 
        {
            this.pantallaRegistrarReserva = pantallaRegistrarReserva;

            Escuela escuela = new Escuela();
            var escuelas = escuela.mostrarEscuelas();

            this.pantallaRegistrarReserva.mostrarEscuelas(escuelas);
        }
    }
}
