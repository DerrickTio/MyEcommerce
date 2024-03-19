using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEcommerce.Configuration;
using MyEcommerce.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MyEcommerce.Web.Startup
{
    [DependsOn(
        typeof(MyEcommerceApplicationModule), 
        typeof(MyEcommerceEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyEcommerceWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyEcommerceWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyEcommerceConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyEcommerceNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyEcommerceApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyEcommerceWebModule).Assembly);
        }
    }
}
