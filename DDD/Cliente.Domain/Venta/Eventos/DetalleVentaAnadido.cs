using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class DetalleVentaAnadido : EventoDominio
    {
        public DetallesVenta DetallesVenta { get; set; }

        public DetalleVentaAnadido(DetallesVenta detallesVenta) : base("detallesventa.creado")
        {
            DetallesVenta = detallesVenta;
        }
    }
}
