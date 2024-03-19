using Abp.Domain.Entities;

namespace MyEcommerce.Entities
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
    }
}
