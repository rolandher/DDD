using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Eventos
{
    public class ProductoAnadido : EventoDominio
    {
        public ValorProducto ValorProducto { get; set; }

        public ProductoAnadido(ValorProducto valorProducto) : base("valorproducto.creado")
        {
            ValorProducto = valorProducto;
        }
    }
}
