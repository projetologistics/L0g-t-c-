using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Infra.Data.Context
{
  
    public class LogisticsContext
    {
            base.OnModelCreating(modelBuilder);
        }
        //TODO - IMPLEMENTAR
        public LogisticsContext() : base("Name=LogisticsContext")
        {

        }
    }
}
