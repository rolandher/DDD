using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class EncargadoCreado : EventoDominio
    {
        public string EncargadoId { get; set; }

        public EncargadoCreado(string encargadoId) : base("encargado.creado")
        {
            EncargadoId = encargadoId;
        }
    }
}
