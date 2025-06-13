using System;
using System.Windows.Forms;
using DAL;  // Acordate de agregar las referencias necesarias
using BLL;

namespace LoginPrueba
{
    public partial class Form1 : Form
    {
        private readonly BLL.Usuario _usuarioLoginBLL;

        public Form1()
        {
            InitializeComponent();

            // Aquí inyectamos las dependencias reales
            InterfaceUsuario usuarioDal = new DAL.Usuario();
            _usuarioLoginBLL = new BLL.Usuario(usuarioDal);
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

            if (_usuarioLoginBLL.Loguearse(usuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                // Acá podrías abrir el formulario principal o hacer lo que necesites
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
