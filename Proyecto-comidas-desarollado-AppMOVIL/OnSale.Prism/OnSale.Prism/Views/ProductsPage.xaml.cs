using Xamarin.Essentials;
using Xamarin.Forms;

namespace OnSale.Prism.Views
{
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        async void Menu2_Clicked(System.Object sender, System.EventArgs e)
        {
            if (await Launcher.CanOpenAsync("https://instagram.com/lavecindadsincelejo?igshid=1s4osu3ieegkh"))
            {
                await Launcher.OpenAsync("https://instagram.com/lavecindadsincelejo?igshid=1s4osu3ieegkh");
            }
        }

        async void Menu1_Clicked(System.Object sender, System.EventArgs e)
        {
            if (await Launcher.CanOpenAsync("https://www.google.com/maps/place/La+Vecindad+Sincelejo/@9.2918397,-75.4095062,17z/data=!3m1!4b1!4m5!3m4!1s0x8e59145c3ae56633:0xb7c6fc1f641be3af!8m2!3d9.2918397!4d-75.4073175"))
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/La+Vecindad+Sincelejo/@9.2918397,-75.4095062,17z/data=!3m1!4b1!4m5!3m4!1s0x8e59145c3ae56633:0xb7c6fc1f641be3af!8m2!3d9.2918397!4d-75.4073175");
            }
        }
    }
}
