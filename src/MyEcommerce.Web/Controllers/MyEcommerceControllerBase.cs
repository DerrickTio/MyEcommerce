using Abp.AspNetCore.Mvc.Controllers;

namespace MyEcommerce.Web.Controllers
{
    public abstract class MyEcommerceControllerBase: AbpController
    {
        protected MyEcommerceControllerBase()
        {
            LocalizationSourceName = MyEcommerceConsts.LocalizationSourceName;
        }
    }
}