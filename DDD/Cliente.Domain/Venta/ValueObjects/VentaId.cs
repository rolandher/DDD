using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class VentaId : Identidad
    {
        //constructor
        public VentaId(Guid id) : base(id) { }


        //create method
        public static VentaId Of(Guid id)
        {
            return new VentaId(id);
        }
    }
}
