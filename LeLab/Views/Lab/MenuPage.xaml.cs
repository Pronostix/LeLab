﻿using LeLab.Views.Form_3._5_Page;
using LeLab.Views.MagicNumber;
using LeLab.Views.Stack;
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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void GoCountPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }

        private void GoTabsPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }
        private void GoListePage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ListePage());
        }

        private void GoMagicNumberPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new WelcomePage());
        }

        private void GoFlexLayout(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MenuFlexLayoutPage());
            
        }

        private void GoNewsPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NewsPage());
        }
    }
}