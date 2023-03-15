using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Encargado.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncargadoController : ControllerBase
    {

        private readonly ICasodeUsoEncargado _casodeUsoEncargado;

        public EncargadoController(ICasodeUsoEncargado crearEncargadoCasoDeUso)
        {
            _casodeUsoEncargado = crearEncargadoCasoDeUso;
        }

        [HttpPost]
        public async Task<Encargado> CrearEncargado(CrearEncargadoComand comand)
        {
            var encargadoCreado = await _casodeUsoEncargado.CrearEncargado(comand);
            return encargadoCreado;
        }

        [HttpPost("anadirMesero")]
        public async Task<Encargado> AnadirMesero(AnadirMeseroComand comand)
        {
            var meseroAnadido = await _casodeUsoEncargado.AnadirMesero(comand);
            return meseroAnadido;
        }
        [HttpPost("anadirBartender")]
        public async Task<Encargado> AnadirBartender(AnadirBartenderComand comand)
        {
            var bartenderAnadido = await _casodeUsoEncargado.AnadirBartender(comand);
            return bartenderAnadido;
        }
    }

}
