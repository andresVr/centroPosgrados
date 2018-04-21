using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroPosgrados.Pages
{
    public partial class PhoneContactsPage : ContentPage
    {
        public PhoneContactsPage()
        {
            InitializeComponent();
            listaContactos.ItemSelected += (sender, e) =>
            {
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
