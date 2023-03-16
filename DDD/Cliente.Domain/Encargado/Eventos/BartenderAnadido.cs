using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.Entidades;
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
        public Bartender Bartender { get; set; }

        public BartenderAnadido(Bartender bartender) : base("Bartender.anadido")
        {
            Bartender = bartender;
        }
    }
}
