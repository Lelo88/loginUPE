using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario
    {
        
        public DataTable IniciarSesion()
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("SELECT usuario, clave FROM [Universidad].[dbo].[Usuario] WHERE Usuario = @Usuario AND Password = @Password");

            return dt;
        }
    }
}
