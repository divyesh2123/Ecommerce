using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataEntities
{
    public class ContextFactory : IDesignTimeDbContextFactory<ECommerceContext>
    {
        public ECommerceContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ECommerceContext>();

            builder.UseSqlServer("Server=DSK-806\\SQL2017;Database=ECommerceDB;Trusted_Connection=True;");

            return new ECommerceContext(builder.Options);
        }
    }
}
