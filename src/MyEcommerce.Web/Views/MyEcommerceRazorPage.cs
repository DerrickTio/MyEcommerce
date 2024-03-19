using Abp.AspNetCore.Mvc.Views;

namespace MyEcommerce.Web.Views
{
    public abstract class MyEcommerceRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyEcommerceRazorPage()
        {
            LocalizationSourceName = MyEcommerceConsts.LocalizationSourceName;
        }
    }
}
