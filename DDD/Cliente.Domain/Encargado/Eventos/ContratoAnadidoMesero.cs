using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class ContratoAnadidoMesero : EventoDominio
    {
        public ContratoMesero ContratoMesero { get; set; }

        public ContratoAnadidoMesero(ContratoMesero contratoMesero) : base("contrato.mesero")
        {
            ContratoMesero = contratoMesero;
        }
    }
    
}
