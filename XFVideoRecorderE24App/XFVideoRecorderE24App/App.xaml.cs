using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFVideoRecorderE24App.Controllers;
using XFVideoRecorderE24App.Views;

namespace XFVideoRecorderE24App
{
    public partial class App : Application
    {
        static VideoDBController BaseDatos;

        public static VideoDBController BaseDatosObject
        {
            get
            {
                if(BaseDatos == null)
                {
                    BaseDatos = new VideoDBController(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VideosDBApp.db3"));
                }
                return BaseDatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageVideoRecord());
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
