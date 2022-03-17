using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFVideoRecorderE24App.Models;
using Xam.Forms.VideoPlayer;

namespace XFVideoRecorderE24App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageVideoPlay : ContentPage
    {
        public PageVideoPlay(VideoModel datos)
        {
            InitializeComponent();

            descripcion.Text = datos.VideoDescripcion;
            UriVideoSource uriVideoSurce = new UriVideoSource()
            {
                Uri = datos.VideoUri
            };
            videoPlayer.Source = uriVideoSurce;
        }

        private void videoPlayer_PlayCompletion(object sender, EventArgs e)
        {

        }

        private async void btnExitApp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}