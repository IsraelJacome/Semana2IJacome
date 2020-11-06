using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2IJacome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana2 : ContentPage
    {
        public Ventana2(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = user;
            txtPass.Text = pass;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            // nota seguimiento 1
            double parcial1 = Convert.ToDouble(txtParcial1.Text);
            double examen1 = Convert.ToDouble(txtExamen1.Text);
            double nota1 = (parcial1 * 0.3) + (examen1 * 0.2);

            //nota seguimiento 2
            double parcial2 = Convert.ToDouble(txtParcial2.Text);
            double examen2 = Convert.ToDouble(txtExamen2.Text);
            double nota2 = (parcial2 * 0.3) + (examen2 * 0.2);

            // calculo nota final
            double notaFinal = nota1 + nota2;

            //envio de resultados
            txtResultado.Text = notaFinal.ToString();

            if (notaFinal >= 7)
            {
                txtEstado.Text = "Aprobado";

            }
            else
            {
                txtEstado.Text = "Reprobado";
            }
        }
    }
}