namespace LoginPrueba
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LblUSuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(768, 429);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 44);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(442, 429);
            this.BtnIniciarSesion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(150, 44);
            this.BtnIniciarSesion.TabIndex = 1;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // LblUSuario
            // 
            this.LblUSuario.AutoSize = true;
            this.LblUSuario.Location = new System.Drawing.Point(436, 183);
            this.LblUSuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblUSuario.Name = "LblUSuario";
            this.LblUSuario.Size = new System.Drawing.Size(86, 25);
            this.LblUSuario.TabIndex = 2;
            this.LblUSuario.Text = "Usuario";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Location = new System.Drawing.Point(436, 296);
            this.LblContrasena.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(123, 25);
            this.LblContrasena.TabIndex = 3;
            this.LblContrasena.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(644, 183);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(330, 31);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(644, 283);
            this.textContrasena.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.PasswordChar = '*';
            this.textContrasena.Size = new System.Drawing.Size(330, 31);
            this.textContrasena.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 863);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUSuario);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.BtnCancelar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Label LblUSuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textContrasena;
    }
}

