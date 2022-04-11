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
            
            //Put code in here that makes the workout
            var path = "LiftStyle/CurrentWorkout.txt";
            //not sure if this if statement is needed.
            if (File.Exists(path)== false)
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    //this should contain a for loop to iterate through the create workout to send the data to a saving document
                    sw.WriteLine("Exercise"+":"+"Reps"+":"+"Weight"+":");
                }	
            }
            
            
        }
    }
}