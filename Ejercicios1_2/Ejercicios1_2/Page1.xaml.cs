using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicios1_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        double num1, num2, r;
        public Page1()
        {
            InitializeComponent();

        }

        void datosNumericos()
        {
            num1 = (n1.Text==null || n1.Text=="") ? 0.0 : Convert.ToDouble(n1.Text);
            num2 = (n2.Text == null || n2.Text == "") ? 0.0 : Convert.ToDouble(n2.Text);
        }

        private async void pageSuma(object sender, EventArgs e)
        {

            datosNumericos();
            r = num1 + num2;
            var datos = new Datos {Resultado = r.ToString()
            };
            var page3 = new Page3();
            page3.BindingContext = datos;
            await Navigation.PushAsync(page3);
        }

        private async void pageResta(object sender, EventArgs e)
        {
            datosNumericos();
            r = num1 - num2;
            var datos = new Datos
            {
                Resultado = r.ToString()
            };
            var page3 = new Page3();
            page3.BindingContext = datos;
            await Navigation.PushAsync(page3);
        }

        private async void pageMultiplicacion(object sender, EventArgs e)
        {
            datosNumericos();
            r = num1 * num2;
            var datos = new Datos
            {
                Resultado = r.ToString()
            };
            var page3 = new Page3();
            page3.BindingContext = datos;
            await Navigation.PushAsync(page3);
        }

        private async void pageDivision(object sender, EventArgs e)
        {
            datosNumericos();
            r = num1 / num2;
               var datos = new Datos
            {
                Resultado = r.ToString()
            };
            var page3 = new Page3();
            page3.BindingContext = datos;
            await Navigation.PushAsync(page3);
        }


    }
}