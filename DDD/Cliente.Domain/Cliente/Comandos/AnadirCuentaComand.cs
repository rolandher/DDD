using Cliente.Domain.Cliente.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Comandos
{
    public class AnadirCuentaComand
    {

        public string CLienteId { get; init; }
        public int TarjetaCredito { get; init; }
        
      
    }
}
