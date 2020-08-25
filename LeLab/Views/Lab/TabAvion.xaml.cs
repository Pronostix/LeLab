using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabAvion : ContentPage
    {
        public TabAvion()
        {
            InitializeComponent();
            avionImg.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            avionImg.TranslationX = -250;
            avionImg.TranslationY = -150;
            avionImg.Rotation = 45;
            avionImg.Scale = 0.7;
            avionImg.Opacity = 0;

            uint length = 800;

            avionImg.FadeTo(1, 100);
            avionImg.TranslateTo(0, 0, length, Easing.SinOut);
            avionImg.RotateTo(0, length, Easing.SinOut);
            avionImg.ScaleTo(1, length, Easing.SinOut);
        }


        /// <summary>
        /// Méthode async permettant d'exécuter les animations les unes à la suite des autres
        /// </summary>
        private async void Anim()
        {
            uint length = 800;

            await avionImg.FadeTo(1, 100);
            await avionImg.TranslateTo(0, 0, length, Easing.SinOut);
            await avionImg.RotateTo(0, length, Easing.SinOut);
            await avionImg.ScaleTo(1, length, Easing.SinOut);
        }

    }
}