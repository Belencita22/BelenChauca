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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if((usuario == "nombreEstudiante2022") && (contrasena == "uisrael2022"))
            {
                await Navigation.PushAsync(new Registro(usuario, contrasena));
            }
            else
            {
                lblMensaje.Text = "El usuario y contraseña son incorrectos";
            }
        }
    }
}