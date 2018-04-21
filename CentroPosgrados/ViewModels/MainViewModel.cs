using System;
using System.Collections.ObjectModel;
using CentroPosgrados.Services;

namespace CentroPosgrados.ViewModels
{
    public class MainViewModel
    {
		#region Properties
		public ObservableCollection<MenuItemViewModel> menu { get; set; }
		public ObservableCollection<PhoneContactViewModels> phoneContacs { get; set; }
		public NavigationServices navigationService;
		#endregion


		public MainViewModel()
		{
			navigationService = new NavigationServices();
			loadMenu();
			loadData();
		}




		#region Methods
		private void loadData()
		{
			phoneContacs = new ObservableCollection<PhoneContactViewModels>();
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Asistente de Dirección",
				extension = "Extensión: 2541",
				encargado = "Responsable: Ingrid Marchan"
                    
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Dirección Administrativa-Financiera",
				extension = "Extensión: 2548",
				encargado = "Responsable: Paola Tápia"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Logística",
				extension = "Extensión: 2547",
				encargado = "Responsable: Diana Quimbiulco"
			});
	
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Talento Humano",
				extension = "Extensión: 3033",
				encargado = "Responsables: Estefania Guerra, Sandra Ledezma"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Pagos y Seguimiento",
				extension = "Extensión: 2547",
				encargado = "Responsable: Santiago Guerrón"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Presupuesto",
				extension = "Extensión: 3033",
				encargado = "Responsable: Karina Loza"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Calidad ",
				extension = "Extensión: 2543",
				encargado = "Responsable: Elizabeth Buenaño"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Coordinación de Maestrías",
				extension = "Extensión: 2543",
				encargado = "Responsable: Tatiana Páez"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Coordinación de Becas",
				extension = "Extensión: 2553",
				encargado = "Responsables: Rosa Díaz-Katherine Pacheco"
			});
		
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Secretaría Académica",
				extension = "Extensiones: 2546-2445",
				encargado = "Responsable: Ligia Moreno"
			});
		
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Acreditación",
				extension = "Extensión: 2550",
				encargado = "Responsable: Carolina Bonifaz"
			});
			phoneContacs.Add(new PhoneContactViewModels()
			{
				titulo = "Tecnologías de la Información",
				extension = "Extensión: 2550",
				encargado = "Responsable: Andrés Rivadeneira"
			});
		}
		private void loadMenu()
		{
			menu = new ObservableCollection<MenuItemViewModel>();

			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_home",
				title = "Inicio",
				pageName = "MainPage"

			});
			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_agenda2",
				title = "Directorio Telefónico",
				pageName = "PhoneContactsPage"

			});
			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_login",
				title = "MI ESPE",
				pageName = "EspePage"

			});
			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_news",
				title = "Noticias",
				pageName = "NewsPage"

			});
			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_ofertaacademica",
				title = "Maestrías",
				pageName = "CoursesPage"

			});
			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_map",
				title = "Ubicación",
				pageName = "LocationPage"

			});
			menu.Add(new MenuItemViewModel()
			{
				icon = "ic_action_contactanos",
				title = "Contáctanos",
				pageName = "ContactUsPage"

			});
		}
		#endregion

	}
}
