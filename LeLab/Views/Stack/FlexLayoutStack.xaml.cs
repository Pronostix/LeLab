using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab.Views.Stack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexLayoutStack : ContentPage
    {
        public FlexLayoutStack()
        {
            int count = 0;

            InitializeComponent();

            MyButton.Clicked += (sender, e) =>
             {
                 count++;
                 Label label = new Label();
                 label.Text = count.ToString();
                 label.Margin = new Thickness(10);

                 flexLayout.Children.Add(label);
             };

        }
    }
}