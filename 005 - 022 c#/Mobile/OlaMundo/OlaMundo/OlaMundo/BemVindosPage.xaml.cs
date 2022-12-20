using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OlaMundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class  BemVindosPage : ContentPage
    {
        public BemVindosPage()
        {
            InitializeComponent();

            slider.Value = 0.5;   
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Título", "Olá Mundo!", "Cancelar");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Número: {0:F2}", e.NewValue);
        }
    }
}