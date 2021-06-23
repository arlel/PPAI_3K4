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
        GestorRegistrarReserva oGestor { get; set; }

        public void opcionRegistrarReservaDeVisitasGuiadas()
        {
            this.habilitarPantalla();

            oGestor = new GestorRegistrarReserva();
            oGestor.nuevaReservaGuiada(this);
        }

        public void mostrarEscuelas(IList<Escuela> escuelas)
        {

            dgEscuelas.AutoGenerateColumns = false;
            dgEscuelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEscuelas.DataSource = escuelas;
            dgEscuelas.Refresh();


        }

        public void habilitarPantalla()
        {
            this.Show();
        }

        private void seleccionarEscuela(object sender, EventArgs e)
        {
            Escuela escuelaSeleccionada = (Escuela)dgEscuelas.SelectedRows[0].DataBoundItem;
            oGestor.tomarSeleccionEscuela(escuelaSeleccionada);
        }

        public void solicitarCantidadVisitantes()
        {
            panelSelEscuela.Visible = false;

            pnlCantidadVisitantes.Location = new Point(0, 0);
            pnlCantidadVisitantes.Anchor = AnchorStyles.None;
            pnlCantidadVisitantes.Width = this.ClientSize.Width;
            pnlCantidadVisitantes.Height = this.ClientSize.Height;
            pnlCantidadVisitantes.Visible = true;
        }

        private void tomarCantidadParticipantes(object sender, EventArgs e)
        {
            oGestor.tomarCantidadParticipantes(Int32.Parse(txtCantVisitantes.Text));
        }

        public void mostrarSedes(IList<Sede> sede)
        {
            pnlCantidadVisitantes.Visible = false;

            pnlSelSedes.Location = new Point(0, 0);
            pnlSelSedes.Anchor = AnchorStyles.None;
            pnlSelSedes.Width = this.ClientSize.Width;
            pnlSelSedes.Height = this.ClientSize.Height;
            pnlSelSedes.Visible = true;

            dgSedes.AutoGenerateColumns = false;
            dgSedes.DataSource = sede;
        }

        private void seleccionarSede(object sender, EventArgs e)
        {
            Sede sedeSeleccionada = (Sede)dgSedes.SelectedRows[0].DataBoundItem;
            oGestor.tomarSeleccionSede(sedeSeleccionada);
        }

        public void mostrarTipoVisita(IList<TipoVisita> tipoVisitas)
        {
            pnlSelSedes.Visible = false;

            pnlTipoVisita.Location = new Point(0, 0);
            pnlTipoVisita.Anchor = AnchorStyles.None;
            pnlTipoVisita.Width = this.ClientSize.Width;
            pnlTipoVisita.Height = this.ClientSize.Height;
            pnlTipoVisita.Visible = true;

            dgTipoVisita.AutoGenerateColumns = false;
            dgTipoVisita.DataSource = tipoVisitas;

        }

        private void btnSigTipoVisita_Click(object sender, EventArgs e)
        {
            TipoVisita tipoVisitaSel = (TipoVisita)dgTipoVisita.SelectedRows[0].DataBoundItem;
            oGestor.tomarSeleccionTipoVisita(tipoVisitaSel);
        }
    }
}
