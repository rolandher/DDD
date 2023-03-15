using Cliente.Domain.Generico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Infraestructura.Configuracion
{
    public class ConfiguracionEvento : IEntityTypeConfiguration<AlmacenamientoEvento>
    {
        public void Configure(EntityTypeBuilder<AlmacenamientoEvento> builder)
        {
            builder.ToTable("AlmacenamientoEvento");

            builder.HasKey(p => p.Id);
        }
    }
}
