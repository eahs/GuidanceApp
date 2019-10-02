using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;

namespace GuidanceApp.Views
{
    public partial class LinksPage : ContentPage
    {
        public LinksPage()
        {
            InitializeComponent();

            OpenACT = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            OpenSAT = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            OpenPT = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            OpenMPT = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            OpenRPT = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

        }

       

        public ICommand OpenSAT { get; }
        public ICommand OpenACT { get; }
        public ICommand OpenPT { get; }
        public ICommand OpenMPT { get; }
        public ICommand OpenRPT { get; }
    }
}
