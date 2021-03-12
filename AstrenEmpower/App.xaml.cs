using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AstrenEmpower.Services;
using AstrenEmpower.Views;
using System.Diagnostics;

namespace AstrenEmpower
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            MainPage = new NavigationPage(new WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void NavigationMain(String to)
        {
            MainPage = new MainPage();
            switch (to)
            {
                case "welcome":
                    MainPage = new NavigationPage(new WelcomePage());
                    break;
                case "afterLogin":
                    MainPage = new MainPage();
                    break;
                default:
                    Debug.WriteLine($"Error cannot find key {to}");
                    break;
            }
        }

    }
}
