using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
		private string _userName;

		public string Username
		{
			get { return _userName; }
			set { _userName = value; }
		}

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

		private string _email;

		public string MyProperty
		{
			get { return _email; }
			set { _email = value; }
		}

		private int _DNI;

		public int DNI
		{
			get { return _DNI; }
			set { _DNI = value; }
		}

		public bool Loguearse(string usuario, string password) {
			DAL.Usuario unLogin = new DAL.Usuario();

            DataTable dt = unLogin.IniciarSesion();

            foreach (DataRow fila in dt.Rows)
			{
				if (fila["usuario"].ToString() == usuario && fila["clave"].ToString() == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
	}
}
