using Module3_Demo.Entities;
using Module3_Demo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Module3_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService;

        public MainPage()
        {
            InitializeComponent();
            this.form.IsVisible = false;
            this.tweets.IsVisible = true;
            this.twitterService = new TwitterServiceImpl();
        }
        private void Connection_Clicked(object sender, EventArgs e) { 
            Console.WriteLine("Connection is clicked");
            String login = this.identifier.Text;
            String password = this.password.Text;
            Boolean isRemind = this.remember.IsToggled;

            String errors = "";

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            { 
                errors = this.twitterService.Authenticate(new User() { Login = login, Password = password });
            }
            else
            {
                errors = "Pas de connexion internet disponible.";
            }

            if (!String.IsNullOrEmpty(errors))
            {
                this.errorLabel.Text = errors;
                this.errorLabel.IsVisible = true;
            }
            else
            {
                this.errorLabel.Text = "";
                this.errorLabel.IsVisible = false;
                this.form.IsVisible = false;
            }
        }
    }
}
