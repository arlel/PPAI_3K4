
namespace PPAI_3K4
{
    partial class FormularioInicio
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
            this.btnRegistrarReservaVisitasGuiadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarReservaVisitasGuiadas
            // 
            this.btnRegistrarReservaVisitasGuiadas.Location = new System.Drawing.Point(227, 82);
            this.btnRegistrarReservaVisitasGuiadas.Name = "btnRegistrarReservaVisitasGuiadas";
            this.btnRegistrarReservaVisitasGuiadas.Size = new System.Drawing.Size(272, 185);
            this.btnRegistrarReservaVisitasGuiadas.TabIndex = 0;
            this.btnRegistrarReservaVisitasGuiadas.Text = "Registrar Reserva de Visitas Guiadas";
            this.btnRegistrarReservaVisitasGuiadas.UseVisualStyleBackColor = true;
            this.btnRegistrarReservaVisitasGuiadas.Click += new System.EventHandler(this.btnRegistrarReservaVisitasGuiadas_Click);
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrarReservaVisitasGuiadas);
            this.Name = "FormularioInicio";
            this.Text = "FormularioInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarReservaVisitasGuiadas;
    }
}