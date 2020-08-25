using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab.Views.MagicNumber
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {

        public WinPage() : this(5)
        {
        }

        public WinPage(int magicNumber)
        {
            InitializeComponent();

            layoutMain.Scale = 0.7;
            layoutMain.ScaleTo(1.0, 2000);

            resultText.Text = "Le nombre magique était de " + magicNumber;

#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            PauseNavigation();
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel

        }

        private async Task PauseNavigation()
        {
            await Task.Delay(3000);
            await this.Navigation.PopToRootAsync(true);
        }
    }
}