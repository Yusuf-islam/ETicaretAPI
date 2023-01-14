using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Context
{
    public class ETicaretAPIDbContext:DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişikliklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir.Track edilen verileri yakalayıp elde etmemizi sağlar.

           var datas =  ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            { 
                #region Switch-Case'in farklı bir yapısı
                _ = data.State switch//alt-tire kullanımı , burdaki çıktıyı ben bir yere atamayacağım demek oluyor.
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow,
                    EntityState.Unchanged => data.Entity.UpdateDate = data.Entity.UpdateDate//herhangi bir değişiklik olmadığında hata vermemesi için bunu yazdım
                };
                #endregion
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
