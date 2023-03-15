using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Eventos
{
    public class PedidoEliminado : EventoDominio
    {
        public PedidoId PedidoId { get; set; }

        public PedidoEliminado(PedidoId pedidoId) : base("Pedido.eliminado")
        {
            pedidoId = pedidoId;
        }

    }
}
