using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SinMiedos
{
    public class DAODoctor
    {
        Conexion conexion;
        String datos;
        String query;
        MySqlDataReader reader;
        MySqlCommand commandDatabase;

        public DAODoctor()
        {
            conexion = Conexion.GetConexion();
        }

        public List<Doctor> DatosDoctores()
        {
            var items = new List<Doctor>();

            query = "SELECT *  FROM persona INNER JOIN medico ON persona.id = medico.id_Persona WHERE medico.Estatus = 1";
            if (conexion.Conectar())
            {
                commandDatabase = new MySqlCommand(query, conexion.conexion);
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader.GetString(9));
                        char sexo = char.Parse(reader.GetString(8));
                        items.Add(new Doctor(id, reader.GetString(1), reader.GetString(2), reader.GetString(3), sexo, reader.GetString(11)));

                    }
                    Console.WriteLine(datos);
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");

                }
            }
            return items;

        }

        public Boolean AgregarDoctor(string nombre, string paterno, string materno, int edad, string telefono, string direccion, string email, char sexo, string cedula, string usuario, string password)
        {
            query = "INSERT INTO persona (`Nombre`, `Paterno`, `Materno`, `Edad`, `Telefono`, `Direccion`, `email`, `Sexo`) " +
                    "VALUES ('" + nombre + "','" + paterno + "','" + materno + "'," + edad + ",'" + telefono + "','" + direccion + "','" + email + "','" + sexo + "');" +
                    "INSERT INTO `medico`(`id_Persona`, `Cedula`)" +
                    "VALUES ((SELECT MAX(id)from persona),'"+cedula+ "'); " +
                    "INSERT INTO usuarios(`Usuario`, `Contrasenia`, `TipoUsuario`,`id_Licencia`,`id_Persona`)" +
                    "VALUES ('"+ usuario + "','"+ password+ "','doctor', 1 ,(SELECT MAX(id)from persona));";

            try{
                if (conexion.Conectar())
                {
                    commandDatabase = new MySqlCommand(query, conexion.conexion);
                    reader = commandDatabase.ExecuteReader();

                    Console.WriteLine(reader);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean ElimnarDoctor(int DoctorId)
        {
            try
            {
                query = "UPDATE medico SET Estatus = 0 WHERE id_Medico = " + DoctorId + ";";
                if (conexion.Conectar())
                {
                    commandDatabase = new MySqlCommand(query, conexion.conexion);
                    reader = commandDatabase.ExecuteReader();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean EditarDoctor(int idPersona, string nombre, string paterno, string materno, string telefono, string direccion, string email, char sexo, int edad, string cedula,string usuario, string contrasenia)
        {
            try
            {
                query = "UPDATE persona SET " +
                        "`Nombre`='" + nombre + "'," +
                        "`Paterno`='" + paterno + "'," +
                        "`Materno`='" + materno + "'," +
                        "`Edad`=" + edad + "," +
                        "`Telefono`='" + telefono + "'," +
                        "`Direccion`='" + direccion + "'," +
                        "`email`='" + email + "'," +
                        "`Sexo`='" + sexo + "'" +
                        "WHERE id =" + idPersona + ";" +
                        "UPDATE medico SET "+
                        "`Cedula`= '" + cedula + "'" +
                        "WHERE id_Persona =" + idPersona + ";" +
                        "UPDATE usuarios SET Usuario = '" + usuario +"', Contrasenia ='" + contrasenia + "' WHERE id_Persona = " + idPersona + ";";
               
                if (conexion.Conectar())
                {
                    commandDatabase = new MySqlCommand(query, conexion.conexion);
                    reader = commandDatabase.ExecuteReader();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
               
        public List<Doctor> EditarA(int DoctorId)
        {
            var items = new List<Doctor>();

            string query = "SELECT *  FROM persona INNER JOIN medico ON persona.id = medico.id_Persona INNER JOIN usuarios on medico.id_Persona = usuarios.id_Persona WHERE medico.Estatus = 1 and medico.id_Medico =" + DoctorId;
            if (conexion.Conectar())
            {
                commandDatabase = new MySqlCommand(query, conexion.conexion);
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader.GetString(10));
                        char sexo = char.Parse(reader.GetString(8));
                        int edad = int.Parse(reader.GetString(4));
                        items.Add(new Doctor(id,reader.GetString(1), reader.GetString(2), reader.GetString(3),edad, reader.GetString(5), reader.GetString(6), reader.GetString(7),sexo,reader.GetString(11), reader.GetString(14), reader.GetString(15)));
                    }
                    Console.WriteLine(datos);
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");

                }
            }
            return items;
        }
    }
}
