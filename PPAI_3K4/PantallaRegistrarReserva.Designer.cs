﻿
namespace PPAI_3K4
{
    partial class PantallaRegistrarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelEscuela = new System.Windows.Forms.Panel();
            this.comboEscuelas = new System.Windows.Forms.ComboBox();
            this.pnlCantidadVisitantes = new System.Windows.Forms.Panel();
            this.btnSiguienteCantVisitantes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantVisitantes = new System.Windows.Forms.TextBox();
            this.pnlTipoVisita = new System.Windows.Forms.Panel();
            this.comboTipoVisitas = new System.Windows.Forms.ComboBox();
            this.btnSigTipoVisita = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSelSedes = new System.Windows.Forms.Panel();
            this.comboSedes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlExposiciones = new System.Windows.Forms.Panel();
            this.btnSelExposicion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFechaHoraReserva = new System.Windows.Forms.Panel();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.btnSigSelFechaYHora = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSelGuias = new System.Windows.Forms.Panel();
            this.lblCantidadGuiasNecesarios = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSigSelGuia = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgGuias = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConfirmacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listboxExpos = new System.Windows.Forms.CheckedListBox();
            this.panelSelEscuela.SuspendLayout();
            this.pnlCantidadVisitantes.SuspendLayout();
            this.pnlTipoVisita.SuspendLayout();
            this.pnlSelSedes.SuspendLayout();
            this.pnlExposiciones.SuspendLayout();
            this.pnlFechaHoraReserva.SuspendLayout();
            this.pnlSelGuias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuias)).BeginInit();
            this.pnlConfirmacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.seleccionarEscuela);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una escuela";
            // 
            // panelSelEscuela
            // 
            this.panelSelEscuela.Controls.Add(this.comboEscuelas);
            this.panelSelEscuela.Controls.Add(this.button1);
            this.panelSelEscuela.Controls.Add(this.label1);
            this.panelSelEscuela.Location = new System.Drawing.Point(3, 12);
            this.panelSelEscuela.Name = "panelSelEscuela";
            this.panelSelEscuela.Size = new System.Drawing.Size(29, 30);
            this.panelSelEscuela.TabIndex = 3;
            // 
            // comboEscuelas
            // 
            this.comboEscuelas.FormattingEnabled = true;
            this.comboEscuelas.Location = new System.Drawing.Point(205, 163);
            this.comboEscuelas.Name = "comboEscuelas";
            this.comboEscuelas.Size = new System.Drawing.Size(168, 22);
            this.comboEscuelas.TabIndex = 3;
            this.comboEscuelas.Text = "selecione";
            // 
            // pnlCantidadVisitantes
            // 
            this.pnlCantidadVisitantes.Controls.Add(this.btnSiguienteCantVisitantes);
            this.pnlCantidadVisitantes.Controls.Add(this.label2);
            this.pnlCantidadVisitantes.Controls.Add(this.txtCantVisitantes);
            this.pnlCantidadVisitantes.Location = new System.Drawing.Point(51, 11);
            this.pnlCantidadVisitantes.Name = "pnlCantidadVisitantes";
            this.pnlCantidadVisitantes.Size = new System.Drawing.Size(35, 41);
            this.pnlCantidadVisitantes.TabIndex = 3;
            this.pnlCantidadVisitantes.Visible = false;
            // 
            // btnSiguienteCantVisitantes
            // 
            this.btnSiguienteCantVisitantes.Location = new System.Drawing.Point(271, 172);
            this.btnSiguienteCantVisitantes.Name = "btnSiguienteCantVisitantes";
            this.btnSiguienteCantVisitantes.Size = new System.Drawing.Size(126, 33);
            this.btnSiguienteCantVisitantes.TabIndex = 4;
            this.btnSiguienteCantVisitantes.Text = "Siguiente";
            this.btnSiguienteCantVisitantes.UseVisualStyleBackColor = true;
            this.btnSiguienteCantVisitantes.Click += new System.EventHandler(this.seleccionarCantidadVisitantes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de visitantes";
            // 
            // txtCantVisitantes
            // 
            this.txtCantVisitantes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantVisitantes.Location = new System.Drawing.Point(220, 123);
            this.txtCantVisitantes.Name = "txtCantVisitantes";
            this.txtCantVisitantes.Size = new System.Drawing.Size(240, 35);
            this.txtCantVisitantes.TabIndex = 0;
            // 
            // pnlTipoVisita
            // 
            this.pnlTipoVisita.Controls.Add(this.comboTipoVisitas);
            this.pnlTipoVisita.Controls.Add(this.btnSigTipoVisita);
            this.pnlTipoVisita.Controls.Add(this.label3);
            this.pnlTipoVisita.Location = new System.Drawing.Point(154, 11);
            this.pnlTipoVisita.Name = "pnlTipoVisita";
            this.pnlTipoVisita.Size = new System.Drawing.Size(38, 39);
            this.pnlTipoVisita.TabIndex = 3;
            this.pnlTipoVisita.Visible = false;
            // 
            // comboTipoVisitas
            // 
            this.comboTipoVisitas.FormattingEnabled = true;
            this.comboTipoVisitas.Location = new System.Drawing.Point(233, 159);
            this.comboTipoVisitas.Name = "comboTipoVisitas";
            this.comboTipoVisitas.Size = new System.Drawing.Size(173, 22);
            this.comboTipoVisitas.TabIndex = 5;
            this.comboTipoVisitas.Text = "Seleccione";
            // 
            // btnSigTipoVisita
            // 
            this.btnSigTipoVisita.Location = new System.Drawing.Point(285, 234);
            this.btnSigTipoVisita.Name = "btnSigTipoVisita";
            this.btnSigTipoVisita.Size = new System.Drawing.Size(100, 30);
            this.btnSigTipoVisita.TabIndex = 4;
            this.btnSigTipoVisita.Text = "Siguiente";
            this.btnSigTipoVisita.UseVisualStyleBackColor = true;
            this.btnSigTipoVisita.Click += new System.EventHandler(this.seleccionarTipoVisita);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione un tipo de visita";
            // 
            // pnlSelSedes
            // 
            this.pnlSelSedes.Controls.Add(this.comboSedes);
            this.pnlSelSedes.Controls.Add(this.label4);
            this.pnlSelSedes.Controls.Add(this.button3);
            this.pnlSelSedes.Location = new System.Drawing.Point(115, 11);
            this.pnlSelSedes.Name = "pnlSelSedes";
            this.pnlSelSedes.Size = new System.Drawing.Size(19, 39);
            this.pnlSelSedes.TabIndex = 4;
            this.pnlSelSedes.Visible = false;
            // 
            // comboSedes
            // 
            this.comboSedes.FormattingEnabled = true;
            this.comboSedes.Location = new System.Drawing.Point(138, 164);
            this.comboSedes.Name = "comboSedes";
            this.comboSedes.Size = new System.Drawing.Size(310, 22);
            this.comboSedes.TabIndex = 3;
            this.comboSedes.Text = "Seleccione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione una sede";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 26);
            this.button3.TabIndex = 1;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.seleccionarSede);
            // 
            // pnlExposiciones
            // 
            this.pnlExposiciones.Controls.Add(this.listboxExpos);
            this.pnlExposiciones.Controls.Add(this.btnSelExposicion);
            this.pnlExposiciones.Controls.Add(this.label5);
            this.pnlExposiciones.Location = new System.Drawing.Point(12, 11);
            this.pnlExposiciones.Name = "pnlExposiciones";
            this.pnlExposiciones.Size = new System.Drawing.Size(692, 344);
            this.pnlExposiciones.TabIndex = 5;
            this.pnlExposiciones.Visible = false;
            // 
            // btnSelExposicion
            // 
            this.btnSelExposicion.Location = new System.Drawing.Point(547, 288);
            this.btnSelExposicion.Name = "btnSelExposicion";
            this.btnSelExposicion.Size = new System.Drawing.Size(107, 32);
            this.btnSelExposicion.TabIndex = 5;
            this.btnSelExposicion.Text = "Siguiente";
            this.btnSelExposicion.UseVisualStyleBackColor = true;
            this.btnSelExposicion.Click += new System.EventHandler(this.seleccionarExposiciones);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Seleccione una exposicion";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pnlFechaHoraReserva
            // 
            this.pnlFechaHoraReserva.Controls.Add(this.dtpHoraReserva);
            this.pnlFechaHoraReserva.Controls.Add(this.btnSigSelFechaYHora);
            this.pnlFechaHoraReserva.Controls.Add(this.dtpFechaReserva);
            this.pnlFechaHoraReserva.Controls.Add(this.label6);
            this.pnlFechaHoraReserva.Location = new System.Drawing.Point(220, 11);
            this.pnlFechaHoraReserva.Name = "pnlFechaHoraReserva";
            this.pnlFechaHoraReserva.Size = new System.Drawing.Size(17, 31);
            this.pnlFechaHoraReserva.TabIndex = 6;
            this.pnlFechaHoraReserva.Visible = false;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(349, 139);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(153, 35);
            this.dtpHoraReserva.TabIndex = 9;
            // 
            // btnSigSelFechaYHora
            // 
            this.btnSigSelFechaYHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSigSelFechaYHora.Location = new System.Drawing.Point(261, 192);
            this.btnSigSelFechaYHora.Name = "btnSigSelFechaYHora";
            this.btnSigSelFechaYHora.Size = new System.Drawing.Size(157, 36);
            this.btnSigSelFechaYHora.TabIndex = 8;
            this.btnSigSelFechaYHora.Text = "Siguiente";
            this.btnSigSelFechaYHora.UseVisualStyleBackColor = true;
            this.btnSigSelFechaYHora.Click += new System.EventHandler(this.seleccionarFechaYHora);
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(180, 139);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(153, 35);
            this.dtpFechaReserva.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(180, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingrese fecha y hora de la reserva";
            // 
            // pnlSelGuias
            // 
            this.pnlSelGuias.Controls.Add(this.lblCantidadGuiasNecesarios);
            this.pnlSelGuias.Controls.Add(this.label7);
            this.pnlSelGuias.Controls.Add(this.btnSigSelGuia);
            this.pnlSelGuias.Controls.Add(this.label8);
            this.pnlSelGuias.Controls.Add(this.dgGuias);
            this.pnlSelGuias.Location = new System.Drawing.Point(253, 11);
            this.pnlSelGuias.Name = "pnlSelGuias";
            this.pnlSelGuias.Size = new System.Drawing.Size(20, 31);
            this.pnlSelGuias.TabIndex = 7;
            this.pnlSelGuias.Visible = false;
            // 
            // lblCantidadGuiasNecesarios
            // 
            this.lblCantidadGuiasNecesarios.AutoSize = true;
            this.lblCantidadGuiasNecesarios.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadGuiasNecesarios.Location = new System.Drawing.Point(357, 290);
            this.lblCantidadGuiasNecesarios.Name = "lblCantidadGuiasNecesarios";
            this.lblCantidadGuiasNecesarios.Size = new System.Drawing.Size(0, 24);
            this.lblCantidadGuiasNecesarios.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(61, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad de guias necesarios: ";
            // 
            // btnSigSelGuia
            // 
            this.btnSigSelGuia.Location = new System.Drawing.Point(524, 346);
            this.btnSigSelGuia.Name = "btnSigSelGuia";
            this.btnSigSelGuia.Size = new System.Drawing.Size(119, 34);
            this.btnSigSelGuia.TabIndex = 6;
            this.btnSigSelGuia.Text = "Siguiente";
            this.btnSigSelGuia.UseVisualStyleBackColor = true;
            this.btnSigSelGuia.Click += new System.EventHandler(this.tomarSeleccionGuia);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(61, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seleccione una guia";
            // 
            // dgGuias
            // 
            this.dgGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGuias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.dataGridViewTextBoxColumn9,
            this.telefono,
            this.sexo,
            this.dataGridViewTextBoxColumn10});
            this.dgGuias.Location = new System.Drawing.Point(61, 112);
            this.dgGuias.Name = "dgGuias";
            this.dgGuias.RowTemplate.Height = 25;
            this.dgGuias.Size = new System.Drawing.Size(545, 158);
            this.dgGuias.TabIndex = 0;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "Sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // pnlConfirmacion
            // 
            this.pnlConfirmacion.Controls.Add(this.button2);
            this.pnlConfirmacion.Controls.Add(this.label9);
            this.pnlConfirmacion.Controls.Add(this.button4);
            this.pnlConfirmacion.Location = new System.Drawing.Point(382, 11);
            this.pnlConfirmacion.Name = "pnlConfirmacion";
            this.pnlConfirmacion.Size = new System.Drawing.Size(49, 31);
            this.pnlConfirmacion.TabIndex = 8;
            this.pnlConfirmacion.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(139, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(550, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Por favor, confirme el registro de la reserva";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tomarConfirmacion);
            // 
            // listboxExpos
            // 
            this.listboxExpos.BackColor = System.Drawing.SystemColors.Window;
            this.listboxExpos.CheckOnClick = true;
            this.listboxExpos.FormattingEnabled = true;
            this.listboxExpos.Location = new System.Drawing.Point(68, 123);
            this.listboxExpos.Name = "listboxExpos";
            this.listboxExpos.Size = new System.Drawing.Size(522, 94);
            this.listboxExpos.Sorted = true;
            this.listboxExpos.TabIndex = 6;
            // 
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 401);
            this.Controls.Add(this.pnlConfirmacion);
            this.Controls.Add(this.pnlSelGuias);
            this.Controls.Add(this.pnlFechaHoraReserva);
            this.Controls.Add(this.pnlExposiciones);
            this.Controls.Add(this.pnlCantidadVisitantes);
            this.Controls.Add(this.pnlTipoVisita);
            this.Controls.Add(this.pnlSelSedes);
            this.Controls.Add(this.panelSelEscuela);
            this.Name = "PantallaRegistrarReserva";
            this.Text = "PantallaRegistrarReserva";
            this.panelSelEscuela.ResumeLayout(false);
            this.panelSelEscuela.PerformLayout();
            this.pnlCantidadVisitantes.ResumeLayout(false);
            this.pnlCantidadVisitantes.PerformLayout();
            this.pnlTipoVisita.ResumeLayout(false);
            this.pnlTipoVisita.PerformLayout();
            this.pnlSelSedes.ResumeLayout(false);
            this.pnlSelSedes.PerformLayout();
            this.pnlExposiciones.ResumeLayout(false);
            this.pnlExposiciones.PerformLayout();
            this.pnlFechaHoraReserva.ResumeLayout(false);
            this.pnlFechaHoraReserva.PerformLayout();
            this.pnlSelGuias.ResumeLayout(false);
            this.pnlSelGuias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuias)).EndInit();
            this.pnlConfirmacion.ResumeLayout(false);
            this.pnlConfirmacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSelEscuela;
        private System.Windows.Forms.Panel pnlCantidadVisitantes;
        private System.Windows.Forms.Button btnSiguienteCantVisitantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantVisitantes;
        private System.Windows.Forms.Panel pnlSelSedes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTipoVisita;
        private System.Windows.Forms.Button btnSigTipoVisita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlExposiciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnSelExposicion;
        private System.Windows.Forms.Panel pnlFechaHoraReserva;
        private System.Windows.Forms.Button btnSigSelFechaYHora;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHoraReserva;
        private System.Windows.Forms.Panel pnlSelGuias;
        private System.Windows.Forms.Button btnSigSelGuia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgGuias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblCantidadGuiasNecesarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlConfirmacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboEscuelas;
        private System.Windows.Forms.ComboBox comboSedes;
        private System.Windows.Forms.ComboBox comboTipoVisitas;
        private System.Windows.Forms.CheckedListBox listboxExpos;
    }
}