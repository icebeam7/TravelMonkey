using System;
using System.Collections.Generic;
using TravelMonkey.Models;
using Xamarin.Forms;

using TravelMonkey.ViewModels.AzureMaps;

namespace TravelMonkey.Views
{
    public partial class WeatherPage : ContentPage
    {
        private readonly WeatherPageViewModel _weatherPageViewModel;

        public WeatherPage(Destination destination)
        {
            InitializeComponent();

            _weatherPageViewModel = new WeatherPageViewModel(destination);
            this.BindingContext = _weatherPageViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
