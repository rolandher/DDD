using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class DatosPersonalesBartenderAnadidos : EventoDominio
    {
        public DatosPersonalesBartender DatosPersonalesBartender { get; set; }

        public DatosPersonalesBartenderAnadidos(DatosPersonalesBartender datosPersonalesBartender) : base("datospersonales.bartender")
        {
            DatosPersonalesBartender = datosPersonalesBartender;
        }
    }
}
