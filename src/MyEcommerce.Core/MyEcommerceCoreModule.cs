using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEcommerce.Localization;

namespace MyEcommerce
{
    public class MyEcommerceCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyEcommerceLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = MyEcommerceConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceCoreModule).GetAssembly());
        }
    }
}