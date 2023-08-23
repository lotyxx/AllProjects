using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nacteniObrazku
{
    public partial class App : Application
    {
        public App()
        {
            //Loading main screen
            InitializeComponent();

            MainPage = new MainPage();
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
