﻿namespace PagoElectronico.WidgetsGUI
{
    partial class Texto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTexto
            // 
            this.textBoxTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTexto.Location = new System.Drawing.Point(0, 0);
            this.textBoxTexto.Name = "textBoxTexto";
            this.textBoxTexto.Size = new System.Drawing.Size(100, 20);
            this.textBoxTexto.TabIndex = 0;
            // 
            // Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTexto);
            this.Name = "Texto";
            this.Size = new System.Drawing.Size(100, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox textBoxTexto;


    }
}
