using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public record DescripcionDelProducto
    {
        public string DescripcionCompra { get; init; }
        public DateTime FechaDePagoCompra { get; init; }
        public decimal TotalCompra { get; init; }        


        internal DescripcionDelProducto(string descripcionCompra, DateTime fechaDePagoCompra, decimal totalCompra)
        {
            DescripcionCompra = descripcionCompra;
            TotalCompra = totalCompra;
            FechaDePagoCompra = fechaDePagoCompra;
        }

        public static DescripcionDelProducto Crear(string descripcionCompra, DateTime fechaDePagoCompra, decimal totalCompra)
        {
            Validar(descripcionCompra, fechaDePagoCompra, totalCompra);
            return new DescripcionDelProducto(descripcionCompra, fechaDePagoCompra, totalCompra);
        }
        public static void Validar(string descripcionCompra, DateTime fechaDePagoCompra, decimal totalCompra)
        {
            if (descripcionCompra == null)
            {
                throw new ArgumentNullException("El campo no puede ser nulo");
            }
            if (fechaDePagoCompra == null)
            {
                throw new ArgumentNullException("El campo no puede estar vacio");
            }
            if (totalCompra == null)
            {
                throw new ArgumentNullException("El campo no puede estar vacio");
            }

        }
    }
}
