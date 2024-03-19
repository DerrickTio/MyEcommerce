using Abp.Domain.Entities;

namespace MyEcommerce.Entities
{
    public class Inventory : Entity<int>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
    }
}
