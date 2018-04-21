using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroPosgrados.Pages
{
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
			Browser.Source = "http://ugp.espe.edu.ec/ugp/noticias-2/";
		}
		private void backClicked(object sender, EventArgs e)
		{
			// Check to see if there is anywhere to go back to
			if (Browser.CanGoBack)
			{
				Browser.GoBack();
			}
			else
			{ // If not, leave the view
				Navigation.PopAsync();
			}
		}
    }
}
