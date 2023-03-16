using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Comandos
{
    public class CrearClienteComand
    {

        public string Nombre { get; init; }
        public string Correo { get; init; }

        public CrearClienteComand(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
        }     

        
        

    }
}
