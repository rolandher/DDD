using Cliente.Domain.Cliente.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class ValorProducto
    {
        public string Nombre { get; init; }
        public int Precio { get; init; }

        public ValorProducto(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public static ValorProducto Crear(string nombre, int precio)
        {
            Validar(nombre, precio);
            return new ValorProducto(nombre, precio);
        }
        public static void Validar(string nombre, decimal precio)
        {
            if (nombre == null)
            {
                throw new ArgumentNullException("El campo no puede ser nulo");
            }
            if (precio == null)
            {
                throw new ArgumentNullException("El valor no puede estar vacio");
            }

        }

    }
}
