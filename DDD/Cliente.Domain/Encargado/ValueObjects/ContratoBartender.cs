using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class ContratoBartender
    {
        public string Contrato { get; init; }

        public ContratoBartender(string contrato)
        {
            Contrato = contrato;
        }

        public static ContratoBartender Crear(string contrato)
        {
            Validar(contrato);
            return new ContratoBartender(contrato);
        }
        public static void Validar(string contrato)
        {
            if (contrato == null)
            {
                throw new ArgumentNullException("Diligenciar el contrato es obligatorio");
            }

        }
    }
}
