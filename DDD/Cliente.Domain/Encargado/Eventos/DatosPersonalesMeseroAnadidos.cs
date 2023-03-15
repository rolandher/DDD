using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class DatosPersonalesMeseroAnadidos : EventoDominio
    {
        public DatosPersonalesMesero DatosPersonalesMesero { get; set; }

        public DatosPersonalesMeseroAnadidos(DatosPersonalesMesero datosPersonalesMesero) : base("datospersonales.mesero")
        {
            DatosPersonalesMesero = datosPersonalesMesero;
        }
    }
}
