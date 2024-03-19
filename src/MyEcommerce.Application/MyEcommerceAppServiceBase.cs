using Abp.Application.Services;

namespace MyEcommerce
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyEcommerceAppServiceBase : ApplicationService
    {
        protected MyEcommerceAppServiceBase()
        {
            LocalizationSourceName = MyEcommerceConsts.LocalizationSourceName;
        }
    }
}