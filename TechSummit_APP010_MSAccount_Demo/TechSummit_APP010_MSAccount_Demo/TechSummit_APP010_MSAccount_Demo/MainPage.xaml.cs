using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using System.Net.Http.Headers;

namespace TechSummit_APP010_MSAccount_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSingIn_Clicked(object sender, EventArgs e)
        {
            var graph = new GraphServiceClient(
                "https://graph.microsoft.com/v1.0",
                new DelegateAuthenticationProvider(
                    async (reqest) =>
                    {
                        AuthenticationResult ar = await App.PCA.AcquireTokenAsync(App.Scopes);
                        reqest.Headers.Authorization = new AuthenticationHeaderValue("bearer", ar.Token);
                    }
                ));
            var user = await graph.Me.Request().GetAsync();

            lblDisplayName.Text = user.DisplayName;
            lblPrincipalName.Text = user.UserPrincipalName;
        }

        private void btnSingOut_Clicked(object sender, EventArgs e)
        {
            foreach (var user in App.PCA.Users)
            {
                user.SignOut();
            }
            lblDisplayName.Text = string.Empty;
            lblPrincipalName.Text = string.Empty;
        }
    }
}
