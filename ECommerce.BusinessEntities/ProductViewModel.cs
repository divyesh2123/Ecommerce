using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BusinessEntities
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ApplicableDiscount { get; set; }
        public string Photo { get; set; }
        public int Status { get; set; }
        public ProductCatalogViewModel productCatalog { get; set; }
    }
}
