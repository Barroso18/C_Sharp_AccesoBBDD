﻿namespace EjemploAccesoBBDDMysqlCSharp
{
    partial class VentanaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.desplegableTitulos = new System.Windows.Forms.ComboBox();
            this.desplegableDNIs = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTANA PRINCIPAL";
            // 
            // desplegableTitulos
            // 
            this.desplegableTitulos.FormattingEnabled = true;
            this.desplegableTitulos.Location = new System.Drawing.Point(12, 100);
            this.desplegableTitulos.Name = "desplegableTitulos";
            this.desplegableTitulos.Size = new System.Drawing.Size(259, 21);
            this.desplegableTitulos.TabIndex = 1;
            // 
            // desplegableDNIs
            // 
            this.desplegableDNIs.FormattingEnabled = true;
            this.desplegableDNIs.Location = new System.Drawing.Point(13, 174);
            this.desplegableDNIs.Name = "desplegableDNIs";
            this.desplegableDNIs.Size = new System.Drawing.Size(258, 21);
            this.desplegableDNIs.TabIndex = 2;
            this.desplegableDNIs.SelectedIndexChanged += new System.EventHandler(this.desplegableDNIs_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 179);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.desplegableDNIs);
            this.Controls.Add(this.desplegableTitulos);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox desplegableTitulos;
        private System.Windows.Forms.ComboBox desplegableDNIs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}