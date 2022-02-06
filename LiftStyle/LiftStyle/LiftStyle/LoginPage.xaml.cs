using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiftStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private async void Button_OnClicked_GoToFriendZonePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrindZonePage());
        }
     
        private void Button_OnClicked_GoToCreateAccountPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccountPage());
        }
        
        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        
    
        
    }
}