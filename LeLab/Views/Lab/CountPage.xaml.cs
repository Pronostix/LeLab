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
    public partial class CountPage : ContentPage
    {
        public int Count = 1;

        /// <summary>
        /// 
        /// </summary>
        public CountPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountButtonClick(object sender, EventArgs e)
        {
            CountLabel.Text = Count++.ToString();
        }


        private void InitButtonClick(object sender, EventArgs e)
        {
            Count = 1;
            CountLabel.Text = "0";
        }
    }
}