using DAL;
using System.Data;

namespace BLL
{
    public class Usuario
    {
        private readonly InterfaceUsuario _usuarioDal;

        public Usuario(InterfaceUsuario usuarioDal)
        {
            _usuarioDal = usuarioDal;
        }

        public bool Loguearse(string usuario, string password)
        {
            DataTable dt = _usuarioDal.IniciarSesion(usuario, password);

            foreach (DataRow fila in dt.Rows)
            {
                if (fila["usuario"].ToString() == usuario && fila["clave"].ToString() == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
