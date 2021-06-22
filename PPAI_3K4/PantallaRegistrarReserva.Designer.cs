
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
            ((System.ComponentModel.ISupportInitialize)(this.dgEscuelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEscuelas
            // 
            this.dgEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEscuelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgEscuelas.Location = new System.Drawing.Point(72, 57);
            this.dgEscuelas.Name = "dgEscuelas";
            this.dgEscuelas.RowTemplate.Height = 25;
            this.dgEscuelas.Size = new System.Drawing.Size(588, 317);
            this.dgEscuelas.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgEscuelas);
            this.Name = "PantallaRegistrarReserva";
            this.Text = "PantallaRegistrarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgEscuelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEscuelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}