using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.BusinessEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.ProductCatalog
{
    public class AddModel : PageModel
    {
        public void OnGet()
        {
            var productCatalogViewModel = new ProductCatalogViewModel();
            productCatalogViewModel.CatalogName = "aa";
            this.productCatalogViewModel = productCatalogViewModel;
        }

        public void OnPost(ProductCatalogViewModel productCatalogViewModel)
        {
           // ViewData["welcome"] = $"Welcome {Login.Email}";
        }

        [BindProperty]
        public ProductCatalogViewModel productCatalogViewModel { get; set; }
    }
}