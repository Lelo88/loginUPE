using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // añado una interface para poder desacoplar y realizar tests unitarios
    public interface InterfaceConexion
    {
        DataTable LeerPorComando(string query, SqlParameter[] parametros);

    }
}
