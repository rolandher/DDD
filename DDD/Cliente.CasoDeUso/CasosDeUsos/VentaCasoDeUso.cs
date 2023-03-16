using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Encargado.Entidades;
using Cliente.Domain.Encargado.Eventos;
using Cliente.Domain.Encargado.ValueObjects;
using Cliente.Domain.Generico;
using Cliente.Domain.Venta.Comandos;
using Cliente.Domain.Venta.Entidades;
using Cliente.Domain.Venta.Eventos;
using Cliente.Domain.Venta.ValueObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.CasoDeUso.CasosDeUsos
{
    public class VentaCasoDeUso : ICasodeUsoVenta
    {
        private readonly IEventoRepositorio<AlmacenamientoEvento> _eventoRepositorio;

        public VentaCasoDeUso(IEventoRepositorio<AlmacenamientoEvento> eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public async Task<Venta> CrearVenta(CrearVentaComand crearVentaComand)
        {
            var venta = new Venta(VentaId.Of(Guid.NewGuid()));
            venta.SetVentaId(venta.VentaId);

            var detallesVenta = DetallesVenta.Crear(
                crearVentaComand.Nombre
                );

            venta.SetDetallesVentaAnadido(detallesVenta);
            List<EventoDominio> eventoDominios = venta.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            var ventaCambiada = new VentaCambiada();
            venta = ventaCambiada.CrearAgregado(eventoDominios, venta.VentaId);
            return venta;
        }


        public async Task<Venta> AnadirProducto(AnadirProductoComand anadirProductoComand)
        {
            var ventaCambiada = new VentaCambiada();
            var listaEventosDominio = await GetEventosAgregadoId(anadirProductoComand.VentaId);
            var ventaId = VentaId.Of(Guid.Parse(anadirProductoComand.VentaId));
            var productoRealizado = ventaCambiada.CrearAgregado(listaEventosDominio, ventaId);



            var producto = new Producto(ProductoId.Of(Guid.NewGuid()));
            var valorProducto = ValorProducto.Crear(
                               anadirProductoComand.Nombre,
                               anadirProductoComand.Precio
                    );

            productoRealizado.SetAnadirProducto(valorProducto);            
            List<EventoDominio> eventoDominios = productoRealizado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            ventaCambiada = new VentaCambiada();
            listaEventosDominio = await GetEventosAgregadoId(anadirProductoComand.VentaId);
            productoRealizado = ventaCambiada.CrearAgregado(listaEventosDominio, ventaId);

            return productoRealizado;
        }

        public async Task<Venta> AnadirPago(AnadirDescripcionComand anadirDescripcionComand)
        {
            var ventaCambiada = new VentaCambiada();
            var listaEventosDominio = await GetEventosAgregadoId(anadirDescripcionComand.VentaId);
            var ventaId = VentaId.Of(Guid.Parse(anadirDescripcionComand.VentaId));
            var tipoRealizado = ventaCambiada.CrearAgregado(listaEventosDominio, ventaId);



            var pago = new Pago(PagoId.Of(Guid.NewGuid()));
            var descripcionProducto = DescripcionDelProducto.Crear(
                               anadirDescripcionComand.DescripcionCompra,
                               anadirDescripcionComand.TotalCompra
                    );

            tipoRealizado.SetAnadirDescripcion(descripcionProducto);

            List<EventoDominio> eventoDominios = tipoRealizado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            ventaCambiada = new VentaCambiada();
            listaEventosDominio = await GetEventosAgregadoId(anadirDescripcionComand.VentaId);
            tipoRealizado = ventaCambiada.CrearAgregado(listaEventosDominio, ventaId);

            return tipoRealizado;
        }

            public async Task<Venta> AnadirCliente(AnadirClienteComand anadirClienteComand)
            {
                var ventaCambiada = new VentaCambiada();
                var listaEventosDominioVenta = await GetEventosAgregadoId(anadirClienteComand.VentaId);
                var ventaId = VentaId.Of(Guid.Parse(anadirClienteComand.VentaId));
                var ventaRealizada = ventaCambiada.CrearAgregado(listaEventosDominioVenta, ventaId);
                

                var cienteCambiado = new ClienteCambiado();
                var listaEventosDominioCliente = await GetEventosClienteAgregadoId(anadirClienteComand.CLienteId);
                var clienteId = ClienteId.Of(Guid.Parse(anadirClienteComand.CLienteId));
                var clienteRealizado = cienteCambiado.CrearAgregado(listaEventosDominioCliente, clienteId);

                ventaRealizada.SetCliente(clienteRealizado.ClienteId);

                List<EventoDominio> eventoDominios = ventaRealizada.GetUnCommitChanges();
                await SaveEvents(eventoDominios);

                ventaCambiada = new VentaCambiada();
                listaEventosDominioVenta = await GetEventosAgregadoId(anadirClienteComand.VentaId);
                ventaRealizada = ventaCambiada.CrearAgregado(listaEventosDominioVenta, ventaId);
                return ventaRealizada;

            }

        public async Task<Venta> AnadirEncargado(AnadirEncargadoComand anadirEncargadoComand)
        {
            var ventaCambiada = new VentaCambiada();
            var listaEventosDominioVenta = await GetEventosAgregadoId(anadirEncargadoComand.VentaId);
            var ventaId = VentaId.Of(Guid.Parse(anadirEncargadoComand.VentaId));
            var ventaRealizada = ventaCambiada.CrearAgregado(listaEventosDominioVenta, ventaId);


            var encargadoCambiado = new EncargadoCambiado();
            var listaEventosDominioCliente = await GetEventosEncargadogregadoId(anadirEncargadoComand.EncargadoId);
            var encargadoId = EncargadoId.Of(Guid.Parse(anadirEncargadoComand.EncargadoId));
            var encargadoRealizado = encargadoCambiado.CrearAgregado(listaEventosDominioCliente, encargadoId);

            ventaRealizada.SetEncargado(encargadoRealizado.EncargadoId);

            List<EventoDominio> eventoDominios = ventaRealizada.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            ventaCambiada = new VentaCambiada();
            listaEventosDominioVenta = await GetEventosAgregadoId(anadirEncargadoComand.VentaId);
            ventaRealizada = ventaCambiada.CrearAgregado(listaEventosDominioVenta, ventaId);
            return ventaRealizada;

        }

        private async Task SaveEvents(List<EventoDominio> list)
        {
            var array = list.ToArray();
            for (var index = 0; index < array.Length; index++)
            {
                var almacenamiento = new AlmacenamientoEvento();
                almacenamiento.AgregadoId = array[index].GetAggregateId();
                almacenamiento.Nombre = array[index].GetAggregate();
                switch (array[index])
                {
                    case VentaCreada ventaCreada:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(ventaCreada);
                        break;
                    case DetalleVentaAnadido detalleVentaAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(detalleVentaAnadido);
                        break;
                    //ProductoEve
                    case ProductoAnadido productoAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(productoAnadido);
                        break;
                    
                    //PagoEve
                    case DescripcionAnadida descripcionAnadida:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(descripcionAnadida);
                        break;

                    //ClienteEve
                    case ClienteAnadido clienteAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(clienteAnadido);
                        break;
                    //EncargaEve
                    case EncargadoAnadido encargadoAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(encargadoAnadido);
                        break;



                }
                await _eventoRepositorio.AddAsync(almacenamiento);

            }

            await _eventoRepositorio.SaveChangesAsync();

        }

        private async Task<List<EventoDominio>> GetEventosAgregadoId(string aggregateId)
        {
            var listadoEventos = await _eventoRepositorio.GetEventosAgregadoId(aggregateId);

            if (listadoEventos == null)
                throw new ArgumentException("No existe el Id del agregado en la base de datos");

            return listadoEventos.Select(ev =>
            {
                string nombre = $"Cliente.Domain.Venta.Eventos.{ev.Nombre}, Cliente.Domain";
                Type tipo = Type.GetType(nombre);
                EventoDominio eventoParseado = (EventoDominio)JsonConvert.DeserializeObject(ev.CuerpoEvento, tipo);
                return eventoParseado;

            }).ToList();


        }
        private async Task<List<EventoDominio>> GetEventosClienteAgregadoId(string aggregateId)
        {
            var listadoEventos = await _eventoRepositorio.GetEventosAgregadoId(aggregateId);

            if (listadoEventos == null)
                throw new ArgumentException("No existe el Id del agregado en la base de datos");

            return listadoEventos.Select(ev =>
            {
                string nombre = $"Cliente.Domain.Cliente.Eventos.{ev.Nombre}, Cliente.Domain";
                Type tipo = Type.GetType(nombre);
                EventoDominio eventoParseado = (EventoDominio)JsonConvert.DeserializeObject(ev.CuerpoEvento, tipo);
                return eventoParseado;

            }).ToList();


        }
        private async Task<List<EventoDominio>> GetEventosEncargadogregadoId(string aggregateId)
        {
            var listadoEventos = await _eventoRepositorio.GetEventosAgregadoId(aggregateId);

            if (listadoEventos == null)
                throw new ArgumentException("No existe el Id del agregado en la base de datos");

            return listadoEventos.Select(ev =>
            {
                string nombre = $"Cliente.Domain.Encargado.Eventos.{ev.Nombre}, Cliente.Domain";
                Type tipo = Type.GetType(nombre);
                EventoDominio eventoParseado = (EventoDominio)JsonConvert.DeserializeObject(ev.CuerpoEvento, tipo);
                return eventoParseado;

            }).ToList();


        }


    }
}
