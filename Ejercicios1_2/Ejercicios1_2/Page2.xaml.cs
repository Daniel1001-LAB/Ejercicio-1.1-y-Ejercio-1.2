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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

        }

        private async void pageInformacion(object sender, EventArgs e)
        {

            var informacion = new Informacion
            {
                nombre = nombre.Text,
                apellido = apellido.Text,
                Edad = edad.Text,
                correo = correo.Text
            };
            var page4 = new Page4();
            page4.BindingContext = informacion;
            await Navigation.PushAsync(page4);
        }
    }

    
}