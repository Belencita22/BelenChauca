using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelenChauca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string contrasena)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMontoP.Text);
            double costo = 1800;
            double CuCosto = 0.05;

            if (costo > monto) 
            {
                double resta = costo - monto;
                double cuotas = resta / 5;
                double total1 = (cuotas + (cuotas * 0.05));
                txtMensualP.Text = total1.ToString();
            }
            else
            {
                DisplayAlert("Error", "Su cuota supera el monto", "OK");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            string nombre = txtNombre.Text;
            double total = Convert.ToDouble(txtMensualP.Text);

            if((txtNombre.Text !="") || (Convert.ToDouble(txtMontoP.Text) != 0))
            {
                DisplayAlert("Alerta","Su registro ha sido guardado","OK");
                await Navigation.PushAsync(new Resumen(usuario,nombre,total));
            }
            else
            {
                DisplayAlert("Error","No se acepta campos vacios","OK");
            }
        }
    }
}