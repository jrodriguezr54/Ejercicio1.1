using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnrestar_Clicked(object sender, EventArgs e)
        {
            double num1, num2, resta, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            resta = num1 - num2;
            total = resta;
            DisplayAlert("la resta de los numeros es", total.ToString(), "ok");
            txtnumero1.Text = "";
            txtnumero2.Text = "";


        }

        private void btnsumar_Clicked(object sender, EventArgs e)
        {
            double num1, num2, suma, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            suma = num1 + num2;
            total = suma;
            DisplayAlert("la suma de los numeros es", total.ToString(), "ok");
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btnrestar_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btndividir_Clicked(object sender, EventArgs e)
        {
            double num1, num2, division, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            division = num1 / num2;
            total = division;

            if (num2 == 0)
            { DisplayAlert("no se pude dividir entre cero", "  ", "ok"); }

            else { DisplayAlert("la division de los numeros es", total.ToString(), "ok"); };

            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            double num1, num2, multi, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            multi = num1 * num2;
            total = multi;
            DisplayAlert("la multiplicacion de los numeros es", total.ToString(), "ok");
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }
    }
}
