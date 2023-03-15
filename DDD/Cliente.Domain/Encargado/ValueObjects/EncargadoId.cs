using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class EncargadoId : Identidad
    {
        //constructor
        public EncargadoId(Guid id) : base(id) { }


        //create method
        public static EncargadoId Of(Guid id)
        {
            return new EncargadoId(id);
        }
    }
}
