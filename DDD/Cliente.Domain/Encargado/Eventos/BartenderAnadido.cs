using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class BartenderAnadido : EventoDominio
    {
        public BartenderId BartenderId { get; set; }

        public BartenderAnadido(BartenderId bartenderId) : base("Bartender.anadido")
        {
            BartenderId = bartenderId;
        }
    }
}
