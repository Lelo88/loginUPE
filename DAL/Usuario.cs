using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario
    {

        public DataTable IniciarSesion(string usuario, string password)
        {
            Conexion objConexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@Usuario", usuario),
        new SqlParameter("@Password", password)
            };

            DataTable dt = objConexion.LeerPorComando(
                "SELECT usuario, clave FROM Universidad.dbo.Usuario WHERE usuario = @Usuario AND clave = @Password",
                parametros
            );

            return dt;
        }

    }
}
