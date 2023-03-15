using Cliente.Domain.Cliente.Eventos;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System.ComponentModel.Design;

namespace Cliente.Domain.Cliente.Entidades
{
    public class Cliente : AgregarEvento<ClienteId>
    {
        public ClienteId ClienteId { get; init; }
       
        public DatosPersonales DatosPersonales { get; private set; } 
        
        public virtual PedidoId PedidoId { get; private set; }

        public virtual CuentaId CuentaId { get; private set; }

        //manejador de eventos
        public Cliente(ClienteId clienteId) : base (clienteId)
        {
            this.ClienteId = clienteId;
        }

        public void SetClienteID(ClienteId clienteId)
        {
            AgregarCambios(new ClienteCreado(clienteId.ToString()));
        }

        public void SetDatoPersonalAnadido(DatosPersonales datosPersonales)
        {
            AgregarCambios(new DatoPersonalAnadido(datosPersonales));
        }

        public void SetPedidoAnadido(PedidoId pedido)
        {
            AgregarCambios(new PedidoAnadido(pedido));
        }

        public void SetCuentaAnadido(CuentaId metodosDePago)
        {
            AgregarCambios(new CuentaAnadido(metodosDePago));
        }
        public void SetEliminarPedidoId(PedidoId pedidoId)
        {
            AgregarCambios(new PedidoEliminado(pedidoId));
        }

        // Metodos de cambio del agregado como entidad
        public void SetDatosPersonalesAgregados(DatosPersonales datosPersonales)
        {
            DatosPersonales= datosPersonales;
        }

        public void SetAnadirPedido(PedidoId pedidoId)
        {
            PedidoId = pedidoId;
        }

        public void SetAnadirPago(CuentaId cuentaId)
        {
            CuentaId = cuentaId;
        }

        public void SetEliminarPedido(PedidoId pedidoId)
        {
            PedidoId = pedidoId;
        }



    }
}
