﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinMiedos
{
    public class Paciente
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
        public bool Estatus { get; set; }

        public Paciente(int id,String nombre, String paterno, String materno,char sexo)
        {
            this.Id = id; 
            this.Nombre = nombre;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Sexo = sexo;

        }
        public Paciente(int id, String nombre, String paterno, String materno,int edad, String telefono, String direccion, String email, char sexo)
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

        }

    }
}
