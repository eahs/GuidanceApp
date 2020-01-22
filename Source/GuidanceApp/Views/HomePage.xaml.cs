using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GuidanceApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MakeAppointment());
        }

        private async void NavigateButton_OnClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LinksPage());
        }
        private async void NavigateButton_OnClicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CareerGuidesPage());
        }

        private async void NavigateButton_OnClicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage());
        }

        public void HomeTap (object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.eastonsd.org/"));
        }
    }
}
