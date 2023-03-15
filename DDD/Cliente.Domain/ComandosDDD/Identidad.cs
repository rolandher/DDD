using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.ComandosDDD
{
    public class Identidad
    {
        public Guid Uuid { get; set; }

        public Identidad(Guid uuid)
        {
            if (uuid == Guid.Empty)
                throw new ArgumentException("Id no puede ser vacio");
            this.Uuid = uuid;
        }
    }
}
