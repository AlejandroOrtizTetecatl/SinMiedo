using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SinMiedos
{
    public class Conexion
    {
      public static MySqlConnection conexion()
        {

            String host = "localhost";
            String baseDatos = "prueba";
            String usuario = "root";
            String contrasenia = "";


            //MySqlConnection databaseConnection = new MySqlConnection("server=127.0.0.1;database=prueba;Uid=root;pwd=;");
            MySqlConnection databaseConnection = new MySqlConnection(String.Format("server={0};user id={1}; password={2}; database={3}", host,usuario, contrasenia, baseDatos));
            databaseConnection.Open();
            return databaseConnection;
        }
    }
}
