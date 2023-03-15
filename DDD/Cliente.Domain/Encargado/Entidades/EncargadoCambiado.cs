using Cliente.Domain.Encargado.Eventos;
using Cliente.Domain.Cliente.ValueObjects;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Entidades
{
    public class EncargadoCambiado
    {
        public Encargado CrearAgregado(List<EventoDominio> ev, EncargadoId encargadoId)
        {
            Encargado encargado = new(encargadoId);
            ev.ForEach(evento =>
            {
                switch (evento)
                {
                    case DatosPersonalesEncargadoAnadidos datosPersonalesAnadidos:
                        encargado.SetDatoPersonalAnadido(datosPersonalesAnadidos.DatosPersonalesEncargado);
                        break;
                        //mesero
                    case MeseroAnadido meseroAnadido:
                        encargado.SetMeseroAnadido(meseroAnadido.MeseroId);
                        break;
                    case DatosPersonalesMeseroAnadidos datosPersonalesMeseroAnadidos:
                        encargado.SetDatosPersonalesMesero(datosPersonalesMeseroAnadidos.DatosPersonalesMesero);
                        break;
                    case ContratoAnadidoMesero contratoAnadido:
                        encargado.SetContratoMesero(contratoAnadido.ContratoMesero);
                        break;
                        //Bartender
                    case BartenderAnadido bartenderAnadido:
                        encargado.SetBartenderAnadido(bartenderAnadido.BartenderId);
                        break;
                    case DatosPersonalesBartenderAnadidos datosPersonalesBartenderAnadidos:
                        encargado.SetDatosPersonalesBartender(datosPersonalesBartenderAnadidos.DatosPersonalesBartender);
                        break;
                    case ContratoAnadidoBartender contratoAnadidoBartender:
                        encargado.SetContratoBartender(contratoAnadidoBartender.ContratoBartender);
                        break;

                }

            });
            return encargado;
        }
    }
}
