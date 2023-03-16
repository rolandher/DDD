using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class DescripcionAnadida : EventoDominio
    {
        public DescripcionDelProducto DescripcionDelProducto { get; set; }

        public DescripcionAnadida(DescripcionDelProducto descripcionDelProducto) : base("descripcionproducto.creado")
        {
            DescripcionDelProducto = descripcionDelProducto;
        }

    }
}
