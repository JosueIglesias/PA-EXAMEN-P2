using Examen2P_6483.Views6483;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2P_6483
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new RegistrationPage6483(new ViewModel6483.AccountViewModel6483()));
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
