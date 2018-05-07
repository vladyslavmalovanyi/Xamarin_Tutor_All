using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Tutor_All
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        private int imageId = 1;

        public GalleryPage()
        {
            InitializeComponent();

            imageId = 1;

            NewImage();
        }

        void NewImage()
        {
            mainPicture.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", imageId)),
                CachingEnabled = false
            };
        }

        private void Left_Clicked(object sender, EventArgs e)
        {
            imageId--;
            if (imageId < 1) { imageId = 10; }

            NewImage();
        }

        private void Right_Clicked(object sender, EventArgs e)
        {
            imageId++;
            if (imageId > 10) { imageId = 1; }

            NewImage();
        }
    }
}