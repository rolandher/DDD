using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Cliente.Eventos
{
    public class DatoPersonalAnadido : EventoDominio
    {
        public DatosPersonales DatosPersonales { get; set; }

        public DatoPersonalAnadido(DatosPersonales datosPersonales) : base("datospersonales")
        {
            DatosPersonales = datosPersonales;
        }
    }
}
