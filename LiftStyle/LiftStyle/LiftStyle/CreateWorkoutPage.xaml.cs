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

            // Set a variable to the Documents path.
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {

                // Write the string array to a new file named "CurrentWorkout.txt".
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "CurrentWorkout.txt")))
                {
                    outputFile.Write(exName1.Text + " | " + exSets1.SelectedItem.ToString() + " Sets | " + exReps1.SelectedItem.ToString() + " Reps | " + exWeight1.Text + " lbs\n");
                    outputFile.Write(exName2.Text + " | " + exSets2.SelectedItem.ToString() + " Sets | " + exReps2.SelectedItem.ToString() + " Reps | " + exWeight2.Text + " lbs\n");
                    outputFile.Write(exName3.Text + " | " + exSets3.SelectedItem.ToString() + " Sets | " + exReps3.SelectedItem.ToString() + " Reps | " + exWeight3.Text + " lbs\n");
                    outputFile.Write(exName4.Text + " | " + exSets4.SelectedItem.ToString() + " Sets | " + exReps4.SelectedItem.ToString() + " Reps | " + exWeight4.Text + " lbs\n");
                    outputFile.Write(exName5.Text + " | " + exSets5.SelectedItem.ToString() + " Sets | " + exReps5.SelectedItem.ToString() + " Reps | " + exWeight5.Text + " lbs\n");
                    outputFile.Write(exName6.Text + " | " + exSets6.SelectedItem.ToString() + " Sets | " + exReps6.SelectedItem.ToString() + " Reps | " + exWeight6.Text + " lbs\n");
                    outputFile.Write(exName7.Text + " | " + exSets7.SelectedItem.ToString() + " Sets | " + exReps7.SelectedItem.ToString() + " Reps | " + exWeight7.Text + " lbs\n");
                    outputFile.Write(exName8.Text + " | " + exSets8.SelectedItem.ToString() + " Sets | " + exReps8.SelectedItem.ToString() + " Reps | " + exWeight8.Text + " lbs\n");
                    outputFile.Write(exName9.Text + " | " + exSets9.SelectedItem.ToString() + " Sets | " + exReps9.SelectedItem.ToString() + " Reps | " + exWeight9.Text + " lbs\n");
                    outputFile.Write(exName10.Text + " | " + exSets10.SelectedItem.ToString() + " Sets | " + exReps10.SelectedItem.ToString() + " Reps | " + exWeight10.Text + " lbs\n");
                }

               
            }
            catch (Exception ignored)
            {
            }
            DisplayAlert("Great Success","Go to the View Workout page to view your masterful creation","Got it!" );
        }
    }
}