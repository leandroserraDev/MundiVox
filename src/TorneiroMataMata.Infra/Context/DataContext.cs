using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.Infra.Context.Maps;

namespace TorneiroMataMata.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base("TorneioConnections")
        {

        }

        public DbSet<Grupo> Grupos{ get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new TimeMap());
            modelBuilder.Configurations.Add(new GrupoMap());

        }


    }
}
