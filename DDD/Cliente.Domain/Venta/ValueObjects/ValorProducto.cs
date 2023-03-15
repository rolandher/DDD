using Cliente.Domain.Cliente.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public record ValorProducto
    {
        public string nombre { get; init; }
        public decimal precio { get; init; }

        internal ValorProducto(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public static ValorProducto Crear(string nombre, decimal precio)
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
