﻿using PPAI_3K4.Models;
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
            //ocultarPantalla();
        }

        private void seleccionarEscuela(object sender, EventArgs e)
        {
            int indiceEscuelaSeleccionada = comboEscuelas.SelectedIndex;
            //Validacion de dato seleccionado.
            if (indiceEscuelaSeleccionada != -1)
            {
                ocultarPanel(panelSelEscuela);
                gestorRegistrarReserva.tomarSeleccionEscuela(indiceEscuelaSeleccionada);
            }
            else
            {
                this.mostrarMensaje("Debe seleccionar una escuela.");
            }
            
        }

        public void solicitarCantidadVisitantes()
        {
            mostrarPanel(pnlCantidadVisitantes);
        }

        private void seleccionarCantidadVisitantes(object sender, EventArgs e)
        {
            try
            {
                int visitantes = Int32.Parse(txtCantVisitantes.Text);
                if (visitantes < 1)
                {
                    this.mostrarMensaje("No puede reservar para menos de 1 visitante");
                }
                else
                {
                    ocultarPanel(pnlCantidadVisitantes);
                    gestorRegistrarReserva.tomarCantidadVisitantes(visitantes);
                }
            }
            catch (Exception ex)
            {
                this.mostrarMensaje("Debe ingresar informacion valida");
            }
        }

        public void mostrarSedes(String[] sedes)
        {
            comboSedes.Items.Clear();
            comboSedes.Items.AddRange(sedes);
            comboSedes.Refresh();
            mostrarPanel(pnlSelSedes);
        }

        private void seleccionarSede(object sender, EventArgs e)
        {
            int iSedeSeleccionada = comboSedes.SelectedIndex;
            if (iSedeSeleccionada == -1)
            {
                this.mostrarMensaje("Seleccione una sede.");
            }
            else
            {
                ocultarPanel(pnlSelSedes);
                gestorRegistrarReserva.tomarSeleccionSede(iSedeSeleccionada);
            }

        }

        public void mostrarTipoVisita(String[] tipoVisitas)
        {
            comboTipoVisitas.Items.Clear();
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
            if (iTipoVisitaSel == -1)
            {
                this.mostrarMensaje("Seleccione un tipo de visita.");
            }
            else
            {
                if (iTipoVisitaSel == 0)
                {
                    this.mostrarMensaje("Esta funcionalidad no esta implementada.");
                }
                else
                {
                    ocultarPanel(pnlTipoVisita);
                    gestorRegistrarReserva.tomarSeleccionTipoVisita(iTipoVisitaSel);
                }
            }

        }

        public void mostrarExposiciones(String[] expos)
        {
            mostrarPanel(pnlExposiciones);
            listboxExpos.Items.Clear();
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
            if(checkeds.Count == 0)
            {
                this.mostrarMensaje("debe seleccionar almenos una exposicion");
            }
            else
            {
                ocultarPanel(pnlExposiciones);
                gestorRegistrarReserva.tomarSeleccionExposiciones(checkeds);
            }
            
        }

        public void solicitarFechaHoraReserva()
        {
            mostrarPanel(pnlFechaHoraReserva);
        }

        private void seleccionarFechaYHora(object sender, EventArgs e)
        {
            // Se consulta la fecha y hora a los objetos correspondientes y se agrupa en el mismo objeto DateTime
            DateTime fechaHoraReserva = dtpFechaReserva.Value.Date + dtpHoraReserva.Value.TimeOfDay;
            // No supe hacer la validacion para esto
            ocultarPanel(pnlFechaHoraReserva);
            gestorRegistrarReserva.tomarSeleccionFechaHora(fechaHoraReserva);
        }

        public void mostrarCantidadGuiasNecesarias(int cantidadGuiasNecesarios)
        {
            lblCantidadGuiasNecesarios.Text = cantidadGuiasNecesarios.ToString();
        }

        public void mostrarGuias(String[] guias)
        {
            mostrarPanel(pnlSelGuias);
            listboxGuias.Items.Clear();
            listboxGuias.Items.AddRange(guias);
            listboxGuias.Refresh();
        }

        private void tomarSeleccionGuia(object sender, EventArgs e)
        {
            ocultarPanel(pnlSelGuias);

            List<int> checkeds = new List<int>();
            // Se consulta a la tabla de exposiciones las filas seleccionadas y se agregan a la lista exposicionesSeleccionadas
            foreach (Object item in listboxGuias.CheckedItems)
            {
                checkeds.Add(listboxGuias.Items.IndexOf(item));
            }
            
            gestorRegistrarReserva.tomarSeleccionGuias(checkeds);
        }

        public void solicitarConfirmacion()
        {
            mostrarPanel(pnlConfirmacion);
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            gestorRegistrarReserva.tomarConfirmacion();
        }

        public void mostrarPanelGuias()
        {
            mostrarPanel(pnlSelGuias);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void cancelarEscuela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void atrasVisitantes_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlCantidadVisitantes);
            mostrarPanel(panelSelEscuela);
        }

        private void atrasSede_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlSelSedes);
            mostrarPanel(pnlCantidadVisitantes);
        }
        private void atrasVisita_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlTipoVisita);
            mostrarPanel(pnlSelSedes);
        }

        private void atrasExpo_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlExposiciones);
            mostrarPanel(pnlTipoVisita);
        }
        private void atrasFyH_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlFechaHoraReserva);
            mostrarPanel(pnlExposiciones);
        }

        private void atrasGuia_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlSelGuias);
            mostrarPanel(pnlFechaHoraReserva);
        }

        private void atrasConfirmar_Click(object sender, EventArgs e)
        {
            ocultarPanel(pnlConfirmacion);
            mostrarPanel(pnlSelGuias);
        }

        public void atrasPnlGuia()
        {
            mostrarPanel(pnlFechaHoraReserva);
        }

        public void atrasPnlTipoVisita()
        {
            mostrarPanel(pnlSelSedes);
        }

        public void atrasPnlVisitantes()
        {
            mostrarPanel(panelSelEscuela);
        }


    }
}
