using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module3_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.form.IsVisible = false;
            this.tweets.IsVisible = true;
        }
        private void Connection_Clicked(object sender, EventArgs e) { 
            Console.WriteLine("Connection is clicked");
            String identifierStr = this.identifier.Text;
            String passwordStr = this.password.Text;
            Boolean isRemember = this.remember.IsToggled;
            this.error.IsVisible = false;

            if (String.IsNullOrEmpty(identifierStr) || identifierStr.Length < 3) {
                this.error.Text = "Veuillez entrer un identifiant d'au moins 3 caractères";
                this.error.IsVisible = true;
                return;
            }

            if (String.IsNullOrEmpty(passwordStr) || passwordStr.Length < 6) {
                this.error.Text = "Veuillez entrer un mot de passe d'au moins 6 caractères";
                this.error.IsVisible = true;
                return;
            }
        }
    }
}
