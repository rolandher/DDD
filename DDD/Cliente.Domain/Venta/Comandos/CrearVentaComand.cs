﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Venta.Comandos
{
    public class CrearVentaComand
    {
        public CrearVentaComand(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; init; }

    }

}
