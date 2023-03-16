using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Entidades
{
    public class Pago : Entidad<PagoId>
    {
        //variables
        public PagoId PagoId { get; private set; }

        public DescripcionDelProducto DescripcionDelProducto { get; private set; }

        public Pago(PagoId id) : base(id)
        {

        }

        public void SetDescripcionDelProducto(DescripcionDelProducto descripcionDelProducto)
        {
            DescripcionDelProducto = descripcionDelProducto;
        }

       

    }
}
