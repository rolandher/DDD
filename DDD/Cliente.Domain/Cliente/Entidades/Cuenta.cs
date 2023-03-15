using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Entidades
{
    public class Cuenta : Entidad<CuentaId>
    {
        //variables
        public CuentaId CuentaId { get; private set; }
       

        public Cuenta(CuentaId id) : base(id)
        {

        }

        public void SetCuentaId(CuentaId cuentaId)
        {
            this.CuentaId = cuentaId;
        }

    }
}
