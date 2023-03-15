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
    public class DatosPersonalesEncargadoAnadidos : EventoDominio
    {

        public DatosPersonalesEncargado DatosPersonalesEncargado { get; set; }

        public DatosPersonalesEncargadoAnadidos(DatosPersonalesEncargado datosPersonalesEncargado) : base("datospersonales.Encargado")
        {
            DatosPersonalesEncargado = datosPersonalesEncargado;
        }
    }
}
