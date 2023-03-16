using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class AgregadosHijos : EventoDominio
    {

        public IdAgregadosClienteEncargado IdAgregadosClienteEncargado { get; set; }
        public AgregadosHijos(IdAgregadosClienteEncargado idAgregadosClienteEncargado) : base("agregados.id")
        {
            IdAgregadosClienteEncargado = idAgregadosClienteEncargado;
        }
    }
}
