﻿
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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarReservaVisitasGuiadas
            // 
            this.btnRegistrarReservaVisitasGuiadas.Location = new System.Drawing.Point(96, 88);
            this.btnRegistrarReservaVisitasGuiadas.Name = "btnRegistrarReservaVisitasGuiadas";
            this.btnRegistrarReservaVisitasGuiadas.Size = new System.Drawing.Size(147, 86);
            this.btnRegistrarReservaVisitasGuiadas.TabIndex = 0;
            this.btnRegistrarReservaVisitasGuiadas.Text = "Registrar Reserva de Visitas Guiadas";
            this.btnRegistrarReservaVisitasGuiadas.UseVisualStyleBackColor = true;
            this.btnRegistrarReservaVisitasGuiadas.Click += new System.EventHandler(this.iniciarCuRegistrarReservaDeVisitaGuiada);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bienvenido Cristian Alvarez";
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 233);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegistrarReservaVisitasGuiadas);
            this.Name = "FormularioInicio";
            this.Text = "FormularioInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarReservaVisitasGuiadas;
        private System.Windows.Forms.Label label5;
    }
}