using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication1.Models
{
    public class NumberContext : DbContext
    {
        static NumberContext()
        {
            Database.SetInitializer(new NumberDbInitializer());
        }
        public DbSet<Number> Numbers { get; set; }
    }
}