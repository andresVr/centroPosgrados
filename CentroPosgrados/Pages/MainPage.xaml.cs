using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CentroPosgrados.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await Task.Delay(2000);

			await Task.WhenAll(
				SplashGrid.FadeTo(0, 2000),
				Logo.ScaleTo(10, 2000)

			);


		}
    }
}
