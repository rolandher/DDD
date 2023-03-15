using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Cliente.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.CasoDeUso.PuertaEnlace
{
    public interface ICasodeUsoCliente
    {
        Task<Domain.Cliente.Entidades.Cliente> CrearCliente(CrearClienteComand clienteComand);
        Task<Domain.Cliente.Entidades.Cliente> AnadirPedido(AnadirPedidoComand anadirPedidoComand);
        Task<Domain.Cliente.Entidades.Cliente> AnadirCuenta(AnadirCuentaComand anadirCuentaComand);        
    }
}
