using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppXamarin.Services;

namespace AppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MenuView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
