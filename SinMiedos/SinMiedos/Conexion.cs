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
        String host = "";
        String baseDatos = "";
        String usuario = "";
        String contraseña = "";

        public static MySqlConnection conexion()
        {
            MySqlConnection databaseConnection = new MySqlConnection("server=127.0.0.1;database=prueba;Uid=root;pwd=;");
            databaseConnection.Open();
            return databaseConnection;
        }
    }
}
