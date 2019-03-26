using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SinMiedos
{
   public class DAOUsuario
    {
        Conexion conexion;
        String datos = "";
        
        public DAOUsuario(){
            this.conexion = Conexion.GetConexion();
        }

        public Boolean validarDatos(String nombre, String password){
            
            string query = "SELECT * FROM `administrador` WHERE Usuario ='"+ nombre + "' and Contrasenia ='" + password+"';" ;
            MySqlDataReader reader;

            if (conexion.Conectar())
            {
                MySqlCommand commandDatabase = new MySqlCommand(query,conexion.conexion);
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        datos += reader.GetString(0);
                    }
                    Console.WriteLine(datos);
                    return  true;
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
