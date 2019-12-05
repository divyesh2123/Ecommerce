using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataEntities.Models
{
    public class Product : DefaultModel
    {
        public string ProductName { get; set;}
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ApplicableDiscount { get; set; }
        public string Photo { get; set; }
        public int Status { get; set; }
        public ProductCatalog productCatalog { get; set; }
    }
}
