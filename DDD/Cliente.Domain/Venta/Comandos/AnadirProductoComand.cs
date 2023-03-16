using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Comandos
{
    public class AnadirProductoComand
    {
        public string VentaId { get; init; }

        public string Nombre { get; init; }
        public int Precio { get; init; }
    }
}
