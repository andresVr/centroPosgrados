using System;
using System.Threading.Tasks;
using PosgradosIOS.Pages;
using Xamarin.Forms;

namespace PosgradosIOS.Services
{
    public class NavigationServices
    {
		public async void Navigate(string pageName)
		{
			App.Master.IsPresented = false;
			switch (pageName)
			{
				case "HomePage":
					await App.Navigator.PopToRootAsync();

					break;
				case "CoursesPage":
					await Navigate(new CoursesPage());
					break;
				case "EspePage":
					await Navigate(new EspePage());
					break;
				case "ContactUsPage":
					await Navigate(new ContactUsPage());
					break;
				case "PhoneContactsPage":
					await Navigate(new PhoneContactsPage());
					break;
				case "LocationPage":
					await Navigate(new LocationPage());
					break;
				case "NewsPage":
					await Navigate(new NewsPage());
					break;
				default:
					break;
			}

		}
		private static async Task Navigate<T>(T page) where T : Page
		{
			//NavigationPage.SetHasBackButton(page, false);
			NavigationPage.SetHasNavigationBar(page, true);
			NavigationPage.SetBackButtonTitle(page, "Atrás");//IOS    

			await App.Navigator.PushAsync(page);

		}

	}
}
