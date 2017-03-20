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
            SqlConnection conectar = new SqlConnection( "Data Source=DESKTOP-H5IIM79;Initial Catalog=ClimateReport; Integrated Security=True;");
            return conectar;
        }

    }
}
