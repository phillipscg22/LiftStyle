﻿using System;
using System.Collections.Generic;
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
        }

        private void Button_OnClicked_GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}