using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce.Entities
{
    public class Order : Entity<Guid>
    {
        public int ProductId { get; set; }
        public string OrderNumber { get; set; }
        public int Quantity { get; set; }
        public decimal OrderAmount { get; set; }
        public virtual Product Product { get; set; }
    }

}
