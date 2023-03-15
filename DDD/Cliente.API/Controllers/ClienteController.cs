using Cliente.CasoDeUso.CasosDeUsos;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Cliente.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase   
    {

        private readonly ICasodeUsoCliente _casoDeUso;

        public ClienteController(ICasodeUsoCliente crearClienteCasodeUso)
        {
            _casoDeUso = crearClienteCasodeUso;
        }

        [HttpPost]
        public async Task<Domain.Cliente.Entidades.Cliente> CrearCliente(CrearClienteComand comand)
        {
            var crearCliente = await _casoDeUso.CrearCliente(comand);
            return crearCliente;
        }

        [HttpPost("anadirPedido")]
        public async Task<Domain.Cliente.Entidades.Cliente> AnadirPedido(AnadirPedidoComand comand)
        {            
            var pedidoAnadido = await _casoDeUso.AnadirPedido(comand);
            return pedidoAnadido;
        }
        [HttpPost("anadirCuenta")]
        public async Task<Domain.Cliente.Entidades.Cliente> AnadirCuenta(AnadirCuentaComand comand)
        {
            var cuentaAnadido = await _casoDeUso.AnadirCuenta(comand);
            return cuentaAnadido;
        }

    }
}
