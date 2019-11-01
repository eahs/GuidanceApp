using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;

namespace GuidanceApp.Views
{
    public partial class BuisCompSummerPage : ContentPage
    {
        public BuisCompSummerPage()
        {
            InitializeComponent();
            
            OpenApcsSummer = new Command(() => Device.OpenUri(new Uri("https://learn.eastonsd.org/course/view.php?id=4198")));
        }

        public ICommand OpenApcsSummer { get; }
    }
}