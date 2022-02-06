using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace LiftStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked_GoToViewWorkoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewWorkoutPage());
        }

        private void Button_OnClicked_GoToCreateWorkoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateWorkoutPage());
        }

        private void Button_OnClicked_GoToWorkoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WorkoutPage());
        }
    }
}