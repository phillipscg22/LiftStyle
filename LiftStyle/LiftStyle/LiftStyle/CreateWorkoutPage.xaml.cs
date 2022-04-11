using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiftStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateWorkoutPage : ContentPage
    {
        public CreateWorkoutPage()
        {
            InitializeComponent();
        }
        
        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        private void Button_OnClicked_CreateWorkout(object sender, EventArgs e)
        {
            /*
            //Put code in here that makes the workout
            var path = "LiftStyle/CurrentWorkout,txt";
            if (File.Exists(path)== false)
            {
                File.Create(path);
                //StringWriter sw = File.AppendText(path);
            }
            */
            
        }
    }
}