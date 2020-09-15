using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab.Views.Form_3._5_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Navigation.PushAsync(new WebViewPage(url));
            //Launcher.OpenAsync(new Uri(url));
        });


        private void ClicImage(object sender, EventArgs e)
        {
            Console.WriteLine("Image Bitton");
        }
    }
}