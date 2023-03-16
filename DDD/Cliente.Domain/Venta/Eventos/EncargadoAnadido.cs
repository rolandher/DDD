using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class EncargadoAnadido : EventoDominio
    {
        public EncargadoId EncargadoId { get; init; }
        public EncargadoAnadido(EncargadoId encargadoId) : base("ventaencargado.anadido")
        {
            EncargadoId = encargadoId;
        }
    }
}
