using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEcommerce.Web.Startup;
namespace MyEcommerce.Web.Tests
{
    [DependsOn(
        typeof(MyEcommerceWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyEcommerceWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceWebTestModule).GetAssembly());
        }
    }
}