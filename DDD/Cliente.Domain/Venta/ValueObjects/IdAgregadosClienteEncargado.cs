using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Cliente.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class IdAgregadosClienteEncargado
    {
        public string ClienteId { get; set; }

        public string EncargadoId { get; set; }

        public IdAgregadosClienteEncargado(string clienteId, string encargadoId)
        {
            ClienteId = clienteId;
            EncargadoId = encargadoId;
        }

        public static IdAgregadosClienteEncargado Crear(string cLienteId, string encargadoId)
        {
            Validar(cLienteId, encargadoId);
            return new IdAgregadosClienteEncargado(cLienteId, encargadoId);
        }
        public static void Validar(string cLienteId, string encargadoId)
        {
            if (cLienteId == null)
            {
                throw new ArgumentNullException("Diligenciar el detalle ");
            }
            if (encargadoId == null)
            {
                throw new ArgumentNullException("Diligenciar el detalle ");
            }

        }
    }
}
