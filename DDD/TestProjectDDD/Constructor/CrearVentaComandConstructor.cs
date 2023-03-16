using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Venta.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDDD.Constructor
{
    public class CrearVentaComandConstructor
    {
        private string Nombre;


        public CrearVentaComandConstructor WithName(string nombre)
        {
            Nombre = nombre;
            return this;
        }

        public CrearVentaComand Build()
        {
            return new CrearVentaComand(Nombre);
        }
    }

}
