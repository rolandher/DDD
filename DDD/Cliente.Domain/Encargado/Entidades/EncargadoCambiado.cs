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
                        encargado.SetDatosPersonalesEncargado(datosPersonalesAnadidos.DatosPersonalesEncargado);
                        break;
                        //mesero
                    case MeseroAnadido meseroAnadido:
                        encargado.SetMesero(meseroAnadido.Mesero);
                        break;
                    case DatosPersonalesMeseroAnadidos datosPersonalesMeseroAnadidos:
                        encargado.Mesero.SetDatosPersonalesMesero(datosPersonalesMeseroAnadidos.DatosPersonalesMesero);
                        break;
                    case ContratoAnadidoMesero contratoAnadido:
                        encargado.Mesero.SetContratoMesero(contratoAnadido.ContratoMesero);
                        break;
                        //Bartender
                    case BartenderAnadido bartenderAnadido:
                        encargado.SetBartender(bartenderAnadido.Bartender);
                        break;
                    case DatosPersonalesBartenderAnadidos datosPersonalesBartenderAnadidos:
                        encargado.Bartender.SetDatosPersonalesBartender(datosPersonalesBartenderAnadidos.DatosPersonalesBartender);
                        break;
                    case ContratoAnadidoBartender contratoAnadidoBartender:
                        encargado.Bartender.SetContratoBartender(contratoAnadidoBartender.ContratoBartender);
                        break;

                }

            });
            return encargado;
        }
    }
}
