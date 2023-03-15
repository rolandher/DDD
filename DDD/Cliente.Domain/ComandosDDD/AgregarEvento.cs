using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.ComandosDDD
{
    public abstract class AgregarEvento<T> : Entidad<T> where T : Identidad
    {

        private EventoSuscribeC EventoSuscribeC = new();

        protected AgregarEvento(T entidadId) : base(entidadId) { }

        public List<EventoDominio> GetUnCommitChanges() => EventoSuscribeC.GetCambios().ToList();

        public void AgregarCambios(EventoDominio evento)
        {
            string nombreEvento = evento.GetType().Name;
            evento.SetAggregate(nombreEvento);
            evento.SetAggregateId(Identidad().Uuid.ToString());
            EventoSuscribeC.AgregarCambios(evento);
        }
        
    }
}
