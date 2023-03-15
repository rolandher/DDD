
using Cliente.Domain.ComandosDDD;

namespace Cliente.Domain.Encargado.ValueObjects
{
    public class BartenderId : Identidad
    {
        //constructor
        public BartenderId(Guid id) : base(id) { }


        //create method
        public static BartenderId Of(Guid id)
        {
            return new BartenderId(id);
        }
    }
}
