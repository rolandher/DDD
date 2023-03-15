using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Entidades
{
    public class Bartender : AgregarEvento<BartenderId>
    {
        //variables
        public BartenderId BartenderId { get; private set; }

        public DatosPersonalesBartender DatosPersonalesBartender { get; private set; }

        public ContratoBartender ContratoBartender { get; private set; }

        public Bartender(BartenderId id) : base(id)
        {

        }

       
       public void SetDatosPersonalesBartender(DatosPersonalesBartender datosPersonalesBartender)
        {
            DatosPersonalesBartender = datosPersonalesBartender;
        }

        public void SetContratoBartender(ContratoBartender contratoBartender)
        {
            ContratoBartender = contratoBartender;
        }
    }
}
