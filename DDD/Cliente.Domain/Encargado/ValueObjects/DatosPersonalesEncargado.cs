
namespace Cliente.Domain.Encargado.ValueObjects
{
    public class DatosPersonalesEncargado
    {
        public string Nombre { get; init; }

        public string Sexo { get; init; }

        public int Edad { get; init; }

        public DatosPersonalesEncargado(string nombre, string sexo, int edad)
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
        }

        public static DatosPersonalesEncargado Crear(string nombre, string sexo, int edad)
        {
            Validar(nombre, sexo, edad);
            return new DatosPersonalesEncargado(nombre, sexo, edad);
        }
        public static void Validar(string nombre, string sexo, int edad)
        {

            if (nombre == null)
            {
                throw new ArgumentNullException("El nombre no puede estar vacio");
            }
            if (sexo == null)
            {
                throw new ArgumentNullException("El campo no puede estar vacio");
            }
            if (edad == null)
            {
                throw new ArgumentNullException("El campo no puede estar vacio");
            }

        }
    }
   
 }


