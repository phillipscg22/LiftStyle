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
    public partial class ViewWorkoutPage : ContentPage
    {
        public ViewWorkoutPage()
        {
            InitializeComponent();
            
            //Put code in here that views the workout saved on a temp file
            var path = "LiftStyle/CurrentWorkout.txt";
            //not sure if this if statement is needed.
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    //this should contain a for loop to iterate through the create workout to send the data to a saving document
                    while (!sr.EndOfStream)
                    {
                        //take the doc and read line by line
                       string temp= sr.ReadLine();
                       string weight;
                       string reps;
                       string exercise;
                       //now take the line and break apart the data seperated by ":" and assign to the corresponding vars
                       //funct
                       //now take the vars and print them to the text fields.

                    }
                }	
            }
            
        }

        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}