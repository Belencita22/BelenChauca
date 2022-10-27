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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double total)
        {
            InitializeComponent();
            txtUsuarioR.Text = usuario;
            txtNombreR.Text = nombre;
            txtPagoSemestre.Text = Convert.ToString(total);
           
        }
    }
}