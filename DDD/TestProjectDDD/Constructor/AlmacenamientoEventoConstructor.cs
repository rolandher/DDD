using Cliente.Domain.Cliente.Entidades;
using Cliente.Domain.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDDD.Constructor
{
    internal class AlmacenamientoEventoConstructor
    {
        private int Id;
        private string Nombre;
        private string AgregadoId;
        private string CuerpoEvento;

     

        public AlmacenamientoEventoConstructor WithStoredId(int id)
        {
            Id = id;
            return this;
        }

        public AlmacenamientoEventoConstructor WithStoredName(string nombre)
        {
            Nombre = nombre;
            return this;
        }

        public AlmacenamientoEventoConstructor WithAggregateId(string agregadoId)
        {
            AgregadoId = agregadoId;
            return this;
        }

        public AlmacenamientoEventoConstructor WithEventBody(string cuerpoEvento)
        {
            CuerpoEvento = cuerpoEvento;
            return this;
        }

        public AlmacenamientoEvento Build()
        {
            return new AlmacenamientoEvento(Id, Nombre, AgregadoId, CuerpoEvento);
        }
       
        
    }
}
