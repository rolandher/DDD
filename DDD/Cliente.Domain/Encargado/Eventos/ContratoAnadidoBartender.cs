using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class ContratoAnadidoBartender : EventoDominio
    {
        public ContratoBartender ContratoBartender { get; set; }

        public ContratoAnadidoBartender(ContratoBartender contratoBartender) : base("contrato.bartender")
        {
            ContratoBartender = contratoBartender;
        }
    }
}
