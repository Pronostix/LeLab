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
    public partial class GamePage : ContentPage
    {
        /// <summary>
        /// Min data
        /// </summary>
        public const int nbMin = 1;

        /// <summary>
        /// Max data
        /// </summary>
        public const int nbMax = 4;

        /// <summary>
        /// Magic Number
        /// </summary>
        private int magicNumber { get; set; }

        /// <summary>
        /// Nombre de tentative
        /// </summary>
        private int CountFind { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public GamePage()
        {
            InitializeComponent();

            // Supresssion de la bar de navigation
            NavigationPage.SetHasNavigationBar(this, false);

            MinMaxNumber.Text = "Entre " + nbMin.ToString() + " et " + nbMax.ToString();

            InitializeData();
        }

        /// <summary>
        /// Find Magic Number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButtonClick(object sender, EventArgs e)
        {
            int entry = 0;         

            if (int.TryParse(entryNumber.Text,out entry))
            {
                CountFind++;
                countNumber.Text = CountFind.ToString();

                if (entry < nbMin || entry > nbMax)
                    DisplayAlert("Oups", "Vous devez rentrer un nombre entre " + nbMin + " et " + nbMax, "Ok");
                else if (entry < magicNumber)
                    DisplayAlert("Oups", "Le nombre magique est plus grand", "Ok");
                else if (entry > magicNumber)
                    DisplayAlert("Oups", "Le nombre magique est plus petit", "Ok");
                else
                {
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                    WiAction();
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                }
            }             
            else
                DisplayAlert("Oups", "Vous devez rentrer un nombre", "Ok");

        }

        private async Task WiAction()
        {
            //await DisplayAlert("MagicNumber", "Bravo ! Vous avez trouvez le nombre magique ! ", "Ok");            
            await this.Navigation.PushAsync(new WinPage(magicNumber));
        }

        /// <summary>
        /// Initialisation
        /// </summary>
        private void InitializeData()
        {
            magicNumber = new Random().Next(nbMin, nbMax);
            CountFind = 0;

            countNumber.Text = "0";
            entryNumber.Text = null;

        }
    }
}