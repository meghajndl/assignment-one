using System;
using System.Collections.Generic;
using AstrenEmpower.ViewModels;
using Xamarin.Forms;

namespace AstrenEmpower.Views
{
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage()
        {
            BindingContext = new ProductDetailsViewModel();
            InitializeComponent();
        }
    }
}
