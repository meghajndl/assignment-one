using System;
using System.Collections.Generic;
using AstrenEmpower.Models;

namespace AstrenEmpower.ViewModels
{
    public class ProductDetailsViewModel
    {
        public string pageTitle { get; set; }
        public Products[] products { get; set; }
        public List<Products> productsList { get; set; }
        public int productsNum { get; set; } 

        public ProductDetailsViewModel()
        {
            pageTitle = "Shopping Cart";

            productsList = new List<Products>();

            productsList.Add(new Products { productname = "Astren Earphones", productdescription = "The next-gen earphones" });
            productsList.Add(new Products { productname = "Apple Earphones", productdescription = "The Best user experience earphones" });
            productsList.Add(new Products { productname = "Samsung Earphones", productdescription = "The Future earphones" });
            productsList.Add(new Products { productname = "Google Earphones", productdescription = "The Get your best earphones" });
            productsList.Add(new Products { productname = "Boat Earphones", productdescription = "The coolest and stylish earphones" });

            productsNum = productsList.Count;
        }
    }
}
