using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class ProductoId : Identidad
    {
        //constructor
        public ProductoId(Guid id) : base(id) { }


        //create method
        public static ProductoId Of(Guid id)
        {
            return new ProductoId(id);
        }
    }
}
