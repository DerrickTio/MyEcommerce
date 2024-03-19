using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyEcommerce.EntityFrameworkCore;
using MyEcommerce.Tests.TestDatas;

namespace MyEcommerce.Tests
{
    public class MyEcommerceTestBase : AbpIntegratedTestBase<MyEcommerceTestModule>
    {
        public MyEcommerceTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyEcommerceDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyEcommerceDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyEcommerceDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyEcommerceDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyEcommerceDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyEcommerceDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyEcommerceDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyEcommerceDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
