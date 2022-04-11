using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace LiftStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }
     
        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
            
        }

        private void Button_OnClicked_IncompleteAlert(object sender, EventArgs e)
        {
            DisplayAlert("ALERT!", "There should be implementation for account creation in this alert's stead.", "Check, Rog");
        }

        
    }
}