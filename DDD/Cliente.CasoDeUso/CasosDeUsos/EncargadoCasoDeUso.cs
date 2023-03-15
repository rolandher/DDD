using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Encargado.Entidades;
using Cliente.Domain.Encargado.Eventos;
using Cliente.Domain.Encargado.ValueObjects;
using Cliente.Domain.Generico;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.CasoDeUso.CasosDeUsos
{
    public class EncargadoCasoDeUso : ICasodeUsoEncargado
    {
        private readonly IEventoRepositorio<AlmacenamientoEvento> _eventoRepositorio;

        public EncargadoCasoDeUso(IEventoRepositorio<AlmacenamientoEvento> eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public async Task<Encargado> CrearEncargado(CrearEncargadoComand crearEncargadoComand)
        {
            var encargado = new Encargado(EncargadoId.Of(Guid.NewGuid()));
            encargado.SetEncargadoId(encargado.EncargadoId);

            var datosPersonales = DatosPersonalesEncargado.Crear(
                crearEncargadoComand.Nombre,
                crearEncargadoComand.Sexo,
                crearEncargadoComand.Edad
                );

            encargado.SetDatoPersonalAnadido(datosPersonales);
            List<EventoDominio> eventoDominios = encargado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            var encargadoCambiado = new EncargadoCambiado();
            encargado = encargadoCambiado.CrearAgregado(eventoDominios, encargado.EncargadoId);
            return encargado;
        }


        public async Task<Encargado> AnadirMesero(AnadirMeseroComand anadirMeseroComand)
        {
            var encargadoCambiado = new EncargadoCambiado();
            var listaEventosDominio = await GetEventosAgregadoId(anadirMeseroComand.EncargadoId);
            var encargadoId = EncargadoId.Of(Guid.Parse(anadirMeseroComand.EncargadoId));
            var meseroRealizado = encargadoCambiado.CrearAgregado(listaEventosDominio, encargadoId);



            var mesero = new Mesero(MeseroId.Of(Guid.NewGuid()));
            var datosPersonales = DatosPersonalesMesero.Crear(
                               anadirMeseroComand.Nombre
                    );
            var contrato = ContratoMesero.Crear(
                               anadirMeseroComand.TipoDeContrato
                    );

            meseroRealizado.SetDatosPersonalesMesero(datosPersonales);
            meseroRealizado.SetContratoMesero(contrato);
            
            List<EventoDominio> eventoDominios = meseroRealizado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            encargadoCambiado = new EncargadoCambiado();
            listaEventosDominio = await GetEventosAgregadoId(anadirMeseroComand.EncargadoId);
            meseroRealizado = encargadoCambiado.CrearAgregado(listaEventosDominio, encargadoId);

            return meseroRealizado;
        }

        public async Task<Encargado> AnadirBartender(AnadirBartenderComand anadirBartenderComand)
        {
            var encargadoCambiado = new EncargadoCambiado();
            var listaEventosDominio = await GetEventosAgregadoId(anadirBartenderComand.EncargadoId);
            var encargadoId = EncargadoId.Of(Guid.Parse(anadirBartenderComand.EncargadoId));
            var bartenderRealizado = encargadoCambiado.CrearAgregado(listaEventosDominio, encargadoId);



            var bartender = new Bartender(BartenderId.Of(Guid.NewGuid()));
            var datosPersonales = DatosPersonalesBartender.Crear(
                               anadirBartenderComand.Nombre
                    );
            var contrato = ContratoBartender.Crear(
                               anadirBartenderComand.TipoDeContrato
                    );

            bartenderRealizado.SetDatosPersonalesBartender(datosPersonales);
            bartenderRealizado.SetContratoBartender(contrato);

            List<EventoDominio> eventoDominios = bartenderRealizado.GetUnCommitChanges();
            await SaveEvents(eventoDominios);

            encargadoCambiado = new EncargadoCambiado();
            listaEventosDominio = await GetEventosAgregadoId(anadirBartenderComand.EncargadoId);
            bartenderRealizado = encargadoCambiado.CrearAgregado(listaEventosDominio, encargadoId);

            return bartenderRealizado;        

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
                    case EncargadoCreado encargadoCreado:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(encargadoCreado);
                        break;
                    case DatosPersonalesEncargadoAnadidos datosPersonalesAnadidos:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(datosPersonalesAnadidos);
                        break;
                    //meseroEve
                    case MeseroAnadido meseroAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(meseroAnadido);
                        break;
                    case DatosPersonalesMeseroAnadidos datosPersonalesMeseroAnadidos:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(datosPersonalesMeseroAnadidos);
                        break;
                    case ContratoAnadidoMesero contratoAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(contratoAnadido);
                        break;
                    //bartenderEve
                    case BartenderAnadido bartenderAnadido:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(bartenderAnadido);
                        break;
                    case DatosPersonalesBartenderAnadidos datosPersonalesBartenderAnadidos:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(datosPersonalesBartenderAnadidos);
                        break;
                    case ContratoAnadidoBartender contratoAnadidoBartender:
                        almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(contratoAnadidoBartender);
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
                string nombre = $"Cliente.Domain.Encargado.Eventos.{ev.Nombre}, Cliente.Domain";
                Type tipo = Type.GetType(nombre);
                EventoDominio eventoParseado = (EventoDominio)JsonConvert.DeserializeObject(ev.CuerpoEvento, tipo);
                return eventoParseado;

            }).ToList();


        }

     
    }
}
