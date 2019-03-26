using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SinMiedos
{
    public class DAOPaciente
    {
        Conexion conexion;
        String datos;
        MySqlDataReader reader;
        MySqlCommand commandDatabase;

        public DAOPaciente()
        {
            conexion = Conexion.GetConexion();
        }

        public List<Paciente> DatosPaciente()
        {
            var items = new List<Paciente>();
            string query = "SELECT *  FROM persona INNER JOIN paciente ON persona.id = paciente.id_Persona WHERE paciente.Estatus = 1";
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
                        items.Add(new Paciente( id, reader.GetString(1), reader.GetString(2), reader.GetString(3),sexo));

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

        public Boolean EliminarPaciente(int pacienteId)
        {
            string query ="UPDATE paciente SET Estatus=0 WHERE id = " + pacienteId + ";";
            if (conexion.Conectar())
            {
                commandDatabase = new MySqlCommand(query, conexion.conexion);
                reader = commandDatabase.ExecuteReader();
            }
            return true ;
        }

        public void AgregarPaciente(string nombre, string paterno, string materno, int edad, string telefono, string direccion, string email, char sexo)
        {
            string query = "INSERT INTO persona (`Nombre`, `Paterno`, `Materno`, `Edad`, `Telefono`, `Direccion`, `email`, `Sexo`) " +
                                     "VALUES ('"+ nombre +"','"+paterno+"','"+materno+"',"+edad+",'"+telefono+"','"+direccion+"','"+email+"','"+sexo+ "'); INSERT INTO paciente ( `id_Persona`) VALUES ((SELECT MAX(id) FROM persona))";
            try
            {
                if (conexion.Conectar())
                {
                    commandDatabase = new MySqlCommand(query, conexion.conexion);
                    reader = commandDatabase.ExecuteReader();

                    Console.WriteLine(reader);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        internal List<Paciente> EditarPaciente(int pacienteId)
        {
            var items = new List<Paciente>();

            string query = "SELECT *  FROM persona INNER JOIN paciente ON persona.id = paciente.id_Persona WHERE paciente.id =" + pacienteId;
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
                        items.Add(new Paciente(id, reader.GetString(1), reader.GetString(2), reader.GetString(3),edad ,reader.GetString(5), reader.GetString(6), reader.GetString(7), sexo));

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

        public Boolean Editar(int idPersona, string nombre, string paterno, string materno, string telefono, string direccion, string email, char sexo, int edad)
        {
            String query = "UPDATE persona SET " +
                            "`Nombre`='"+nombre+"'," +
                            "`Paterno`='"+paterno+"'," +
                            "`Materno`='"+materno+"'," +
                            "`Edad`="+edad+"," +
                            "`Telefono`='"+telefono+"'," +
                            "`Direccion`='"+direccion+"'," +
                            "`email`='"+email+"'," +
                            "`Sexo`='"+sexo+"'" +
                            "WHERE id =" + idPersona + ";";
            try
            {
                if (conexion.Conectar())
                {
                    commandDatabase = new MySqlCommand(query, conexion.conexion);
                    reader = commandDatabase.ExecuteReader();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                Console.WriteLine(ex.Message);
            }

        }

    }
}
