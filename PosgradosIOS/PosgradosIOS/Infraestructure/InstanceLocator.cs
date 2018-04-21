using System;
using PosgradosIOS.ViewModels;

namespace PosgradosIOS.Infraestructure
{
    public class InstanceLocator
    {
        public MainViewModel main { get; set; }
        public InstanceLocator()
        {
            main = new MainViewModel();
        }
    }
}
