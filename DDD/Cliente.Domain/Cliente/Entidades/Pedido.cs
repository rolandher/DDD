using Cliente.Domain.Cliente.Eventos;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Entidades
{
    public class Pedido : Entidad<PedidoId>
    {
        //variables
        public PedidoId PedidoId { get; private set; }

        public Cantidad Cantidad { get; private set; }

        public Pedido(PedidoId id) : base(id)
        {
            
        }
       
        public void SetPedidoId(PedidoId pedidoId)
        {
            this.PedidoId = pedidoId;
        }

        public void SetCantidad(Cantidad cantidad)
        {
            this.Cantidad = cantidad;
        }

    }
}
