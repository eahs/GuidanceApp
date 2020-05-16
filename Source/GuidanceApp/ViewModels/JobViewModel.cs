using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GuidanceApp.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuidanceApp.ViewModels
{
    public class JobViewModel : BaseViewModel
    {
        public ObservableCollection<Jobs> Jobs { get; set; }

        public JobViewModel()
        {
            Jobs = new ObservableCollection<Jobs>();

            LoadItemsCommand.Execute(null);

           // Title = "Jobs";

            //OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
           // OpenLink = new Command(() => Device.OpenUri(new Uri("https://collegereadiness.collegeboard.org/sat/register")));

        }

        //public ICommand OpenWebCommand { get; }
       // public ICommand OpenLink { get; }


        protected override async Task LoadItemsAsync()
        {
            await Task.Delay(1);

            // Basic pattern

            try
            {
                bool success = false;
                var client = new RestClient(GlobalConstants.EndPointURL);
                var request = new RestRequest
                {
                    Timeout = GlobalConstants.RequestTimeout
                };
                request.Resource = GlobalConstants.JobsEndPointRequestURL;

                // Make async request to obtain data
                var response = await client.ExecuteAsync(request);


                if (response.IsSuccessful)
                {
                    var items = JsonConvert.DeserializeObject<List<Jobs>>(response.Content) ?? new List<Jobs>();

                    foreach (var product in items)
                    {
                        Jobs.Add(product);
                    }


                    OnPropertyChanged("Jobs");

                    IsError = false;
                    DataAvailable = true;

                }
                else
                {
                    // An error occurred that is stored
                    ErrorMessage = "An error occurred";
                    DataAvailable = false;
                    IsError = true;
                }
            }
            catch (Exception e)
            {
                // An exception occurred
                DataAvailable = false;
            }

        }
    }
}