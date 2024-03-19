using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyEcommerce
{
    [DependsOn(
        typeof(MyEcommerceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyEcommerceApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceApplicationModule).GetAssembly());
        }
    }
}