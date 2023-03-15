using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class MeseroEliminado : EventoDominio
    {
        public MeseroId MeseroId { get; set; }

        public MeseroEliminado(MeseroId meseroId) : base("Mesero.eliminado")
        {
            MeseroId = meseroId;
        }
    }
}
