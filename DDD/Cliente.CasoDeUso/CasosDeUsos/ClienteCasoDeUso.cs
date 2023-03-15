using Azure;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Cliente.Eventos;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Generico;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cliente.CasoDeUso.CasosDeUsos
{
    public class ClienteCasoDeUso : ICasodeUsoCliente
    {
        private readonly IEventoRepositorio<AlmacenamientoEvento> _eventoRepositorio;

        

        public ClienteCasoDeUso(IEventoRepositorio<AlmacenamientoEvento> eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public async Task<Domain.Cliente.Entidades.Cliente> CrearCliente(CrearClienteComand crearClienteComand)
        {
            var cliente = new Domain.Cliente.Entidades.Cliente(ClienteId.Of(Guid.NewGuid()));
            cliente.SetClienteID(cliente.ClienteId);
            

            var datosPersonales = DatosPersonales.Crear(
                crearClienteComand.Nombre,
                crearClienteComand.Correo
                );

            
            cliente.SetDatoPersonalAnadido(datosPersonales);
            List<EventoDominio> eventoDominios = cliente.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            var clienteCambiado = new ClienteCambiado();
            cliente = clienteCambiado.CrearAgregado(eventoDominios, cliente.ClienteId);
            return cliente;
        }

        public async Task<Domain.Cliente.Entidades.Cliente> AnadirPedido(AnadirPedidoComand anadirPedidoComand)
        {
            var clienteCambiado = new ClienteCambiado();
            var listaEventosDominio = await GetEventosAgregadoId(anadirPedidoComand.CLienteId);
            var clienteId = ClienteId.Of(Guid.Parse(anadirPedidoComand.CLienteId));
            var clienteRealizado = clienteCambiado.CrearAgregado(listaEventosDominio, clienteId);
            


            var pedido = new Pedido(PedidoId.Of(Guid.NewGuid()));
            var cantidad = Cantidad.Crear(
                               anadirPedidoComand.Cantidad
                );

            clienteRealizado.SetPedidoAnadido(pedido.PedidoId);
            List<EventoDominio> eventoDominios = clienteRealizado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            clienteCambiado = new ClienteCambiado();
            listaEventosDominio = await GetEventosAgregadoId(anadirPedidoComand.CLienteId);
            clienteRealizado = clienteCambiado.CrearAgregado(listaEventosDominio, clienteId);

            return clienteRealizado;
        }


        public async Task<Domain.Cliente.Entidades.Cliente> AnadirCuenta(AnadirCuentaComand anadirCuentaComand)
        {
            var clienteCambiado = new ClienteCambiado();
            var listaEventosDominio = await GetEventosAgregadoId(anadirCuentaComand.CLienteId);
            var clienteId = ClienteId.Of(Guid.Parse(anadirCuentaComand.CLienteId));
            var clienteRealizado = clienteCambiado.CrearAgregado(listaEventosDominio, clienteId);
            

            var cuenta = new Cuenta(CuentaId.Of(Guid.NewGuid()));
            var metodoDePago = MetodosDePago.Crear(
                anadirCuentaComand.TarjetaCredito                               
                );

            clienteRealizado.SetCuentaAnadido(cuenta.CuentaId);
            List<EventoDominio> eventoDominios = clienteRealizado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);


            clienteCambiado = new ClienteCambiado();
            listaEventosDominio = await GetEventosAgregadoId(anadirCuentaComand.CLienteId);
            clienteRealizado = clienteCambiado.CrearAgregado(listaEventosDominio, clienteId);
            return clienteRealizado;
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
                        case ClienteCreado clienteCreado:
                            almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(clienteCreado);
                            break;
                         case DatoPersonalAnadido datoPersonalAnadido:
                             almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(datoPersonalAnadido);
                        break;
                        case PedidoAnadido anadirPedido:
                            almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(anadirPedido);
                            break;
                        case CuentaAnadido anadirPago:
                            almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(anadirPago);
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
                    string nombre = $"Cliente.Domain.Cliente.Eventos.{ev.Nombre}, Cliente.Domain";
                    Type tipo = Type.GetType(nombre);
                    EventoDominio eventoParseado = (EventoDominio)JsonConvert.DeserializeObject(ev.CuerpoEvento, tipo);
                    return eventoParseado;

                }).ToList();       


            }
        
    }
}


