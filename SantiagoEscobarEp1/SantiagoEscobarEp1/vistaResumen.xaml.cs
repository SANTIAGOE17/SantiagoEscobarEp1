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
    public partial class vistaResumen : ContentPage
    {
        public vistaResumen(string nombre, string usuario, string cuotas)
        {
            InitializeComponent();
            double diferencia = Convert.ToDouble(cuotas) * 3;
            InitializeComponent();
            lblUsuario.Text = "Bienvenido: " + usuario;
            txtNombre.Text = nombre;
            txtCuotas.Text = cuotas.ToString();
            txtTotak.Text = diferencia.ToString();
        }
    }
}