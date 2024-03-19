using Microsoft.EntityFrameworkCore;

namespace MyEcommerce.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyEcommerceDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyEcommerceDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
