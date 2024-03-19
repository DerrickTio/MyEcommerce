using MyEcommerce.Configuration;
using MyEcommerce.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyEcommerce.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyEcommerceDbContextFactory : IDesignTimeDbContextFactory<MyEcommerceDbContext>
    {
        public MyEcommerceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyEcommerceDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyEcommerceConsts.ConnectionStringName)
            );

            return new MyEcommerceDbContext(builder.Options);
        }
    }
}