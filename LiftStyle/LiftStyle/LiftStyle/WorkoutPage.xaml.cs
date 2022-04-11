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
    public partial class WorkoutPage : ContentPage
    {
        public WorkoutPage()
        {
            InitializeComponent();
            
        }
        
        
        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_OnClicked_Timer(object sender, EventArgs e)
        {
            var count = 0;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                count += 1;
                // called every 1 second
                DisplayAlert("ALERT!", "There should be implementation for a timer in this alert's stead.", "Check, Rog");
                

                return false; // return true to repeat counting, false to stop timer
            });
        }


    }
}