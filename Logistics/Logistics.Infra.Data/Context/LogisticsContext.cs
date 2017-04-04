
using Logistics.Domain.Entities;
using System.Data.Entity;

namespace Logistics.Infra.Data.Context
{
    public class LogisticsContext : DbContext
    {
        public LogisticsContext() : base("LogisticsContext")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
