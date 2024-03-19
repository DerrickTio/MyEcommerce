using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyEcommerce.Entities;

namespace MyEcommerce.EntityFrameworkCore
{
    public class MyEcommerceDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyEcommerceDbContext(DbContextOptions<MyEcommerceDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order> Order { get; set; }
    }
}
