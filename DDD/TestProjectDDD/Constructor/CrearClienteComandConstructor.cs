using Cliente.Domain.Cliente.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDDD.Constructor
{
    public class CrearClienteComandConstructor
    {
        private string _nombre;
        private string _correo;       

        public CrearClienteComandConstructor WithName(string nombre)
        {
            _nombre = nombre;
            return this;
        }

        public CrearClienteComandConstructor WithEmail(string correo)
        {
            _correo = correo;
            return this;
        }

        public CrearClienteComand Build()
        {
            return new CrearClienteComand(_nombre, _correo);
        }



    }
}
