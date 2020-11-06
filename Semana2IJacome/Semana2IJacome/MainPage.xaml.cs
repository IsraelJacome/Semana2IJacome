using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana2IJacome
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private async void btnAbrir_ventana_dos_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";

            if (pass == pass_val)
            {
                await Navigation.PushAsync(new Ventana2(user, pass));
            }
          
   

          
        }
    }
}
