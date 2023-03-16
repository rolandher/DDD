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
     
        public virtual Cuenta Cuenta { get; private set; }

        public virtual Pedido Pedido { get; private set; }




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

        public void SetPedidoAnadido(Pedido pedido)
        {
            AgregarCambios(new PedidoAnadido(pedido));
        }

        public void SetCuentaAnadido(Cuenta metodosDePago)
        {
            AgregarCambios(new CuentaAnadido(metodosDePago));
        }
      

        // Metodos de cambio del agregado como entidad
        public void SetDatosPersonalesAgregados(DatosPersonales datosPersonales)
        {
            DatosPersonales= datosPersonales;
        }

        public void SetAnadirPedido(Pedido pedido)
        {
            Pedido= pedido;
        }

        public void SetAnadirPago(Cuenta cuenta)
        {
            Cuenta = cuenta;
        }
       



    }
}
