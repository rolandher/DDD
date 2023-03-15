
using System.Text.Json.Serialization;

namespace Cliente.Domain.Cliente.ValueObjects
{
    public class Cantidad
    {
        public int Value { get; set; }

        
        public Cantidad(int value)
        {
            this.Value = value;
        }
        public static Cantidad Crear(int value)
        {
            Validar(value);
            return new Cantidad(value);
        }

        public static void Validar(int value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El campo no puede estar vacio");
            }

        }

        public void SetValue(int value)
        {
            Value = value;
        }
    }     
      

}
