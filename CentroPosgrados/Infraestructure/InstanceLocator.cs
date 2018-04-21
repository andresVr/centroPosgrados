using System;
using CentroPosgrados.ViewModels;

namespace CentroPosgrados.Infraestructure
{
    public class InstanceLocator
    {
		public InstanceLocator()
		{
			main = new MainViewModel();
		}
		public MainViewModel main { get; set; }


	}
}
