using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class DatosPersonalesMesero
    {
        public string Nombre { get; init; }

        public DatosPersonalesMesero(string nombre)
        {
            Nombre = nombre;
        }

        public static DatosPersonalesMesero Crear(string nombre)
        {
            Validar(nombre);
            return new DatosPersonalesMesero(nombre);
        }
        public static void Validar(string nombre)
        {
            if (nombre == null)
            {
                throw new ArgumentNullException("El nombre no puede estar vacio");
            }

        }
    }
}
