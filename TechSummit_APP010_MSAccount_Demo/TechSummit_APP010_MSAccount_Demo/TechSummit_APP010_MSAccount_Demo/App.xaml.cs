using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Identity.Client;

namespace TechSummit_APP010_MSAccount_Demo
{
    public partial class App : Application
    {
        public static PublicClientApplication PCA = null;
        public static string[] Scopes = { "User.Read" };
        private static string clientID = "";

        public App()
        {
            InitializeComponent();

            PCA = new PublicClientApplication(clientID);

            MainPage = new TechSummit_APP010_MSAccount_Demo.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
