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
            OpenSAT = new Command(() => Device.OpenUri(new Uri("https://collegereadiness.collegeboard.org/sat/register")));
            OpenPT = new Command(() => Device.OpenUri(new Uri("https://www.khanacademy.org/sat")));
            OpenACT = new Command(() => Device.OpenUri(new Uri("https://www.act.org/content/act/en/products-and-services/the-act/registration.html")));
            OpenMPT = new Command(() => Device.OpenUri(new Uri("https://www.act.org/content/act/en/products-and-services/the-act/test-preparation/math-practice-test-questions.html?page=0&chapter=0")));
            OpenRPT = new Command(() => Device.OpenUri(new Uri("https://www.act.org/content/act/en/products-and-services/the-act/test-preparation/reading-practice-test-questions.html?page=0&chapter=0")));

        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenSAT { get; }
        public ICommand OpenPT { get; }
        public ICommand OpenACT { get; }
        public ICommand OpenMPT { get; }
        public ICommand OpenRPT { get; }
    }

}
