using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Week7.Esercitazione.Calcolatrice.Core;

namespace Week7.Esercitazione.Calcolatrice.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operation;
        private double valueA, valueB;

        private Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Clear();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn7.Content.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn8.Content.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn9.Content.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn4.Content.ToString();
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn5.Content.ToString();
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn6.Content.ToString();
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn3.Content.ToString();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn2.Content.ToString();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn1.Content.ToString();
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btn0.Content.ToString();
        }
        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = btnPunto.Content.ToString();
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "somma");
        }
        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "sottrai");
        }
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "dividi");
        }
        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "moltiplica");
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            txtValue.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);

            switch (operation)
            {
                case "somma":
                    txtValue.Text = calculator.Sum(new double[] { valueA, valueB }).ToString();
                    break;
                case "sottrai":
                    txtValue.Text = calculator.Subtraction(new double[] { valueA, valueB }).ToString();
                    break;
                case "dividi":
                    var risultato = calculator.Div(new double[] { valueA, valueB });
                    txtValue.Text = (risultato == null) ? "Error" : risultato.ToString();
                    break;
                case "moltiplica":
                    txtValue.Text = calculator.Multiiplication(new double[] { valueA, valueB }).ToString();
                    break;

            }
        }

        private void menuExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
