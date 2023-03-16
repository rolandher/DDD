using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Eventos
{
    public class PedidoAnadido : EventoDominio
    {
        public Pedido Pedido { get; set; }

        public PedidoAnadido(Pedido pedido) : base("Pedido.anadido")
        {
            Pedido = pedido;
        }

    }
}
