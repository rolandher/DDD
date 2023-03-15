using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class DatosPersonalesBartender
    {
        public string Nombre { get; init; }

        public DatosPersonalesBartender(string nombre)
        {
            Nombre = nombre;
        }

        public static DatosPersonalesBartender Crear(string nombre)
        {
            Validar(nombre);
            return new DatosPersonalesBartender(nombre);
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
