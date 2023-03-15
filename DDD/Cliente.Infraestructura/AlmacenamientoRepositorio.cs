using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Infraestructura
{
    public class AlmacenamientoRepositorio <T> : RepositoryBase<T>, IEventoRepositorio<T>  where T : class
    {

        private readonly DataBaseContext dataBaseContext;
        public AlmacenamientoRepositorio(DataBaseContext dbContext) : base(dbContext)
        {
            dataBaseContext = dbContext;
        }

        public async Task<List<AlmacenamientoEvento>> GetEventosAgregadoId(string agregadoId)
        {
            return dataBaseContext.AlmacenamientoEventos.Where(evento => evento.AgregadoId == agregadoId).ToList();

        }    

    }
}
