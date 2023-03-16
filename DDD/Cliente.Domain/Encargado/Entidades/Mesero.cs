using Cliente.Domain.Cliente.Comandos;
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
    public class Mesero : Entidad<MeseroId>
    {
        //variables
        public MeseroId MeseroId { get; private set; }

        public DatosPersonalesMesero DatosPersonalesMesero { get; private set; }

        public ContratoMesero ContratoMesero { get; private set; }

        public Mesero(MeseroId id) : base(id)
        {
           
        }
        
        public void SetDatosPersonalesMesero(DatosPersonalesMesero datosPersonalesMesero)
        {
            DatosPersonalesMesero = datosPersonalesMesero;
        }

        public void SetContratoMesero(ContratoMesero contratoMesero)
        {
            ContratoMesero = contratoMesero;
        }

    }
}
