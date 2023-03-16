using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.Eventos;
using Cliente.Domain.Encargado.ValueObjects;
using Cliente.Domain.Venta.Eventos;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Entidades
{
    public class VentaCambiada
    {
        public Venta CrearAgregado(List<EventoDominio> ev, VentaId ventaId)
        {
            Venta venta = new(ventaId);
            ev.ForEach(evento =>
            {
                switch (evento)
                {
                    case DetalleVentaAnadido detalleVentaAnadido:
                        venta.SetDetallesVenta(detalleVentaAnadido.DetallesVenta);
                        break;
                    //producto
                    case ProductoAnadido productoAnadido:
                        venta.SetProductoAnadido(productoAnadido.ValorProducto);
                        break;                   
                    //TIpo
                    case DescripcionAnadida descripcionAnadida:
                        venta.SetDescripcionAnadida(descripcionAnadida.DescripcionDelProducto);
                        break;
                    case ClienteAnadido clienteAnadido:
                       venta.SetClienteAnadido(clienteAnadido.ClienteId);
                        break;
                    case EncargadoAnadido encargadoAnadido:
                       venta.SetEncargadoAnadido(encargadoAnadido.EncargadoId);
                       break;
                }

            });
            return venta;
        }
    }
}
