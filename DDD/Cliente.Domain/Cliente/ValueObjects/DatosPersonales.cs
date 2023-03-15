
using Cliente.Domain.Cliente.Comandos;
using System.Text.Json.Serialization;

namespace Cliente.Domain.Cliente.ValueObjects
{
    public class DatosPersonales
    {
        public string Nombre { get; set; } 

        public string Correo { get; set; }

        public DatosPersonales(string nombre, string correo)
        {
            this.Nombre = nombre;
            this.Correo = correo;
        }
        public void SetNombre(string nombre)
        {            
            Nombre = nombre;
        }
        public void SetCorreo(string correo)
        {
            Correo = correo;
        }

        public static DatosPersonales Crear(string nombre, string correo)
        {
            Validar(nombre,correo);
            return new DatosPersonales(nombre, correo);
        }
        public static void Validar(string nombre, string correo)
        {
            
            if (nombre == null)
            {
                throw new ArgumentNullException("El nombre no puede estar vacio");
                      
            }
            if (correo == null)
            {
                throw new ArgumentNullException("El correo no puede estar vacio");
            }

        }               
        
        
    }
}
