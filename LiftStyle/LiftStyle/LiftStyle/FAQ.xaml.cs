using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiftStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQPage : ContentPage
    {
        public FAQPage()
        {
            InitializeComponent();
        }
        
        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        
        private void Button_OnClicked_FAQ1(object sender, EventArgs e)
        {
            DisplayAlert("Viewing a Workout", "To view a workout click the View button at the bottom of the main page, then select a save slot and click Update", "Thats Groovy!");
        }
        private void Button_OnClicked_FAQ2(object sender, EventArgs e)
        {
            DisplayAlert("Creating a Workout", "Select the create button on the main page then insert the workout info into their respective fields. Then select a save slot and click the Create button at the bottom of the page", "Thats Groovy!");
        }
        private void Button_OnClicked_FAQ3(object sender, EventArgs e)
        {
            DisplayAlert("Grody colors, bro", "They are the tradition colors of the VMI Keydets. Rahvahmil", "Thats Groovy!");
        }
        private void Button_OnClicked_FAQ4(object sender, EventArgs e)
        {
            DisplayAlert("Who made this?", "Riley Bowling, Carter Winfield, and OGA VPI Connor Phillips. All members of the VMI class of 2022. All three CIS students who, by the grace of god, graduated May 16th 2022", "Thats Groovy!");
        }
        
        
    }
}