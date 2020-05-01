using System.Linq;
using System.Collections;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

using TravelMonkey.ViewModels.AzureMaps;
using System.Collections.ObjectModel;

namespace TravelMonkey.CustomControls
{
    public class CustomMap : Map
    {
        private static IList<Pin> AllPins;

        public Position CenterRegion
        {
            get { return (Position)GetValue(CenterRegionProperty); }
            set { SetValue(CenterRegionProperty, value); }
        }

        public static readonly BindableProperty CenterRegionProperty =
           BindableProperty.Create(propertyName: nameof(CenterRegion), returnType:
           typeof(Position), declaringType: typeof(CustomMap), defaultValue: null,
           propertyChanged: (sender, oldValue, newValue) =>
           {
               var map = (CustomMap)sender;

               if (newValue is Position location)
               {
                   map.MoveToRegion(MapSpan.FromCenterAndRadius(new
                    Position(location.Latitude, location.Longitude),
                    Distance.FromMiles(3)));
               }
           });


        public ObservableCollection<Pin> CustomPins
        {
            get { return (ObservableCollection<Pin>)GetValue(CustomPinsProperty); }
            set { SetValue(CustomPinsProperty, value); }
        }

        public static readonly BindableProperty CustomPinsProperty =
            BindableProperty.Create(propertyName: nameof(CustomPins), returnType:
            typeof(ObservableCollection<Pin>), declaringType: typeof(CustomMap), defaultValue: null,
            propertyChanged: (sender, oldValue, newValue) =>
            {
                var map = (CustomMap)sender;

                AllPins = new List<Pin>();
                map.Pins.Clear();

                if (newValue is ObservableCollection<Pin> spaces)
                    foreach (var pin in spaces)
                        map.Pins.Add(pin);

                AllPins = map.Pins;
                map.OnPropertyChanged("Pins");
            });
    }
}
