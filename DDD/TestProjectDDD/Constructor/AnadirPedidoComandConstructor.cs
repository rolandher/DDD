using Cliente.Domain.Cliente.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDDD.Constructor
{
    public class AnadirPedidoComandConstructor
    {
        private string _cLienteId;
        private int _cantidad;

        public AnadirPedidoComandConstructor WithCLienteId(string cLienteId)
        {
            _cLienteId = cLienteId;
            return this;
        }

        public AnadirPedidoComandConstructor WithCantidad(int cantidad)
        {
            _cantidad = cantidad;
            return this;
        }

        public AnadirPedidoComand Build()
        {
            return new AnadirPedidoComand(_cLienteId, _cantidad);
        }

    }
}
