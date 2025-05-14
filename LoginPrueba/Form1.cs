using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtener los valores de usuario y contraseña de los TextBox
            string usuario = textBoxUsuario.Text;
            string contrasena = textContrasena.Text;

            // Instancia de la clase Usuario
            BLL.Usuario usuarioLoginBLL = new BLL.Usuario();

            if (usuarioLoginBLL.Loguearse(usuario, contrasena))
            {
                // Si el inicio de sesión es exitoso, abrir el formulario principal
                MessageBox.Show("Inicio de sesión exitoso.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
