using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int i = 0;
        void OnButtonClicked(object sender, EventArgs e)
        {
            i++;
            (sender as Button).Text = $"{i} Кликов";
        }
    }
}
