using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Cliente.Domain.Generico
{
    public class AlmacenamientoEvento
    {
        public AlmacenamientoEvento(int id, string nombre, string agregadoId, string cuerpoEvento)
        {
            Id = id;
            Nombre = nombre;
            AgregadoId = agregadoId;
            CuerpoEvento = cuerpoEvento;
        }
        public AlmacenamientoEvento()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string AgregadoId { get; set; }

        public string CuerpoEvento { get; set; }

       
    }





}
