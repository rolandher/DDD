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
                    case DatosPersonalesAnadidos datosPersonalesAnadidos:
                        encargado.SetDatoPersonalAnadido(datosPersonalesAnadidos.DatosPersonalesEncargado);
                        break;

                    case MeseroAnadido meseroAnadido:
                        encargado.SetMeseroAnadido(meseroAnadido.MeseroId);
                        break;                    
                    case BartenderAnadido bartenderAnadido:
                        encargado.SetBartenderAnadido(bartenderAnadido.BartenderId);
                        break;                   
                }

            });
            return encargado;
        }
    }
}
