using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Encargado.Entidades;
using Cliente.Domain.Venta.Comandos;
using Cliente.Domain.Venta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.CasoDeUso.PuertaEnlace
{
    public interface ICasodeUsoVenta
    {
        Task<Venta> CrearVenta(CrearVentaComand crearVentaComand);
        Task<Venta> AnadirProducto(AnadirProductoComand anadirProductoComand);

        Task<Venta> AnadirPago(AnadirDescripcionComand anadirDescripcionComand);
        Task<Venta> AnadirCliente(AnadirClienteComand anadirClienteComand);
        Task<Venta> AnadirEncargado(AnadirEncargadoComand anadirEncargadoComand);
    }
}
