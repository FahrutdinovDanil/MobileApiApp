using MobileApiApp.Services;
using MobileApiApp.Views;
using Xamarin.Forms;

namespace MobileApiApp
{
    public partial class App : Application
    {
        public static RequestManager RequestManager { get; private set; }
        public App()
        {
            InitializeComponent();

            RequestManager = new RequestManager(new RestService());
            MainPage = new NavigationPage(new CatsPage()) { BarBackgroundColor = Color.Red };
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
