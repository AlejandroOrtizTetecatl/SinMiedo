using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinMiedos
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public String Paterno { get; set; }
        public String Materno { get; set; }
        public bool Estatus { get; set; }

        public Paciente(int id,String nombre, String paterno, String materno, bool estatus)
        {
            this.Id = id; 
            this.Nombre = nombre;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Estatus = estatus;


        }

    }
}
