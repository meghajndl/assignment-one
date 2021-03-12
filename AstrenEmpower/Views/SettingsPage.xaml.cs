using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AstrenEmpower.Views
{
    public partial class SettingsPage : ContentPage
    {
        private App myApp = Application.Current as App;
        public SettingsPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            myApp.NavigationMain("welcome"); 
        }
    }
}
