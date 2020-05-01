using System;
using System.Collections.Generic;

namespace TravelMonkey.Models.AzureMaps
{
    public class Temperature
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class RealFeelTemperature
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class RealFeelTemperatureShade
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class DewPoint
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Direction
    {
        public float degrees { get; set; }
        public string localizedDescription { get; set; }
    }

    public class Speed
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Wind
    {
        public Direction direction { get; set; }
        public Speed speed { get; set; }
    }

    public class WindGust
    {
        public Speed speed { get; set; }
    }

    public class Visibility
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Ceiling
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Pressure
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class PressureTendency
    {
        public string localizedDescription { get; set; }
        public string code { get; set; }
    }

    public class Past24HourTemperatureDeparture
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class ApparentTemperature
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class WindChillTemperature
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class WetBulbTemperature
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class PastHour
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past3Hours
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past6Hours
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past9Hours
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past12Hours
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past18Hours
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past24Hours
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class PrecipitationSummary
    {
        public PastHour pastHour { get; set; }
        public Past3Hours past3Hours { get; set; }
        public Past6Hours past6Hours { get; set; }
        public Past9Hours past9Hours { get; set; }
        public Past12Hours past12Hours { get; set; }
        public Past18Hours past18Hours { get; set; }
        public Past24Hours past24Hours { get; set; }
    }

    public class TemperatureSummary
    {
        public Past6Hours past6Hours { get; set; }
        public Past12Hours past12Hours { get; set; }
        public Past24Hours past24Hours { get; set; }
    }

    public class ConditionsResult
    {
        public DateTime dateTime { get; set; }
        public string phrase { get; set; }
        public int iconCode { get; set; }
        public bool hasPrecipitation { get; set; }
        public bool isDayTime { get; set; }
        public Temperature temperature { get; set; }
        public RealFeelTemperature realFeelTemperature { get; set; }
        public RealFeelTemperatureShade realFeelTemperatureShade { get; set; }
        public double relativeHumidity { get; set; }
        public DewPoint dewPoint { get; set; }
        public Wind wind { get; set; }
        public WindGust windGust { get; set; }
        public double uvIndex { get; set; }
        public string uvIndexPhrase { get; set; }
        public Visibility visibility { get; set; }
        public string obstructionsToVisibility { get; set; }
        public int cloudCover { get; set; }
        public Ceiling ceiling { get; set; }
        public Pressure pressure { get; set; }
        public PressureTendency pressureTendency { get; set; }
        public Past24HourTemperatureDeparture past24HourTemperatureDeparture { get; set; }
        public ApparentTemperature apparentTemperature { get; set; }
        public WindChillTemperature windChillTemperature { get; set; }
        public WetBulbTemperature wetBulbTemperature { get; set; }
        public PrecipitationSummary precipitationSummary { get; set; }
        public TemperatureSummary temperatureSummary { get; set; }

        public string iconUrl
        {
            get
            {
                return (AzureMapsUris.WeatherIcons.ContainsKey(iconCode))
                    ? AzureMapsUris.WeatherIcons[iconCode]
                    : string.Empty;
            }
        }
    }

    public class CurrentConditions
    {
        public IList<ConditionsResult> results { get; set; }
    }
}
