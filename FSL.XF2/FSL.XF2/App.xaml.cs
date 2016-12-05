using FSL.XF2.Models;

using Xamarin.Forms;

namespace FSL.XF2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FSL.XF2.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private static ICustomerSoapService _customerSoapService;
        public static ICustomerSoapService CustomerSoapService
        {
            get
            {
                if (_customerSoapService == null)
                {
                    _customerSoapService = DependencyService.Get<ICustomerSoapService>();
                }

                return _customerSoapService;
            }
        }
    }
}
