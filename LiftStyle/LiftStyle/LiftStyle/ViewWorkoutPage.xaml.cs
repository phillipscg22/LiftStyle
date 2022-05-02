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
            
            // Set a variable to the Documents path.
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            ex1.Text = "";
            ex2.Text = "";
            ex3.Text = "";
            ex4.Text = "";
            ex5.Text = "";
            ex6.Text = "";
            ex7.Text = "";
            ex8.Text = "";
            ex9.Text = "";
            ex10.Text = "";

            string [] exercises = File.ReadAllLines(Path.Combine(docPath, "CurrentWorkout.txt"));

            try
            {
                ex1.Text = exercises[0];
                ex2.Text = exercises[1];
                ex3.Text = exercises[2];
                ex4.Text = exercises[3];
                ex5.Text = exercises[4];
                ex6.Text = exercises[5];
                ex7.Text = exercises[6];
                ex8.Text = exercises[7];
                ex9.Text = exercises[8];
                ex10.Text = exercises[9];
            }
            catch (Exception ignored)
            {
            }
        }

        private void Button_OnClicked_UpdateWorkout(object sender, EventArgs e)
        {
            
            ex1.Text = "";
            ex2.Text = "";
            ex3.Text = "";
            ex4.Text = "";
            ex5.Text = "";
            ex6.Text = "";
            ex7.Text = "";
            ex8.Text = "";
            ex9.Text = "";
            ex10.Text = "";
            
            // Set a variable to the Documents path.
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                string workout = WorkoutSelect.SelectedItem.ToString() + ".txt";

                string[] exercises = File.ReadAllLines(Path.Combine(docPath, workout));

                try
                {
                    ex1.Text = exercises[0];
                    ex2.Text = exercises[1];
                    ex3.Text = exercises[2];
                    ex4.Text = exercises[3];
                    ex5.Text = exercises[4];
                    ex6.Text = exercises[5];
                    ex7.Text = exercises[6];
                    ex8.Text = exercises[7];
                    ex9.Text = exercises[8];
                    ex10.Text = exercises[9];
                }
                catch (Exception ignored)
                {
                }
            }
            catch (Exception er)
            {
                Navigation.PushAsync(new ViewWorkoutPage());
            }
        }

        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}