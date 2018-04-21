using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroPosgrados.Pages
{
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }
		protected override void OnAppearing()
		{
			base.OnAppearing();
			App.Navigator = this.Navigator;
			App.Master = this;
		}

	}
}
