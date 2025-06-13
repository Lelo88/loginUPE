using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface InterfaceUsuario
    {
        DataTable IniciarSesion(string usuario, string password);
    }
}
