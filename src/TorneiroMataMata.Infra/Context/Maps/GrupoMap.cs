using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;

namespace TorneiroMataMata.Infra.Context.Maps
{
    public class GrupoMap : EntityTypeConfiguration<Grupo>
    {
        public GrupoMap()
        {
            ToTable("Grupo");
            HasKey(x => x.GrupoId);

            Property(x => x.Nome)
               .HasColumnType("varchar")
               .HasMaxLength(20)
               .IsRequired();

            Property(x => x.Descricao)
               .HasColumnType("varchar")
               .HasMaxLength(20)
               .IsRequired();

        }
    }
}
