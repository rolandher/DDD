using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class MeseroId : Identidad
    {
        //constructor
        public MeseroId(Guid id) : base(id) { }


        //create method
        public static MeseroId Of(Guid id)
        {
            return new MeseroId(id);
        }
    }
}
