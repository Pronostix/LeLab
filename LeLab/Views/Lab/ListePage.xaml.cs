using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListePage : ContentPage
    {
        public List<Article> Articles { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ListePage()
        {
            InitializeComponent();

            Articles = new List<Article>
            {
                new Article("Chocolat", "10 €"),
                new Article("Savon", "7 €"),
                new Article("Pain", "2 €"),
                new Article("Farine", "1 €"),
                new Article("Oeuf", "8 €"),
            };

            MyListView.ItemsSource = Articles;


            // Idem que Handle_ItemTapped
            /*
            MyListView.ItemSelected += (sender, e) =>
            {
                if (MyListView.SelectedItem != null)
                {
                    Article item = MyListView.SelectedItem as Article;
                    DisplayAlert(item.Nom, "Le prix de l'article est de " + item.Prix, "Ok");
                    MyListView.SelectedItem = null;
                }
            };
            */
        }

        /// <summary>
        /// Methode lors que l'user sélectionneun élément
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Article item = e.Item as Article;

            await DisplayAlert(item.Nom, "Le prix de l'article est de " + item.Prix, "Ok");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }

    /// <summary>
    /// Classe d'article
    /// </summary>
    public class Article
    {
        public string Nom { get; set; }
        public string Prix { get; set; }

        public Article(string nom, string prix)
        {
            Nom = nom;
            Prix = prix;
        }
    }
}
