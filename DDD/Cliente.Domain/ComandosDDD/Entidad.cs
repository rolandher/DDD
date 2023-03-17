﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.ComandosDDD
{
    public class Entidad<T> where T : Identidad
    {
        protected T entidadId;

        public Entidad(T entidadId)
        {
            this.entidadId = entidadId;
        }

        public T Identidad() => entidadId;
    }
}