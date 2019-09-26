using System;
using Xamarin.Forms;
using System.Windows.Input;
namespace GuidanceApp.ViewModels
{
    public class LinksViewModel : BaseViewModel
    {
        public LinksViewModel()
        {
            Title = "Links";

         
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

        }

        public ICommand OpenWebCommand { get; }
    }

}
