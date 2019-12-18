using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BusinessEntities
{
    public class ProductCatalogViewModel
    {
        public ProductCatalogViewModel()
        {
            this.ProductViewModels = new List<ProductViewModel>();
        }
        public string CatalogName { get; set; }

        public ICollection<ProductViewModel> ProductViewModels { get; set; }
    }
}
