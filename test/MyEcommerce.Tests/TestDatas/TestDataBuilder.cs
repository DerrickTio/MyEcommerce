using MyEcommerce.EntityFrameworkCore;

namespace MyEcommerce.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyEcommerceDbContext _context;

        public TestDataBuilder(MyEcommerceDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}