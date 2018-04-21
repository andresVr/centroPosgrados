using System;
using System.Windows.Input;
using CentroPosgrados.Services;
using GalaSoft.MvvmLight.Command;

namespace CentroPosgrados.ViewModels
{
    public class MenuItemViewModel
    {
		NavigationServices navigationService;
		public string icon { get; set; }
		public string title { get; set; }
		public string pageName { get; set; }

		public MenuItemViewModel()
		{
			navigationService = new NavigationServices();

		}
		#region Commands
		public ICommand NavigateCommand
		{
			get { return new RelayCommand(() => navigationService.Navigate(pageName)); }
		}


		#endregion
	}
}
