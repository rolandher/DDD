using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Repositorio
{
    public interface IEncargadoRepositorio
    {
        Task <Entidades.Encargado> CrearEncargado(Entidades.Encargado encargado);

        Task anadirMesero(Guid meseroId, DatosPersonalesMesero datosPersonalesMesero, ContratoMesero contratoMesero);

        Task anadirBartender(Guid bartenderId, DatosPersonalesBartender datosPersonalesBartende, ContratoBartender contratoBartender);

        Task EliminarMesero(Guid meseroId);

        Task EliminarBartender(Guid bartenderId);


    }
}
