using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataEntities.Models
{
    public class OrderDetail : DefaultModel
    {
        public ProductCatalog productCatalog { get; set; }
        public Product products { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public Decimal Price { get; set; }
        public Decimal Discount { get; set; }
        public Decimal TotalPrice { get; set; }

    }
}
