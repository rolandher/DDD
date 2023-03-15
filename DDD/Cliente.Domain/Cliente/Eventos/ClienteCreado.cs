using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Eventos
{
    public class ClienteCreado : EventoDominio
    {
        public string ClienteId { get; set; }

        public ClienteCreado(string clienteId) : base("Cliente.creado")
        {
            ClienteId = clienteId;
        }

    }
}
