using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClimateReports
{
    class ConexionBD
    {

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection( "Data Source=DESKTOP-URL35RD;Initial Catalog=UEM    ; Integrated Security=True;");
            return conectar;
        }

    }
}
