using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;

namespace GuidanceApp.Views
{
    public partial class CareerGuidesPage : ContentPage
    {
        public CareerGuidesPage()
        {
            InitializeComponent();

            OpenXello = new Command(() => Device.OpenUri(new Uri("https://login.xello.world/")));
            OpenCc = new Command(() => Device.OpenUri(new Uri("https://public.careercruising.com/en/")));

        }

        public ICommand OpenXello { get; }
        public ICommand OpenCc { get; }


    }
}
