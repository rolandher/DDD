using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Comandos
{
    public class AnadirEncargadoComand
    {
         
        public string VentaId { get; init; }
        public string EncargadoId { get; init; }
    }
}

