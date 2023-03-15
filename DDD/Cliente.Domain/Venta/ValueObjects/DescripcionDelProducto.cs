using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class DescripcionDelProducto
    {
       public string DescripcionCompra { get; init; }
       public int TotalCompra { get; init; }        


        public DescripcionDelProducto(string descripcionCompra, int totalCompra)
        {
            DescripcionCompra = descripcionCompra;
            TotalCompra = totalCompra;
            
        }

        public static DescripcionDelProducto Crear(string descripcionCompra, int totalCompra)
        {
            Validar(descripcionCompra, totalCompra);
            return new DescripcionDelProducto(descripcionCompra, totalCompra);
        }
        public static void Validar(string descripcionCompra, int totalCompra)
        {
            if (descripcionCompra == null)
            {
                throw new ArgumentNullException("El campo no puede ser nulo");
            }           
            if (totalCompra == null)
            {
                throw new ArgumentNullException("El campo no puede estar vacio");
            }

        }
    }
}
