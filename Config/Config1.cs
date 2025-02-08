using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinal.Config
{
    public class conexion
    {
        public readonly string cadenaConexion =
            "Server=(local);database=Gestion_EqDeportivos;uid=sa;pwd=123";

        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
