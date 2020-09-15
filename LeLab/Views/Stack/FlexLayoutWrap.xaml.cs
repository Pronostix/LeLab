using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace LeLab.Views.Stack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexLayoutWrap : ContentPage
    {
        public FlexLayoutWrap()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            BoxView boxView;
            Random random = new Random();

            for(int i = 0; i < 100; i++ )
            {
                boxView = new BoxView();
                boxView.BackgroundColor = new Color(random.NextDouble(), random.NextDouble(), random.NextDouble());
                boxView.WidthRequest = random.Next(60, 100);
                boxView.HeightRequest = random.Next(60, 100);
                boxView.Margin = new Thickness(5);
                flexLayout.Children.Add(boxView);
            }
        }
    }
}