using Cliente.Domain.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDDD.Constructor
{
    internal class AlmacenamientoEventoConstructor
    {
        private int _id;
        private string _nombre;
        private string _agregadoId;
        private string _cuerpoEvento;

        public AlmacenamientoEventoConstructor WithStoredId(int id)
        {
            _id = id;
            return this;
        }

        public AlmacenamientoEventoConstructor WithStoredName(string nombre)
        {
            _nombre = nombre;
            return this;
        }

        public AlmacenamientoEventoConstructor WithAggregateId(string agregadoId)
        {
            _agregadoId = agregadoId;
            return this;
        }

        public AlmacenamientoEventoConstructor WithEventBody(string cuerpoEvento)
        {
            _cuerpoEvento = cuerpoEvento;
            return this;
        }
      
    }
}
