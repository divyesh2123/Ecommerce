using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataEntities.Models
{
    public class Order : DefaultModel
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Decimal TotalDiscount  { get; set; }
        public Decimal TotalAmount { get; set; }
        public int OrderStatus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
