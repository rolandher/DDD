using Cliente.Domain.Cliente.ValueObjects;

namespace Cliente.Domain.Cliente.Repositorio
{
    public interface IClienteRepositorio
    {
        Task<Entidades.Cliente> CrearCliente(Entidades.Cliente cliente);
        
        Task AnadirPedido (Guid clienteId, Guid pedidoId);

        Task AnadirPago (Guid clienteId, Guid cuentaId);

        Task EliminarPedido (Guid clienteId);    

    }
}
