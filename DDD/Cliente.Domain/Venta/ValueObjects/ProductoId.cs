using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public record ProductoId
    {
        public Guid Value { get; init; }

        public ProductoId(Guid value)
        {
            Value = value;
        }

        public static ProductoId Crear(Guid value)
        {
            return new ProductoId(value);
        }
        public static implicit operator Guid(ProductoId productoId)
        {
            return productoId.Value;
        }
    }
}
