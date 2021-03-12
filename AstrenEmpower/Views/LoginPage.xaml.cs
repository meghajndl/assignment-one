using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace AstrenEmpower.Views
{
    public partial class LoginPage : ContentPage
    {
        private App MyApp = Application.Current as App;
        public LoginPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Debug.WriteLine("Please Log in");

            var username = usernameFld.Text.ToLower();
            var password = passwordFld.Text.ToLower();

            Debug.WriteLine($"You entered username:{username} and password: { password}");

            if (username == "astrenempower@gmail.com" && password == "ast123")
            {
                proceedToLogin();
                statusFld.TextColor = Color.Green;
                statusFld.Text = $"Success Login";
            }
            else
            {
                statusFld.TextColor = Color.Red;
                statusFld.Text = $"Incorrect username / password";

            }
        }

        void proceedToLogin()
        {
            Debug.WriteLine($"Proceed With Login");
            MyApp.NavigationMain("afterLogin"); 
        }
    }
}
