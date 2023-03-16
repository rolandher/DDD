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
    public class ClienteCambiado
    {

        public Cliente CrearAgregado(List<EventoDominio> ev, ClienteId clienteId)
        {
            Cliente cliente = new (clienteId);
            ev.ForEach(evento =>
            {
                switch (evento)
                {
                    case DatoPersonalAnadido datoPersonalAnadido:
                        cliente.SetDatosPersonalesAgregados(datoPersonalAnadido.DatosPersonales);
                        break;

                    case PedidoAnadido anadirPedido:
                        cliente.SetAnadirPedido(anadirPedido.Pedido);
                        break;

                    case CuentaAnadido anadirPago:
                        cliente.SetAnadirPago(anadirPago.Cuenta);
                        break;                    

                }

            });
            return cliente;
        }

    }
}
