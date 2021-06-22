
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
            this.pnlSelSedes = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgSedes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlCantidadVisitantes = new System.Windows.Forms.Panel();
            this.btnSiguienteCantVisitantes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantVisitantes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscuelas)).BeginInit();
            this.panelSelEscuela.SuspendLayout();
            this.pnlSelSedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSedes)).BeginInit();
            this.pnlCantidadVisitantes.SuspendLayout();
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
            this.dgEscuelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarEscuela);
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
            this.button1.Click += new System.EventHandler(this.tomarSeleccionEscuela);
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
            this.panelSelEscuela.Location = new System.Drawing.Point(6, 12);
            this.panelSelEscuela.Name = "panelSelEscuela";
            this.panelSelEscuela.Size = new System.Drawing.Size(683, 406);
            this.panelSelEscuela.TabIndex = 3;
            // 
            // pnlSelSedes
            // 
            this.pnlSelSedes.Controls.Add(this.label4);
            this.pnlSelSedes.Controls.Add(this.dgSedes);
            this.pnlSelSedes.Controls.Add(this.button3);
            this.pnlSelSedes.Location = new System.Drawing.Point(141, 424);
            this.pnlSelSedes.Name = "pnlSelSedes";
            this.pnlSelSedes.Size = new System.Drawing.Size(60, 56);
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
            // 
            // pnlCantidadVisitantes
            // 
            this.pnlCantidadVisitantes.Controls.Add(this.btnSiguienteCantVisitantes);
            this.pnlCantidadVisitantes.Controls.Add(this.label2);
            this.pnlCantidadVisitantes.Controls.Add(this.txtCantVisitantes);
            this.pnlCantidadVisitantes.Location = new System.Drawing.Point(34, 424);
            this.pnlCantidadVisitantes.Name = "pnlCantidadVisitantes";
            this.pnlCantidadVisitantes.Size = new System.Drawing.Size(78, 72);
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
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.pnlSelSedes);
            this.Controls.Add(this.pnlCantidadVisitantes);
            this.Controls.Add(this.panelSelEscuela);
            this.Name = "PantallaRegistrarReserva";
            this.Text = "PantallaRegistrarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgEscuelas)).EndInit();
            this.panelSelEscuela.ResumeLayout(false);
            this.panelSelEscuela.PerformLayout();
            this.pnlSelSedes.ResumeLayout(false);
            this.pnlSelSedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSedes)).EndInit();
            this.pnlCantidadVisitantes.ResumeLayout(false);
            this.pnlCantidadVisitantes.PerformLayout();
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
    }
}