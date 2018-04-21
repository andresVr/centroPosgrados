using System.Threading.Tasks;
using Xamarin.Forms;

namespace CentroPosgrados
{
    public partial class CentroPosgradosPage : ContentPage
    {
        public CentroPosgradosPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing(){
            base.OnAppearing();
            await Task.Delay(500);

            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10,2000)

            );

          
        }
    }
}
