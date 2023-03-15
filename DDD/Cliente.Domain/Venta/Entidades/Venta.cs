using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.Encargado.ValueObjects;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Entidades
{
    public class Venta
    {
        public VentaId VentaId { get; private set; }
       
        public virtual TipoDePagoId TipoDePago { get; private set; }

        public virtual ProductoId Producto { get; private set; }


        public Venta(VentaId id)
        {
            this.VentaId = id;
        }
            
        

    }
}
