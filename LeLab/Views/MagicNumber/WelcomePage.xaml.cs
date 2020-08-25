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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            InfinitScale(playButton, 1000);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        }

        /// <summary>
        /// Permet d'agrandir et rétrécir un objet
        /// </summary>
        /// <param name="view"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        private async Task InfinitScale(View view, uint lenght)
        {
            while (true)
            {
                await view.ScaleTo(1.1, lenght);
                await view.ScaleTo(1.0, lenght);

            }
        }

        /// <summary>
        /// Bouton de navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButtonClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new GamePage());
        }
    }
}