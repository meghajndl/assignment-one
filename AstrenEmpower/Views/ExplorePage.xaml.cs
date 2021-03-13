using System;
using System.Collections.Generic;
using AstrenEmpower.ViewModels;
using Xamarin.Forms;

namespace AstrenEmpower.Views
{
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            BindingContext = new ProductDetailsViewModel();
        }
    }
}
