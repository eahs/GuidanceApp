using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;

namespace GuidanceApp.Views
{
    public partial class JobPage : ContentPage
    {
        public JobPage()
        {
            InitializeComponent();

            OpenLink = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

        }

        public ICommand OpenLink { get; }
    }
}
