using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Encargado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.CasoDeUso.PuertaEnlace
{
    public interface ICasodeUsoEncargado
    {
        Task<Encargado> CrearEncargado(CrearEncargadoComand crearEncargadoComand);
        Task<Encargado> AnadirMesero(AnadirMeseroComand anadirMeseroComand);
       
        Task<Encargado> AnadirBartender(AnadirBartenderComand anadirBartenderComand);        
     
    }
}
