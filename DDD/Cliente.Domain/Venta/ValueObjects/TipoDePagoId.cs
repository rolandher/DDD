using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public class TipoDePagoId : Identidad
    {
        //constructor
        public TipoDePagoId(Guid id) : base(id) { }


        //create method
        public static TipoDePagoId Of(Guid id)
        {
            return new TipoDePagoId(id);
        }
    
    }   
}

