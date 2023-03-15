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
    //public class EncargadoCasoDeUso : ICasodeUsoEncargado
    //{
    //    private readonly IEventoRepositorio<AlmacenamientoEvento> _eventoRepositorio;

    //    public EncargadoCasoDeUso(IEventoRepositorio<AlmacenamientoEvento> eventoRepositorio)
    //    {
    //        _eventoRepositorio = eventoRepositorio;
    //    }

    //    public async Task<Encargado> CrearEncargado(CrearEncargadoComand crearEncargadoComand)
    //    {
    //        var encargado = new Encargado(EncargadoId.Of(Guid.NewGuid()));
    //        encargado.SetEncargadoId(encargado.EncargadoId);
    //        var datosPersonales = DatosPersonalesEncargado.Crear(
    //            crearEncargadoComand.Nombre,
    //            crearEncargadoComand.Sexo,
    //            crearEncargadoComand.Edad
    //            );

    //        encargado.SetDatoPersonalAnadido(datosPersonales);
    //        List<EventoDominio> eventoDominios = encargado.GetUnCommitChanges();
    //        await SaveEvents(eventoDominios);

    //        var encargadoCambiado = new EncargadoCambiado();
    //        encargado = encargadoCambiado.CrearAgregado(eventoDominios, encargado.EncargadoId);
    //        return encargado;
    //    }


    //    public async Task<Mesero> AnadirMesero(AnadirMeseroComand anadirMeseroComand)
    //    {
    //        var meseroAnadido = new EncargadoCambiado();
    //        var listaEventosDominio = await GetEventosAgregadoId(anadirMeseroComand.MeseroId);
    //        var encargadoId = EncargadoId.Of(Guid.Parse(anadirMeseroComand.MeseroId));
    //        var meseroSolicitado = meseroAnadido.CrearAgregado(listaEventosDominio, encargadoId);


    //        var mesero = new Mesero(MeseroId.Of(Guid.NewGuid()));

    //        var datosPersonales = DatosPersonalesMesero.Crear(
    //            anadirMeseroComand.MeseroId                         
    //            ); 
    //        var contrato = ContratoMesero.Crear(
    //            anadirMeseroComand.TipoDeContrato
    //            );

    //        meseroSolicitado.SetMeseroAnadido(mesero.MeseroId);
    //        List<EventoDominio> eventoDominios = meseroSolicitado.GetUnCommitChanges();
    //        await SaveEvents(eventoDominios);

    //        meseroAnadido = new EncargadoCambiado();
    //        listaEventosDominio = await GetEventosAgregadoId(anadirMeseroComand.MeseroId);
    //        meseroSolicitado = meseroAnadido.CrearAgregado(listaEventosDominio, encargadoId);
    //        return mesero;
    //    }

        //public async Task<Mesero> EliminarMesero(EliminarMeseroComand eliminarMeseroComand)
        //{
        //    var meseroEliminado = new EncargadoCambiado();
        //    var listaEventosDominio = await GetEventosAgregadoId(eliminarMeseroComand.MeseroId);
        //    var encargadoId = EncargadoId.Of(Guid.Parse(eliminarMeseroComand.MeseroId));
        //    var meseroSolicitado = meseroEliminado.CrearAgregado(listaEventosDominio, encargadoId);


        //    meseroSolicitado.SetMeseroEliminado(eliminarMeseroComand.MeseroId);
        //    List<EventoDominio> eventoDominios = meseroSolicitado.GetUnCommitChanges();
        //    await SaveEvents(eventoDominios);
        //    var mesero = meseroEliminado.CrearAgregado(eventoDominios, encargadoId);
        //    return mesero;
        //}

        

        //public async Task<Encargado> AnadirBartender(AnadirBartenderComand anadirBartenderComand)
        //{
        //    var encargadoCambiado = new EncargadoCambiado();
        //    var listaEventosDominio = await GetEventosAgregadoId(anadirBartenderComand.);
        //    var encargadoId = EncargadoId.Of(Guid.Parse(anadirBartenderComand.EncargadoId));
        //    var bartenderSolicitado = encargadoCambiado.CrearAgregado(listaEventosDominio, encargadoId);
        //    bartenderSolicitado.SetBartenderAnadido(anadirBartenderComand.BartenderId);
        //    List<EventoDominio> eventoDominios = bartenderSolicitado.GetUnCommitChanges();
        //    await SaveEvents(eventoDominios);
        //    var encargado = encargadoCambiado.CrearAgregado(eventoDominios, encargadoId);
        //    return encargado;
        //}

        //public async Task<Encargado> EliminarBartender(EliminarBartenderComand eliminarBartenderComand)
        //{
        //    var encargadoCambiado = new EncargadoCambiado();
        //    var listaEventosDominio = await GetEventosAgregadoId(eliminarBartenderComand.EncargadoId);
        //    var encargadoId = EncargadoId.Of(Guid.Parse(eliminarBartenderComand.EncargadoId));
        //    var bartenderSolicitado = encargadoCambiado.CrearAgregado(listaEventosDominio, encargadoId);
        //    bartenderSolicitado.SetBartenderEliminado(eliminarBartenderComand.BartenderId);
        //    List<EventoDominio> eventoDominios = bartenderSolicitado.GetUnCommitChanges();
        //    await SaveEvents(eventoDominios);
        //    var encargado = encargadoCambiado.CrearAgregado(eventoDominios, encargadoId);
        //    return encargado;
        //}


    //    private async Task SaveEvents(List<EventoDominio> list)
    //    {
    //        var array = list.ToArray();
    //        for (var index = 0; index < array.Length; index++)
    //        {
    //            var almacenamiento = new AlmacenamientoEvento();
    //            almacenamiento.AgregadoId = array[index].GetAggregateId();
    //            almacenamiento.Nombre = array[index].GetAggregate();
    //            switch (array[index])
    //            {
    //                case EncargadoCreado encargadoCreado:
    //                    almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(encargadoCreado);
    //                    break;
    //                case DatosPersonalesAnadidos datosPersonalesAnadidos:
    //                    almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(datosPersonalesAnadidos);
    //                    break;
    //                case MeseroAnadido meseroAnadido:
    //                    almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(meseroAnadido);
    //                    break;
    //                case MeseroEliminado meseroEliminado:
    //                    almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(meseroEliminado);
    //                    break;
    //                case BartenderAnadido bartenderAnadido:
    //                    almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(bartenderAnadido);
    //                    break;
    //                case BartenderEliminado bartenderEliminado:
    //                    almacenamiento.CuerpoEvento = JsonConvert.SerializeObject(bartenderEliminado);
    //                    break;

    //            }
    //            await _eventoRepositorio.AddAsync(almacenamiento);

    //        }

    //        await _eventoRepositorio.SaveChangesAsync();

    //    }

    //    private async Task<List<EventoDominio>> GetEventosAgregadoId(string aggregateId)
    //    {
    //        var listadoEventos = await _eventoRepositorio.GetEventosAgregadoId(aggregateId);

    //        if (listadoEventos == null)
    //            throw new ArgumentException("No existe el Id del agregado en la base de datos");

    //        return listadoEventos.Select(ev =>
    //        {
    //            string nombre = $"Cliente.Domain.Encargado.Eventos.{ev.Nombre}, Cliente.Domain";
    //            Type tipo = Type.GetType(nombre);
    //            EventoDominio eventoParseado = (EventoDominio)JsonConvert.DeserializeObject(ev.CuerpoEvento, tipo);
    //            return eventoParseado;

    //        }).ToList();


    //    }       

    //    Task<Mesero> ICasodeUsoEncargado.EliminarMesero(EliminarMeseroComand eliminarMeseroComand)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Task<Bartender> ICasodeUsoEncargado.AnadirBartender(AnadirBartenderComand anadirBartenderComand)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Task<Bartender> ICasodeUsoEncargado.EliminarBartender(EliminarBartenderComand eliminarBartenderComand)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
