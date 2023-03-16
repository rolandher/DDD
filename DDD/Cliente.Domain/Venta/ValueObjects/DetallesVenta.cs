using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class DetallesVenta
    {
        public string Nombre { get; init; }

        public DetallesVenta(string nombre)
        {
            Nombre = nombre;
        }

        public static DetallesVenta Crear(string nombre)
        {
            Validar(nombre);
            return new DetallesVenta(nombre);
        }
        public static void Validar(string nombre)
        {
            if (nombre == null)
            {
                throw new ArgumentNullException("Diligenciar el detalle de la venta es obligatorio");
            }

        }
    }
}
