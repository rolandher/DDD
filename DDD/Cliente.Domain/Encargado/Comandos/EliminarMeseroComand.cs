using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Comandos
{
    public class EliminarMeseroComand
    {
        public MeseroId MeseroId { get; init; }

        public EliminarMeseroComand(MeseroId meseroId)
        {
            MeseroId = meseroId;
        }
    }
}
