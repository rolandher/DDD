using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Comandos
{
    public class EliminarBartenderComand
    {
        public BartenderId BartenderId { get; init; }

        public EliminarBartenderComand(BartenderId bartenderId)
        {
            BartenderId = bartenderId;
        }
    }
}

