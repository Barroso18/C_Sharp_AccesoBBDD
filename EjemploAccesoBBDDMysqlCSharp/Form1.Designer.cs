namespace EjemploAccesoBBDDMysqlCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaUsuario = new System.Windows.Forms.TextBox();
            this.cajaPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonLogin
            // 
            this.botonLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.Location = new System.Drawing.Point(218, 283);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(206, 23);
            this.botonLogin.TabIndex = 0;
            this.botonLogin.Text = "Entrar";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // cajaUsuario
            // 
            this.cajaUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaUsuario.Location = new System.Drawing.Point(218, 85);
            this.cajaUsuario.Name = "cajaUsuario";
            this.cajaUsuario.Size = new System.Drawing.Size(206, 23);
            this.cajaUsuario.TabIndex = 2;
            // 
            // cajaPass
            // 
            this.cajaPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaPass.Location = new System.Drawing.Point(218, 184);
            this.cajaPass.Name = "cajaPass";
            this.cajaPass.Size = new System.Drawing.Size(206, 23);
            this.cajaPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "entrar sin contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cajaPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajaUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaUsuario;
        private System.Windows.Forms.TextBox cajaPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

