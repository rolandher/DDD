﻿
using System.Text.Json.Serialization;

namespace Cliente.Domain.Cliente.ValueObjects
{
    public class MetodosDePago
    {
        public int TarjetaCredito { get; set; }

        
        public MetodosDePago(int tarjetaCredito)
        {
           this.TarjetaCredito = tarjetaCredito;
        }

        public void SetTarjetaCredito(int tarjetacredito)
        {
            TarjetaCredito = tarjetacredito;
        }

        public static MetodosDePago Crear(int tarjetaCredito)
        {
            Validar(tarjetaCredito);
            return new MetodosDePago(tarjetaCredito);
        }
        public static void Validar(int tarjetaCredito)
        {           
            if (tarjetaCredito == null)
            {
                throw new ArgumentNullException("El valor no puede estar vacio");
            }

        }

    }

}
