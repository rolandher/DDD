
using Cliente.Domain.ComandosDDD;

namespace Cliente.Domain.Cliente.ValueObjects
{
    public class PedidoId : Identidad
    {
        //constructor
        public PedidoId(Guid id) : base(id) { }


        //create method
        public static PedidoId Of(Guid id)
        {
            return new PedidoId(id);
        }

    }
}
