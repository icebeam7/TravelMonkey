using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Timers;
using System.Linq;
using TravelMonkey.Data;
using TravelMonkey.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

using TravelMonkey.Services.AzureMaps;
using TravelMonkey.Models.AzureMaps;

namespace TravelMonkey.ViewModels.AzureMaps
{
    public class WeatherPageViewModel : BaseViewModel
    {
        private ConditionsResult _currentConditions;
        public ConditionsResult CurrentConditions
        {
            get => _currentConditions;
            set => Set(ref _currentConditions, value);
        }

        private Destination _currentDestination;
        public Destination CurrentDestination
        {
            get => _currentDestination;
            set => Set(ref _currentDestination, value);
        }

        private ObservableCollection<Pin> _destinationSpaces;
        public ObservableCollection<Pin> DestinationSpaces
        {
            get => _destinationSpaces;
            set => Set(ref _destinationSpaces, value);
        }

        public Command GetCurrentConditionCommand { get; }
        public Command GetDestinationPOIsCommand { get; }

        public WeatherPageViewModel(Destination destination)
        {
            switch(destination.Title)
            {
                case "Seattle":
                    destination.Position = new Xamarin.Forms.Maps.Position(47.608013, -122.335167);
                    break;
                case "Maui":
                    destination.Position = new Xamarin.Forms.Maps.Position(20.798363, -156.331924);
                    break;
                case "Amsterdam":
                    destination.Position = new Xamarin.Forms.Maps.Position(52.377956, 4.897070);
                    break;
                case "Antarctica":
                    destination.Position = new Xamarin.Forms.Maps.Position(-75.2509766, -0.071389);
                    break;
            }

            CurrentDestination = destination;

            GetCurrentConditionCommand = new Command(async () =>
            {
                var conditions = await WeatherService.GetCurrentConditionsAsync(destination.Position.Latitude, destination.Position.Longitude);
                CurrentConditions = conditions.results.FirstOrDefault();
            });

            GetDestinationPOIsCommand = new Command(async () =>
            {
                var pois = await WeatherService.GetDestinationPOIsAsync(destination.Position.Latitude, destination.Position.Longitude);

                var pins = new List<Pin>();
                foreach (var p in pois.results)
                {
                    pins.Add(new Pin()
                    {
                        Position = new Xamarin.Forms.Maps.Position(p.position.lat, p.position.lon),
                        Label = p.poi.name,
                        Address = p.address.localName,
                    });
                }

                DestinationSpaces = new ObservableCollection<Pin>(pins);
            });

            GetCurrentConditionCommand.Execute(null);
            GetDestinationPOIsCommand.Execute(null);
        }
    }
}
