using System;
using System.Collections.ObjectModel;
using PosgradosIOS.Services;

namespace PosgradosIOS.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu{get;set;}
		public ObservableCollection<PhoneContactViewModels> PhoneContacs { get; set; }
		public NavigationServices navigationService;
		#endregion
		public MainViewModel()
        {
            LoadData();
            LoadMenu();
			navigationService = new NavigationServices();

		}
		#region Methods

        private void LoadMenu()
        {
			Menu = new ObservableCollection<MenuItemViewModel>();

			Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_home",
				title = "Inicio",
				pageName = "MainPage"

			});
			Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_agenda2",
				title = "Directorio Telefónico",
				pageName = "PhoneContactsPage"

			});
		/*	Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_login",
				title = "MI ESPE",
				pageName = "EspePage"

			});*/
			Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_news",
				title = "Noticias",
				pageName = "NewsPage"

			});
			Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_ofertaacademica",
				title = "Maestrías",
				pageName = "CoursesPage"

			});
			Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_map",
				title = "Ubicación",
				pageName = "LocationPage"

			});
			Menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_contactanos",
				title = "Contáctanos",
				pageName = "ContactUsPage"

			});

		}
		private void LoadData()
		{
			PhoneContacs = new ObservableCollection<PhoneContactViewModels>();
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Asistente de Dirección",
				extension = "Extensión: 2541",
				encargado = "Responsable: Ingrid Marchan"

			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Dirección Administrativa-Financiera",
				extension = "Extensión: 2548",
				encargado = "Responsable: Paola Tápia"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Logística",
				extension = "Extensión: 2547",
				encargado = "Responsable: Diana Quimbiulco"
			});

			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Talento Humano",
				extension = "Extensión: 3033",
				encargado = "Responsables: Estefania Guerra, Sandra Ledezma"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Pagos y Seguimiento",
				extension = "Extensión: 2547",
				encargado = "Responsable: Santiago Guerrón"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Presupuesto",
				extension = "Extensión: 3033",
				encargado = "Responsable: Karina Loza"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Calidad ",
				extension = "Extensión: 2543",
				encargado = "Responsable: Elizabeth Buenaño"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Coordinación de Maestrías",
				extension = "Extensión: 2543",
				encargado = "Responsable: Tatiana Páez"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Coordinación de Becas",
				extension = "Extensión: 2553",
				encargado = "Responsables: Rosa Díaz-Katherine Pacheco"
			});

			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Secretaría Académica",
				extension = "Extensiones: 2546-2445",
				encargado = "Responsable: Ligia Moreno"
			});

			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Acreditación",
				extension = "Extensión: 2550",
				encargado = "Responsable: Carolina Bonifaz"
			});
			PhoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Tecnologías de la Información",
				extension = "Extensión: 2550",
				encargado = "Responsable: Andrés Rivadeneira"
			});
		}
		#endregion
	}
}
