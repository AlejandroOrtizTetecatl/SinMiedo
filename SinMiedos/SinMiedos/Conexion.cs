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
        private static Conexion instancia;

        String HostName = "127.0.0.1";
        String Port = "3306";
        String Password = "";
        String User = "root";
        String DataName = "SinMiedo";
        public MySqlConnection conexion;

        private Conexion()
        {


        }
        
        public static Conexion GetConexion()
        {
            if(instancia == null){

                instancia = new Conexion();
           
            }
            return instancia;
        }

        public Boolean Conectar()
        {
            try
            {
                string connectionString = "server=" + HostName + ";port=" + Port + ";userid=" + User + ";password=;database=" + DataName + ";";
                conexion = new MySqlConnection(connectionString);
                conexion.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public Boolean Desconectar()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }



    }
}
