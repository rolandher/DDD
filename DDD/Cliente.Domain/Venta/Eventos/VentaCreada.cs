using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class VentaCreada : EventoDominio
    {
        public string VentaId { get; set; }

        public VentaCreada(string ventaId) : base("venta.creado")
        {
            VentaId = ventaId;
        }
    }
}
