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
            mostrarPanel(panelSelEscuela);
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
            ocultarPanel(panelSelEscuela);
            oGestor.tomarSeleccionEscuela(escuelaSeleccionada);
        }

        public void solicitarCantidadVisitantes()
        {
            mostrarPanel(pnlCantidadVisitantes);
        }

        private void tomarCantidadParticipantes(object sender, EventArgs e)
        {
            ocultarPanel(pnlCantidadVisitantes);
            oGestor.tomarCantidadParticipantes(Int32.Parse(txtCantVisitantes.Text));
        }

        public void mostrarSedes(IList<Sede> sede)
        {
         
            dgSedes.AutoGenerateColumns = false;
            dgSedes.DataSource = sede;
            mostrarPanel(pnlSelSedes);
        }

        private void seleccionarSede(object sender, EventArgs e)
        {
            Sede sedeSeleccionada = (Sede)dgSedes.SelectedRows[0].DataBoundItem;
            ocultarPanel(pnlSelSedes);
            oGestor.tomarSeleccionSede(sedeSeleccionada);
        }

        public void mostrarTipoVisita(IList<TipoVisita> tipoVisitas)
        {
            dgTipoVisita.AutoGenerateColumns = false;
            dgTipoVisita.DataSource = tipoVisitas;

            mostrarPanel(pnlTipoVisita);
        }

        public void mostrarPanel(Panel panel)
        {
            panel.Location = new Point(0, 0);
            panel.Anchor = AnchorStyles.None;
            panel.Width = this.ClientSize.Width;
            panel.Height = this.ClientSize.Height;
            panel.Visible = true;
        }

        public void ocultarPanel(Panel panel)
        {
            panel.Location = new Point(0, 0);
            panel.Anchor = AnchorStyles.None;
            panel.Width = this.ClientSize.Width;
            panel.Height = this.ClientSize.Height;
            panel.Visible = false;
        }

        private void seleccionarTipoVisita(object sender, EventArgs e)
        {
            TipoVisita tipoVisitaSel = (TipoVisita)dgTipoVisita.SelectedRows[0].DataBoundItem;
            ocultarPanel(pnlTipoVisita);
            oGestor.tomarSeleccionTipoVisita(tipoVisitaSel);
        }

        public void mostrarExposiciones(IList<Exposicion> exposicion)
        {
            mostrarPanel(pnlExposiciones);

            dgExposiciones.AutoGenerateColumns = false;
            dgExposiciones.DataSource = exposicion;
        }

        private void seleccionarExposiciones(object sender, EventArgs e)
        {
            IList<Exposicion> exposicionesSeleccionadas = new List<Exposicion>();

            foreach(DataGridViewRow row in dgExposiciones.SelectedRows)
            {
                exposicionesSeleccionadas.Add((Exposicion)row.DataBoundItem);
            }
            ocultarPanel(pnlExposiciones);
            oGestor.tomarSeleccionExposiciones(exposicionesSeleccionadas);
        }

        public void solicitarFechaHoraReserva()
        {
            mostrarPanel(pnlFechaHoraReserva);
        }

        private void seleccionarFechaYHora(object sender, EventArgs e)
        {
            DateTime fechaHoraReserva = dtpFechaReserva.Value.Date + dtpHoraReserva.Value.TimeOfDay;

            ocultarPanel(pnlFechaHoraReserva);
            oGestor.tomarSeleccionFechaHora(fechaHoraReserva);
        }
    }
}
