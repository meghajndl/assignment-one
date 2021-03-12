using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AstrenEmpower.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new LoginPage());
        }
    }
}
