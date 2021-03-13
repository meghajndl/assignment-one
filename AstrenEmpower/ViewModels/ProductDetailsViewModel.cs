using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AstrenEmpower.Models;

namespace AstrenEmpower.ViewModels
{
    public class ProductDetailsViewModel
    {
        public string pageTitle { get; set; }
        public int productsNum { get; set; }
        public ObservableCollection<Products> productDetails { get; set; }
        public int productsNumber { get; set; }

        public ProductDetailsViewModel()
        {
            pageTitle = "Shopping Cart";

            productDetails = new ObservableCollection<Products>()
            {
                new Products(){ productname = "Astren Earphones", productdescription = "The next-gen earphones" },
                new Products(){ productname = "Apple Earphones", productdescription = "The Best user experience earphones"},
                new Products(){ productname = "Samsung Earphones", productdescription = "The Future earphones" },
                new Products(){ productname = "Google Earphones", productdescription = "The Get your best earphones"},
                new Products(){ productname = "Boat Earphones", productdescription = "The coolest and stylish earphones" }

            };

            productsNumber = productDetails.Count;
        }
    }
}
