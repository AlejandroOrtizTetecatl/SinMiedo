using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinMiedos
{
    public class Doctor
    {

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Paterno { get; set; }
        public String Materno { get; set; }
        public String Curp { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }
        public String Cedula { get; set; }
        public String Contrasenia { get; set; }
        public String Usuario { get; set; }
        public Doctor(int id, String nombre, String paterno, String materno, char sexo,String cedula)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Sexo = sexo;
            this.Cedula=cedula;
        }
        public Doctor(int id, String nombre, String paterno, String materno, int edad, String telefono, String direccion, String email, char sexo, String cedula, String usuario, String contrasenia)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Edad = edad;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Email = email;
            this.Sexo = sexo;
            this.Cedula = cedula;
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }

    }
}