using Cliente.Domain.Cliente.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Comandos
{
    public class AnadirPedidoComand
    {
        public AnadirPedidoComand(string cLienteId, int cantidad)
        {
            CLienteId = cLienteId;
            Cantidad = cantidad;
        }

        public string CLienteId { get; init; }
        public int Cantidad { get; init; }       

      
    }
}
