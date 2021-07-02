using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPAI_3K4
{
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void iniciarCuRegistrarReservaDeVisitaGuiada(object sender, EventArgs e)
        {
            var pantalla = new PantallaRegistrarReserva();
            var gestorRegistrarReserva = new GestorRegistrarReserva();

            pantalla.opcionRegistrarReservaDeVisitasGuiadas(gestorRegistrarReserva);
        }
    }
}
