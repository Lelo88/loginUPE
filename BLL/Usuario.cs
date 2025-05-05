using System;
using System.Collections.Generic;
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


	}
}
