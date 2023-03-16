using Cliente.Domain.ComandosDDD;
using Cliente.Domain.Venta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Entidades
{
    public class Producto : Entidad<ProductoId>
    {
        //variables
        public ProductoId ProductoId { get; private set; }

        public ValorProducto ValorProducto { get; private set; }

        public Producto(ProductoId id) : base(id)
        {

        }

        public void SetValorProducto(ValorProducto valorProducto)
        {
            ValorProducto = valorProducto;
        }

    }

}
