using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Comandos
{
    public class AnadirBartenderComand
    {
        public string EncargadoId { get; init; }

        public string Nombre { get; init; }
        public string TipoDeContrato { get; init; }

    }
}
