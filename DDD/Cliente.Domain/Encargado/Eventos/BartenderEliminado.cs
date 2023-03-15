using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class BartenderEliminado : EventoDominio
    {
        public BartenderId BartenderId { get; set; }

        public BartenderEliminado(BartenderId bartenderId) : base("Bartender.eliminado")
        {
            BartenderId = bartenderId;
        }
    }
}
