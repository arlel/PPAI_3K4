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
        GestorRegistrarReserva gestorRegistrarReserva { get; set; }

        public void opcionRegistrarReservaDeVisitasGuiadas(GestorRegistrarReserva gestorRegistrarReserva)
        {
            this.habilitarPantalla();
            mostrarPanel(panelSelEscuela);

            this.gestorRegistrarReserva = gestorRegistrarReserva;
            this.gestorRegistrarReserva.nuevaReservaGuiada(this);
        }

        public void mostrarEscuelas(String[] escuelas)
        {
            // Se muestra en la tabla de escuela el listado de escuela que recibimos como parametro
            comboEscuelas.Items.AddRange(escuelas);
            comboEscuelas.Refresh();
        }

        public void habilitarPantalla()
        {
            // Muestra la ventana
            this.Show();
        }

        public void ocultarPantalla()
        {
            this.Dispose();
        }

        public void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK);
            ocultarPantalla();
        }

        private void seleccionarEscuela(object sender, EventArgs e)
        {
            int indiceEscuelaSeleccionada = comboEscuelas.SelectedIndex;
            ocultarPanel(panelSelEscuela);
            gestorRegistrarReserva.tomarSeleccionEscuela(indiceEscuelaSeleccionada);
        }

        public void solicitarCantidadVisitantes()
        {
            mostrarPanel(pnlCantidadVisitantes);
        }

        private void seleccionarCantidadVisitantes(object sender, EventArgs e)
        {
            ocultarPanel(pnlCantidadVisitantes);
            gestorRegistrarReserva.tomarCantidadVisitantes(Int32.Parse(txtCantVisitantes.Text));
        }

        public void mostrarSedes(String[] sedes)
        {
            comboSedes.Items.AddRange(sedes);
            comboSedes.Refresh();
            mostrarPanel(pnlSelSedes);
        }

        private void seleccionarSede(object sender, EventArgs e)
        {
            int iSedeSeleccionada = comboSedes.SelectedIndex;
            ocultarPanel(pnlSelSedes);
            gestorRegistrarReserva.tomarSeleccionSede(iSedeSeleccionada);
        }

        public void mostrarTipoVisita(String[] tipoVisitas)
        {
            comboTipoVisitas.Items.AddRange(tipoVisitas);
            comboTipoVisitas.Refresh();
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
            int iTipoVisitaSel = comboTipoVisitas.SelectedIndex;
            ocultarPanel(pnlTipoVisita);
            gestorRegistrarReserva.tomarSeleccionTipoVisita(iTipoVisitaSel);
        }

        public void mostrarExposiciones(String[] expos)
        {
            mostrarPanel(pnlExposiciones);

            listboxExpos.Items.AddRange(expos);
            listboxExpos.Refresh();
        }

        private void seleccionarExposiciones(object sender, EventArgs e)
        {
            List<int> checkeds = new List<int>();
                        // Se consulta a la tabla de exposiciones las filas seleccionadas y se agregan a la lista exposicionesSeleccionadas
            foreach (Object item in listboxExpos.CheckedItems)
            {
                checkeds.Add(listboxExpos.Items.IndexOf(item));
            }

            ocultarPanel(pnlExposiciones);
            gestorRegistrarReserva.tomarSeleccionExposiciones(checkeds);
        }

        public void solicitarFechaHoraReserva()
        {
            mostrarPanel(pnlFechaHoraReserva);
        }

        private void seleccionarFechaYHora(object sender, EventArgs e)
        {
            // Se consulta la fecha y hora a los objetos correspondientes y se agrupa en el mismo objeto DateTime
            DateTime fechaHoraReserva = dtpFechaReserva.Value.Date + dtpHoraReserva.Value.TimeOfDay;

            ocultarPanel(pnlFechaHoraReserva);
            gestorRegistrarReserva.tomarSeleccionFechaHora(fechaHoraReserva);
        }

        public void mostrarCantidadGuiasNecesarias(int cantidadGuiasNecesarios)
        {
            lblCantidadGuiasNecesarios.Text = cantidadGuiasNecesarios.ToString();
        }

        public void mostrarGuias(List<Empleado> guias)
        {
            mostrarPanel(pnlSelGuias);

            dgGuias.AutoGenerateColumns = false;
            dgGuias.DataSource = guias;
        }

        private void tomarSeleccionGuia(object sender, EventArgs e)
        {
            ocultarPanel(pnlSelGuias);

            IList<Empleado> guiasSeleccionados = new List<Empleado>();

            // Se consulta a la tabla de guias los guias seleccionados y se los agrega a la lista guiasSeleccionados
            foreach (DataGridViewRow row in dgGuias.SelectedRows)
            {
                guiasSeleccionados.Add((Empleado)row.DataBoundItem);
            }

            gestorRegistrarReserva.tomarSeleccionGuias(guiasSeleccionados);
        }

        public void solicitarConfirmacion()
        {
            mostrarPanel(pnlConfirmacion);
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            gestorRegistrarReserva.tomarConfirmacion();
        }
    }
}
