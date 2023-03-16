using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Comandos
{
    public class CrearEncargadoComand
    {
        public CrearEncargadoComand(string nombre, string sexo, int edad)
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
        }

        public string Nombre { get; init; }
        public string Sexo { get; init; }
        public int Edad { get; init; }
       
    }
}
