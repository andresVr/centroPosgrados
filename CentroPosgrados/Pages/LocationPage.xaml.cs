using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CentroPosgrados.Pages
{
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
        }
		protected override void OnAppearing()
		{
			base.OnAppearing();
			MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-0.2273886, -78.584919), Distance.FromKilometers(3)));

			var pin = new Pin
			{
				Position = new Position(-0.2273886, -78.584919),
				Label = "Universidad de las Fuerzas Armadas ESPE",
				Address = "Sangolquí-Ecuador"
			};
			MainMap.Pins.Add(pin);
		}
    }
}
