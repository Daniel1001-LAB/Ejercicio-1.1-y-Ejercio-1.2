using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicios1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void pageOperaciones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void pageDatos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
