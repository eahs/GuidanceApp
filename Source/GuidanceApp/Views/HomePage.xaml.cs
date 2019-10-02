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

        public void HomeTap (object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.eastonsd.org/"));
        }
    }
}
