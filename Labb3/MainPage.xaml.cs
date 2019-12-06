using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private void ClickedFirstButton(Object sender, EventArgs e)
        {
            Calculate(1.08, out double CalculatedVat, out double CalculatedAmount);
            PrintResults("8%", CalculatedVat, CalculatedAmount);
        }

        private void ClickedSecondButton(Object sender, EventArgs e)
        {
            Calculate(1.12, out double CalculatedVat, out double CalculatedAmount);
            PrintResults("12%", CalculatedVat, CalculatedAmount);

        }
        private void ClickedThirdButton(Object sender, EventArgs e)
        {
            Calculate(1.25, out double CalculatedVat, out double CalculatedAmount);
            PrintResults("25%", CalculatedVat, CalculatedAmount);
        }

        private void Calculate(double Vat, out double CalculatedVat, out double CalculatedAmount)
        {
            CalculatedVat = GetInput() / Vat;
            CalculatedAmount = GetInput() - CalculatedVat;
        }

        private double GetInput()
        {
            double.TryParse(Input.Text, out double UserInput);

            return UserInput;
        }

        private void PrintResults(String vatRate, double CalculatedVat, double CalculatedAmount)
        {
            vatRateLabel.Text = vatRate;
            EnteredAmountLabel.Text = Input.Text;
            CalculatedAmountLabel.Text = Math.Round(CalculatedAmount, 2).ToString();
            CalculatedVatLabel.Text = Math.Round(CalculatedVat, 2).ToString();
            
        } 


        public MainPage()
        {
            InitializeComponent();
        }
    }
}
