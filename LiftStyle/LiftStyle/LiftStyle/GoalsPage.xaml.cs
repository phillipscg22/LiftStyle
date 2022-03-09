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
    public partial class GoalsPage : ContentPage
    {
        public GoalsPage()
        {
            InitializeComponent();
        }
        
        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}