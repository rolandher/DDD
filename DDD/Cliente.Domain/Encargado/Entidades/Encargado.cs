using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.Eventos;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Entidades
{
    public class Encargado : AgregarEvento<EncargadoId>
    {
        public EncargadoId EncargadoId { get; init; }
        
        public DatosPersonalesEncargado DatosPersonalesEncargado { get; private set; }

        public virtual BartenderId Bartender { get; private set; }
        public virtual MeseroId Mesero { get; private set; }

        public Encargado(EncargadoId id) : base(id)
        {
            this.EncargadoId = EncargadoId;
        }

        public void SetEncargadoId(EncargadoId encargadoId)
        {
            AgregarCambios(new EncargadoCreado(encargadoId.ToString()));
        }

        public void SetDatoPersonalAnadido(DatosPersonalesEncargado datosPersonalesEncargado)
        {
            AgregarCambios(new DatosPersonalesAnadidos(datosPersonalesEncargado));
        }

        public void SetBartenderAnadido(BartenderId bartenderId)
        {
            AgregarCambios(new BartenderAnadido(bartenderId));
        }

        public void SetMeseroAnadido(MeseroId meseroId)
        {
            AgregarCambios(new MeseroAnadido(meseroId));
        }

        public void SetBartenderEliminado(BartenderId bartenderId)
        {
            AgregarCambios(new BartenderEliminado(bartenderId));
        }

        public void SetMeseroEliminado(MeseroId meseroId)
        {
            AgregarCambios(new MeseroEliminado(meseroId));
        }

       

        public void SetDatosPersonalesEncargado(DatosPersonalesEncargado datosPersonalesEncargado)
        {
            this.DatosPersonalesEncargado = datosPersonalesEncargado;
        }

        public void SetBartender(BartenderId bartenderId)
        {
            this.Bartender = bartenderId;
        }

        public void SetMesero(MeseroId meseroId)
        {
            this.Mesero = meseroId;
        }


       
       
    }
}
