using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyEcommerce.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyEcommerceCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyEcommerceEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceEntityFrameworkCoreModule).GetAssembly());
        }
    }
}