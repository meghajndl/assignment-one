﻿using System;
using System.Collections.Generic;
using AstrenEmpower.ViewModels;
using Xamarin.Forms;

namespace AstrenEmpower.Views
{
    public partial class RisePage : ContentPage
    {
        public RisePage()
        {
            BindingContext = new ProductDetailsViewModel();
            InitializeComponent();
        }
    }
}
