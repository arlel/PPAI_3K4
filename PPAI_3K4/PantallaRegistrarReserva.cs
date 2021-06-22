using PPAI_3K4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPAI_3K4
{
    public partial class PantallaRegistrarReserva : Form
    {
        public PantallaRegistrarReserva()
        {
            InitializeComponent();
        }

        public void opcionRegistrarReservaDeVisitasGuiadas()
        {
            this.habilitarPantalla();

            GestorRegistrarReserva oGestor = new GestorRegistrarReserva();
            oGestor.nuevaReservaGuiada(this);
        }

        public void mostrarEscuelas(IList<Escuela> escuelas)
        {

            dgEscuelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEscuelas.DataSource = escuelas;
            dgEscuelas.AutoGenerateColumns = true;
            dgEscuelas.Refresh();


        }

        public void habilitarPantalla()
        {
            this.Show();
        }

    }
}
