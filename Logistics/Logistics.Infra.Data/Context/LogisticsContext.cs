using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Infra.Data.Context
{
    public class LogisticsContext : DbContext
    {
        public LogisticsContext() : base("Name=LogisticsContext")
        {
            //todo - comentario 1
            //Comentario do Moura
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
