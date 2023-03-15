using Ardalis.Specification;
using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.CasoDeUso.PuertaEnlace
{
    public interface IEventoRepositorio<T> : IRepositoryBase<T> where T : class
    {
        Task<List<AlmacenamientoEvento>>GetEventosAgregadoId(string agregadoId);
    }   

    
}
