using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Eventos
{
    public class CuentaAnadido : EventoDominio
    {
        public CuentaId CuentaId { get; set; }

        public CuentaAnadido(CuentaId cuenta) : base("Pago.anadido")
        {
            CuentaId = cuenta;
        }

    }
}
