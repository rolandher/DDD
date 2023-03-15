

using Cliente.Domain.ComandosDDD;

namespace Cliente.Domain.Cliente.ValueObjects
{
    public class ClienteId : Identidad
    {
        //constructor
        public ClienteId(Guid id) : base(id) { }


        //create method
        public static ClienteId Of(Guid id)
        {
            return new ClienteId(id);
        }

    }

}
