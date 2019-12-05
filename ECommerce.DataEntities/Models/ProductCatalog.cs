using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataEntities.Models
{
    public class ProductCatalog : DefaultModel
    {
        public ProductCatalog()
        {
            this.Products = new List<Product>();
        }
        public string CatalogName { get; set;}

        public ICollection<Product> Products { get; set; }

    }
}
