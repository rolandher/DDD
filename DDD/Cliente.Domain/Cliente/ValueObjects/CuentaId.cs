using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.ValueObjects
{
    public class CuentaId : Identidad
    {
        //constructor
        public CuentaId(Guid id) : base(id) { }


        //create method
        public static CuentaId Of(Guid id)
        {
            return new CuentaId(id);
        }


    }
}
