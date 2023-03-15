using Cliente.Domain.Cliente.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Comandos
{
    public class EliminarPedidoComand
    {
        public int Cantidad { get; init; }

        public PedidoId PedidoId { get; init; }

        public string ClienteId { get; init; }

        public EliminarPedidoComand(int cantidad, PedidoId pedidoId, string clienteId)
        {
            Cantidad = cantidad;
            PedidoId = pedidoId;
            ClienteId = ClienteId;
        }
    }
}
