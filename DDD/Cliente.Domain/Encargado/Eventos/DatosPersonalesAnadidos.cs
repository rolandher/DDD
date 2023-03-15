using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class DatosPersonalesAnadidos : EventoDominio
    {

        public DatosPersonalesEncargado DatosPersonalesEncargado { get; set; }

        public DatosPersonalesAnadidos(DatosPersonalesEncargado datosPersonalesEncargado) : base("datospersonales")
        {
            DatosPersonalesEncargado = datosPersonalesEncargado;
        }
    }
}
