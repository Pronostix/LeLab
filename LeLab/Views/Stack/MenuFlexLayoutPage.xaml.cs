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
    public partial class MenuFlexLayoutPage : ContentPage
    {
        public MenuFlexLayoutPage()
        {
            InitializeComponent();
        }

        private void GoFlexLayoutStack(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new FlexLayoutStack());
        }
        private void GoFlexLayoutGrow(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new FlexLayoutGrow());
        }

        private void GoFlexLayoutWrap(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new FlexLayoutWrap());
        }
    }
}