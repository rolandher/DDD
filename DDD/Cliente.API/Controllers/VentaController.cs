using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Venta.Comandos;
using Cliente.Domain.Venta.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : ControllerBase
    {

        private readonly ICasodeUsoVenta _casoDeUsoVenta;

        public VentaController(ICasodeUsoVenta crearVentaCasoDeUso)
        {
            _casoDeUsoVenta = crearVentaCasoDeUso;
        }

        [HttpPost]
        public async Task<Venta> CrearVenta(CrearVentaComand comand)
        {
            var ventaCreada = await _casoDeUsoVenta.CrearVenta(comand);
            return ventaCreada;
        }

        [HttpPost("anadirProducto")]
        public async Task<Venta> AnadirProducto(AnadirProductoComand comand)
        {
            var productoAnadido = await _casoDeUsoVenta.AnadirProducto(comand);
            return productoAnadido;
        }
        [HttpPost("anadirPago")]
        public async Task<Venta> AnadirPago(AnadirDescripcionComand comand)
        {
            var pagoAnadido = await _casoDeUsoVenta.AnadirPago(comand);
            return pagoAnadido;
        }
    }
}
