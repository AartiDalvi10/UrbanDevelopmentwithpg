using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace UrbanDevelopmentProj.Models
{
    public class MyWebApiContextFactory : IDesignTimeDbContextFactory<MyWebApiContext>
    {
        public MyWebApiContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyWebApiContext>();
            optionsBuilder.UseNpgsql(@"Server=http://postgresql-amosds-aws-01-syntbots-for-cloud.apps02-london.amosdemo.io;User ID=Syntel;Password=Syntel123$;Port=5432;Database=UrbanDevelopmentDB;Integrated Security=true;Pooling=true;");

            return new MyWebApiContext(optionsBuilder.Options);
        }
    }
}
