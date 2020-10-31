using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SantiagoEscobarEp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vistaLogin : ContentPage
    {
        public vistaLogin()
        {
            InitializeComponent();
        }
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = "estudiante2020";
            string passwd = "uisrael2020";
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            try
            {
                if (user == usuario && passwd == password)
                {
                    await Navigation.PushAsync(new MainPage(user, passwd));
                }
                else
                {
                    string mensaje = "El usuario o la contraseña no son validos.";
                    await DisplayAlert("Mensaje de Alerta", mensaje, "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }
        }
    }
}