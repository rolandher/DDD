using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Comandos
{
    public class AnadirBartenderComand
    {
        public string Nombre { get; init; }
        public string TipoDeContrato { get; init; }


        public AnadirBartenderComand(string nombre, string tipodecontrato)
        {
            Nombre = nombre;
            TipoDeContrato = tipodecontrato;
        }
    }
}
