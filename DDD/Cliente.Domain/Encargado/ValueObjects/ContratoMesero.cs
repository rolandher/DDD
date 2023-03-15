using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class ContratoMesero
    {
        public string Contrato { get; init; }

        public ContratoMesero(string contrato)
        {
            Contrato = contrato;
        }

        public static ContratoMesero Crear(string contrato)
        {
            Validar(contrato);
            return new ContratoMesero(contrato);
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
