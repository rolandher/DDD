using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.ComandosDDD
{
    public class EventoSuscribeC
    {
        private List<EventoDominio> Cambios = new List<EventoDominio>();

        public List <EventoDominio> GetCambios() => Cambios;

        public void AgregarCambios(EventoDominio eventoDominio)
        {
            this.Cambios.Add(eventoDominio);
        }
    }
}
