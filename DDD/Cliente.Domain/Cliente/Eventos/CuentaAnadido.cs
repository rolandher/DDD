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
    public class CuentaAnadido : EventoDominio
    {
        public Cuenta Cuenta { get; set; }

        public CuentaAnadido(Cuenta cuenta) : base("Pago.anadido")
        {
            Cuenta = cuenta;
        }

    }
}
