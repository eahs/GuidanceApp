using System;
using Xamarin.Forms;
using System.Windows.Input;
namespace GuidanceApp.ViewModels
{
    public class SummerWorkViewModel : BaseViewModel
    {
        public SummerWorkViewModel()
        {
            Title = "Summer Work";
            OpenApcsSummer = new Command(() => Device.OpenUri(new Uri("https://learn.eastonsd.org/course/view.php?id=4198")));
        }
        public ICommand OpenApcsSummer { get; }
    }
}
