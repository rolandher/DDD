using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Encargado.Entidades;
using Cliente.Domain.Encargado.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Encargado.Eventos
{
    public class MeseroAnadido : EventoDominio
    {
        public Mesero Mesero { get; set; }

        public MeseroAnadido(Mesero mesero) : base("Mesero.anadido")
        {
            Mesero = mesero;
        }
    }
}
