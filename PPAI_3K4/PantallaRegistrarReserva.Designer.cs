
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
            this.dgEscuelas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelEscuela = new System.Windows.Forms.Panel();
            this.pnlCantidadVisitantes = new System.Windows.Forms.Panel();
            this.btnSiguienteCantVisitantes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantVisitantes = new System.Windows.Forms.TextBox();
            this.pnlTipoVisita = new System.Windows.Forms.Panel();
            this.btnSigTipoVisita = new System.Windows.Forms.Button();
            this.dgTipoVisita = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSelSedes = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgSedes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlExposiciones = new System.Windows.Forms.Panel();
            this.btnSelExposicion = new System.Windows.Forms.Button();
            this.dgExposiciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFechaHoraReserva = new System.Windows.Forms.Panel();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.btnSigSelFechaYHora = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSelGuias = new System.Windows.Forms.Panel();
            this.btnSigSelGuia = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgGuias = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscuelas)).BeginInit();
            this.panelSelEscuela.SuspendLayout();
            this.pnlCantidadVisitantes.SuspendLayout();
            this.pnlTipoVisita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoVisita)).BeginInit();
            this.pnlSelSedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSedes)).BeginInit();
            this.pnlExposiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExposiciones)).BeginInit();
            this.pnlFechaHoraReserva.SuspendLayout();
            this.pnlSelGuias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEscuelas
            // 
            this.dgEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEscuelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Domicilio,
            this.Mail,
            this.telefCelular,
            this.telefFijo});
            this.dgEscuelas.Location = new System.Drawing.Point(20, 67);
            this.dgEscuelas.MultiSelect = false;
            this.dgEscuelas.Name = "dgEscuelas";
            this.dgEscuelas.RowTemplate.Height = 25;
            this.dgEscuelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEscuelas.Size = new System.Drawing.Size(643, 287);
            this.dgEscuelas.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // telefCelular
            // 
            this.telefCelular.DataPropertyName = "TelefCelular";
            this.telefCelular.HeaderText = "Telefono Celular";
            this.telefCelular.Name = "telefCelular";
            this.telefCelular.ReadOnly = true;
            // 
            // telefFijo
            // 
            this.telefFijo.DataPropertyName = "TelefFijo";
            this.telefFijo.HeaderText = "Telefono Fijo";
            this.telefFijo.Name = "telefFijo";
            this.telefFijo.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.seleccionarEscuela);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una escuela";
            // 
            // panelSelEscuela
            // 
            this.panelSelEscuela.Controls.Add(this.dgEscuelas);
            this.panelSelEscuela.Controls.Add(this.button1);
            this.panelSelEscuela.Controls.Add(this.label1);
            this.panelSelEscuela.Location = new System.Drawing.Point(3, 12);
            this.panelSelEscuela.Name = "panelSelEscuela";
            this.panelSelEscuela.Size = new System.Drawing.Size(29, 29);
            this.panelSelEscuela.TabIndex = 3;
            // 
            // pnlCantidadVisitantes
            // 
            this.pnlCantidadVisitantes.Controls.Add(this.btnSiguienteCantVisitantes);
            this.pnlCantidadVisitantes.Controls.Add(this.label2);
            this.pnlCantidadVisitantes.Controls.Add(this.txtCantVisitantes);
            this.pnlCantidadVisitantes.Location = new System.Drawing.Point(51, 12);
            this.pnlCantidadVisitantes.Name = "pnlCantidadVisitantes";
            this.pnlCantidadVisitantes.Size = new System.Drawing.Size(39, 26);
            this.pnlCantidadVisitantes.TabIndex = 3;
            this.pnlCantidadVisitantes.Visible = false;
            // 
            // btnSiguienteCantVisitantes
            // 
            this.btnSiguienteCantVisitantes.Location = new System.Drawing.Point(271, 184);
            this.btnSiguienteCantVisitantes.Name = "btnSiguienteCantVisitantes";
            this.btnSiguienteCantVisitantes.Size = new System.Drawing.Size(126, 35);
            this.btnSiguienteCantVisitantes.TabIndex = 4;
            this.btnSiguienteCantVisitantes.Text = "Siguiente";
            this.btnSiguienteCantVisitantes.UseVisualStyleBackColor = true;
            this.btnSiguienteCantVisitantes.Click += new System.EventHandler(this.tomarCantidadParticipantes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de visitantes";
            // 
            // txtCantVisitantes
            // 
            this.txtCantVisitantes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantVisitantes.Location = new System.Drawing.Point(220, 132);
            this.txtCantVisitantes.Name = "txtCantVisitantes";
            this.txtCantVisitantes.Size = new System.Drawing.Size(240, 35);
            this.txtCantVisitantes.TabIndex = 0;
            // 
            // pnlTipoVisita
            // 
            this.pnlTipoVisita.Controls.Add(this.btnSigTipoVisita);
            this.pnlTipoVisita.Controls.Add(this.dgTipoVisita);
            this.pnlTipoVisita.Controls.Add(this.label3);
            this.pnlTipoVisita.Location = new System.Drawing.Point(158, 12);
            this.pnlTipoVisita.Name = "pnlTipoVisita";
            this.pnlTipoVisita.Size = new System.Drawing.Size(22, 29);
            this.pnlTipoVisita.TabIndex = 3;
            this.pnlTipoVisita.Visible = false;
            // 
            // btnSigTipoVisita
            // 
            this.btnSigTipoVisita.Location = new System.Drawing.Point(285, 251);
            this.btnSigTipoVisita.Name = "btnSigTipoVisita";
            this.btnSigTipoVisita.Size = new System.Drawing.Size(100, 32);
            this.btnSigTipoVisita.TabIndex = 4;
            this.btnSigTipoVisita.Text = "Siguiente";
            this.btnSigTipoVisita.UseVisualStyleBackColor = true;
            this.btnSigTipoVisita.Click += new System.EventHandler(this.seleccionarTipoVisita);
            // 
            // dgTipoVisita
            // 
            this.dgTipoVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoVisita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgTipoVisita.Location = new System.Drawing.Point(224, 108);
            this.dgTipoVisita.MultiSelect = false;
            this.dgTipoVisita.Name = "dgTipoVisita";
            this.dgTipoVisita.RowTemplate.Height = 25;
            this.dgTipoVisita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTipoVisita.Size = new System.Drawing.Size(218, 108);
            this.dgTipoVisita.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione un tipo de visita";
            // 
            // pnlSelSedes
            // 
            this.pnlSelSedes.Controls.Add(this.label4);
            this.pnlSelSedes.Controls.Add(this.dgSedes);
            this.pnlSelSedes.Controls.Add(this.button3);
            this.pnlSelSedes.Location = new System.Drawing.Point(115, 12);
            this.pnlSelSedes.Name = "pnlSelSedes";
            this.pnlSelSedes.Size = new System.Drawing.Size(20, 29);
            this.pnlSelSedes.TabIndex = 4;
            this.pnlSelSedes.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione una sede";
            // 
            // dgSedes
            // 
            this.dgSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgSedes.Location = new System.Drawing.Point(20, 67);
            this.dgSedes.MultiSelect = false;
            this.dgSedes.Name = "dgSedes";
            this.dgSedes.RowTemplate.Height = 25;
            this.dgSedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSedes.Size = new System.Drawing.Size(643, 287);
            this.dgSedes.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cantMaximaVisitantes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cant. Maxima Visitantes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cantMaxPorGuia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cant. Maxima por Guia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.seleccionarSede);
            // 
            // pnlExposiciones
            // 
            this.pnlExposiciones.Controls.Add(this.btnSelExposicion);
            this.pnlExposiciones.Controls.Add(this.dgExposiciones);
            this.pnlExposiciones.Controls.Add(this.label5);
            this.pnlExposiciones.Location = new System.Drawing.Point(186, 14);
            this.pnlExposiciones.Name = "pnlExposiciones";
            this.pnlExposiciones.Size = new System.Drawing.Size(28, 27);
            this.pnlExposiciones.TabIndex = 5;
            this.pnlExposiciones.Visible = false;
            // 
            // btnSelExposicion
            // 
            this.btnSelExposicion.Location = new System.Drawing.Point(512, 328);
            this.btnSelExposicion.Name = "btnSelExposicion";
            this.btnSelExposicion.Size = new System.Drawing.Size(119, 36);
            this.btnSelExposicion.TabIndex = 5;
            this.btnSelExposicion.Text = "Siguiente";
            this.btnSelExposicion.UseVisualStyleBackColor = true;
            this.btnSelExposicion.Click += new System.EventHandler(this.seleccionarExposiciones);
            // 
            // dgExposiciones
            // 
            this.dgExposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExposiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.FechaInicio,
            this.FechaFin,
            this.HoraApertura,
            this.HoraCierre});
            this.dgExposiciones.Location = new System.Drawing.Point(19, 59);
            this.dgExposiciones.Name = "dgExposiciones";
            this.dgExposiciones.RowTemplate.Height = 25;
            this.dgExposiciones.Size = new System.Drawing.Size(644, 103);
            this.dgExposiciones.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // HoraApertura
            // 
            this.HoraApertura.DataPropertyName = "HoraApertura";
            this.HoraApertura.HeaderText = "Hora Apertura";
            this.HoraApertura.Name = "HoraApertura";
            this.HoraApertura.ReadOnly = true;
            // 
            // HoraCierre
            // 
            this.HoraCierre.DataPropertyName = "HoraCierre";
            this.HoraCierre.HeaderText = "Hora Cierre";
            this.HoraCierre.Name = "HoraCierre";
            this.HoraCierre.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 28);
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
            this.pnlFechaHoraReserva.Location = new System.Drawing.Point(220, 12);
            this.pnlFechaHoraReserva.Name = "pnlFechaHoraReserva";
            this.pnlFechaHoraReserva.Size = new System.Drawing.Size(53, 40);
            this.pnlFechaHoraReserva.TabIndex = 6;
            this.pnlFechaHoraReserva.Visible = false;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(349, 149);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(153, 35);
            this.dtpHoraReserva.TabIndex = 9;
            // 
            // btnSigSelFechaYHora
            // 
            this.btnSigSelFechaYHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSigSelFechaYHora.Location = new System.Drawing.Point(261, 206);
            this.btnSigSelFechaYHora.Name = "btnSigSelFechaYHora";
            this.btnSigSelFechaYHora.Size = new System.Drawing.Size(157, 39);
            this.btnSigSelFechaYHora.TabIndex = 8;
            this.btnSigSelFechaYHora.Text = "Siguiente";
            this.btnSigSelFechaYHora.UseVisualStyleBackColor = true;
            this.btnSigSelFechaYHora.Click += new System.EventHandler(this.seleccionarFechaYHora);
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(180, 149);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(153, 35);
            this.dtpFechaReserva.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(180, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingrese fecha y hora de la reserva";
            // 
            // pnlSelGuias
            // 
            this.pnlSelGuias.Controls.Add(this.btnSigSelGuia);
            this.pnlSelGuias.Controls.Add(this.label8);
            this.pnlSelGuias.Controls.Add(this.dgGuias);
            this.pnlSelGuias.Location = new System.Drawing.Point(351, 14);
            this.pnlSelGuias.Name = "pnlSelGuias";
            this.pnlSelGuias.Size = new System.Drawing.Size(29, 27);
            this.pnlSelGuias.TabIndex = 7;
            this.pnlSelGuias.Visible = false;
            // 
            // btnSigSelGuia
            // 
            this.btnSigSelGuia.Location = new System.Drawing.Point(524, 371);
            this.btnSigSelGuia.Name = "btnSigSelGuia";
            this.btnSigSelGuia.Size = new System.Drawing.Size(119, 36);
            this.btnSigSelGuia.TabIndex = 6;
            this.btnSigSelGuia.Text = "Siguiente";
            this.btnSigSelGuia.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(61, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 28);
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
            this.dgGuias.Location = new System.Drawing.Point(61, 120);
            this.dgGuias.Name = "dgGuias";
            this.dgGuias.RowTemplate.Height = 25;
            this.dgGuias.Size = new System.Drawing.Size(545, 169);
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
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.pnlSelGuias);
            this.Controls.Add(this.pnlFechaHoraReserva);
            this.Controls.Add(this.pnlExposiciones);
            this.Controls.Add(this.pnlCantidadVisitantes);
            this.Controls.Add(this.pnlTipoVisita);
            this.Controls.Add(this.pnlSelSedes);
            this.Controls.Add(this.panelSelEscuela);
            this.Name = "PantallaRegistrarReserva";
            this.Text = "PantallaRegistrarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgEscuelas)).EndInit();
            this.panelSelEscuela.ResumeLayout(false);
            this.panelSelEscuela.PerformLayout();
            this.pnlCantidadVisitantes.ResumeLayout(false);
            this.pnlCantidadVisitantes.PerformLayout();
            this.pnlTipoVisita.ResumeLayout(false);
            this.pnlTipoVisita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoVisita)).EndInit();
            this.pnlSelSedes.ResumeLayout(false);
            this.pnlSelSedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSedes)).EndInit();
            this.pnlExposiciones.ResumeLayout(false);
            this.pnlExposiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExposiciones)).EndInit();
            this.pnlFechaHoraReserva.ResumeLayout(false);
            this.pnlFechaHoraReserva.PerformLayout();
            this.pnlSelGuias.ResumeLayout(false);
            this.pnlSelGuias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEscuelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefFijo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSelEscuela;
        private System.Windows.Forms.Panel pnlCantidadVisitantes;
        private System.Windows.Forms.Button btnSiguienteCantVisitantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantVisitantes;
        private System.Windows.Forms.Panel pnlSelSedes;
        private System.Windows.Forms.DataGridView dgSedes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTipoVisita;
        private System.Windows.Forms.Button btnSigTipoVisita;
        private System.Windows.Forms.DataGridView dgTipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlExposiciones;
        private System.Windows.Forms.DataGridView dgExposiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCierre;
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
    }
}