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
    public partial class StarView : ContentView
    {
        public StarView()
        {
            InitializeComponent();

#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            InfinitRotation(star1, 3000);
            InfinitRotation(star3, 6000);
            InfinitRotation(star2, 9000);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        }

        /// <summary>
        /// Permet de faire tourner un objet
        /// </summary>
        /// <param name="view"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        private async Task InfinitRotation(View view, uint lenght)
        {
            while (true)
            {
                await view.RotateTo(360, lenght);
                view.Rotation = 0;
            }
        }



    }
}