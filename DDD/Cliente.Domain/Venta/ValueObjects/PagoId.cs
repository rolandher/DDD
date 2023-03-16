using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class PagoId : Identidad
    {
        //constructor
        public PagoId(Guid id) : base(id) { }


        //create method
        public static PagoId Of(Guid id)
        {
            return new PagoId(id);
        }
    
    }   
}

