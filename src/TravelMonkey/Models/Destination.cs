﻿namespace TravelMonkey.Models
{
    public class Destination
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string MoreInfoUrl { get; set; }
        public Xamarin.Forms.Maps.Position Position { get; set; }
    }
}