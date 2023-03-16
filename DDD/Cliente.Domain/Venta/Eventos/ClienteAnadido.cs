using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class ClienteAnadido : EventoDominio
    {
            public ClienteId ClienteId { get; init; }
            public ClienteAnadido(ClienteId clienteId) : base("ventacliente.anadido")
            {
                ClienteId = clienteId;
            }
        
    }
}
