using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Repositorio
{
    public interface IVentaRepository
    {
        Task<Entidades.Venta> CrearVenta(Entidades.Venta venta);

        Task AnadirProducto(Guid productoId, ValorProducto valorProducto);

        Task DescripcionProducto(Guid productoId, DescripcionDelProducto descripcionDelProducto);

        Task EliminarProducto(Guid productoId);

    }
}
