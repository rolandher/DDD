using Cliente.Domain.Cliente.Eventos;
using Cliente.Domain.Cliente.ValueObjects;
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
    public class Venta : AgregarEvento<VentaId>
    {
        public VentaId VentaId { get; init; }

        public IdAgregadosClienteEncargado IdAgregadosClienteEncargado {get; private set; }

        public DetallesVenta DetallesVenta { get; private set; }

       
        public virtual DescripcionDelProducto DescripcionDelProducto { get; private set; }

        public virtual ValorProducto ValorProducto { get; private set; }

        


        public Venta(VentaId ventaId) : base(ventaId)
        {
            this.VentaId = ventaId;
        }

        public void SetVentaId(VentaId ventaId)
        {
            AgregarCambios(new VentaCreada(ventaId.ToString()));
        }
        public void SetDetallesVentaAnadido(DetallesVenta detallesVenta)
        {
            AgregarCambios(new DetalleVentaAnadido(detallesVenta));
        }
        

        public void SetAnadirProducto(ValorProducto valorProducto)
        {
            AgregarCambios(new ProductoAnadido(valorProducto));
        }
        public void SetAnadirDescripcion(DescripcionDelProducto descripcionDelProducto)
        {
            AgregarCambios(new DescripcionAnadida(descripcionDelProducto));
        }

        
        public void SetCliente(ClienteId clienteId)
        {
            AgregarCambios(new ClienteAnadido(clienteId));
        }
        
        public void SetEncargado(EncargadoId encargadoId)
        {
            AgregarCambios(new EncargadoAnadido(encargadoId));
        }

        public void SetDetallesVenta(DetallesVenta detallesVenta)
        {
            this.DetallesVenta = detallesVenta;
        }

        public void SetProductoAnadido(ValorProducto valorProducto)
        {
            this.ValorProducto = valorProducto;
        }
        public void SetDescripcionAnadida(DescripcionDelProducto descripcionDelProducto)
        {
            this.DescripcionDelProducto = descripcionDelProducto;
        }
       


    }
}
