using Cliente.Domain.Encargado.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDDD.Constructor
{
    internal class CrearEncargadoComandConstructor
    {
        private string Nombre;
        private string Sexo;
        private int Edad;

        public CrearEncargadoComandConstructor WithName(string nombre)
        {
            Nombre = nombre;
            return this;
        }

        public CrearEncargadoComandConstructor WithSex(string sexo)
        {
            Sexo = sexo;
            return this;
        }

        public CrearEncargadoComandConstructor WithAge(int edad)
        {
            Edad = edad;
            return this;
        }

        public CrearEncargadoComand Build()
        {
            return new CrearEncargadoComand(Nombre, Sexo, Edad);
        }

     
    }
}
