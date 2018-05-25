using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WebApplication2.Entities;

namespace WebApplication2
{
    public class MyDatabase:DbContext
    {
        public MyDatabase():base("name:InsightEntities")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
            //(this as IObjectContextAdapter).ObjectContext.CommandTimeout = 240;
        }

        public DbSet<TokenTest> TokenTest { get; set; }
    }
}