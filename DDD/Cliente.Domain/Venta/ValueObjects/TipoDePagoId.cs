using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.ValueObjects
{
    public record TipoDePagoId
    {

        public Guid Value { get; init; }

        public TipoDePagoId(Guid value)
        {
            Value = value;
        }

        public static TipoDePagoId Crear(Guid value)
        {
            return new TipoDePagoId(value);
        }              
        public static implicit operator Guid (TipoDePagoId tipoDePagoId)
        {
            return tipoDePagoId.Value;
        }
    }   
 }

