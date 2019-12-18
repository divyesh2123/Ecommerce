using ECommerce.DataEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Transactions;

namespace ECommerce.DataAccess
{
    public class BaseRepository<T>
    {
        protected static DbContext dbContext;
       
        public virtual void AddEntity(T item)
        {
            //using (var transactionScope = new TransactionScope())
            //{
            //    var builder = new DbContextOptionsBuilder<ECommerceContext>();
            //    builder.UseSqlServer("Server=DSK-806\\SQL2017;Database=ECommerceDB;Trusted_Connection=True;");
            //    using (var context = new ECommerceContext(builder.Options))
            //    {
            //        context.Entry(item).State = EntityState.Added;
            //        context.SaveChanges();
            //    }
            //    transactionScope.Complete();
            //}
        }
    }
}
