using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public record VentaId
    {
    public Guid Value { get; init; }

    public VentaId(Guid value)
        {
           Value = value;
        }

    public static VentaId Crear(Guid value)
        {
           return new VentaId(value);
        }
    public static implicit operator Guid(VentaId ventaId)
        {
           return ventaId.Value;
        }
    }
}
