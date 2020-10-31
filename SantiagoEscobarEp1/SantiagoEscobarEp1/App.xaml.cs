using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SantiagoEscobarEp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new vistaLogin())
            { BarBackgroundColor = Color.FromRgb(37, 64, 153), BarTextColor = Color.White };
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
