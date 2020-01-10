using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;

namespace TorneiroMataMata.Infra.Context.Maps
{
    public class TimeMap : EntityTypeConfiguration<Time>
    {
        public TimeMap()
        {
            ToTable("Time");
            HasKey(x => x.TimeId);

            Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Gol)
               .IsRequired();

            Property(x => x.SaldoGols)
               .IsRequired();

            HasRequired(x => x.Grupo).WithMany(x => x.Times);

        }
    }
}
