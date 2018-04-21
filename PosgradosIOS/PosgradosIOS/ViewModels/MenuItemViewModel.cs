using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using PosgradosIOS.Services;

namespace PosgradosIOS.ViewModels
{
    public class MenuItemViewModel
    {
        NavigationServices navigationService;
        public String icon { get; set; }
        public String title { get; set; }
        public String pageName { get; set; }

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
