using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Menu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Login());
        }
        private async void Registro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Registro());
        }
    }
}
