using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClimateReports
{
    class ConexionBD
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Uid = root; Password = metroid123; Database = climate; port = 3306");
            return conectar;
        }

    }
}
