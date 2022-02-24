using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    public partial class App : Application
    {
        //son los estados que la aplicacion va a tener mantener informacion o procesos vivos o en ejecucion de segundo plano
        public App()
        {
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
