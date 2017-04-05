using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using Msql.Data.MysqlClient sirve para importar las librerias para estableces la conexion a mysql
using MySql.Data.MySqlClient;

namespace ClimateReports
{
    class ConexionBD
    {

        public static MySqlConnection ObtenerConexion()
        {
            
      
           ///Declaracion de la conexion hacia la base de datos utilizando la informacion de la base de datos
           ///incluyendo su nombre, el servidor en el que esta alojada, usuario y contraseña para poder acceder
            MySqlConnection Conectar = new MySqlConnection("Server = localhost ; database = mydb ; Userid = root; password = metroid123");
            return Conectar;
        }
    }

    }