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
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();
            voitureImg.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            voitureImg.TranslationX = 0;
            voitureImg.Opacity = 0;
            voitureImg.FadeTo(1, 2000);
            voitureImg.TranslateTo(30, 0, 1000, Easing.SinOut);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            voitureImg.TranslationX = 0;
            voitureImg.Opacity = 0;
        }
    }
}