using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.Esercitazione.Calcolatrice.Core;

namespace Week7.Esercitazione.Calcolatrice.WinForms
{
    public partial class CalculatorForm : Form
    {
        private double valueA;
        private double valueB;
        private string operation ;
        private Calculator calculator = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textValue.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textValue.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textValue.Text += btn9.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textValue.Text += btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textValue.Text += btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textValue.Text += btn4.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textValue.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textValue.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textValue.Text += btn1.Text;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textValue.Text += btnPunto.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textValue.Text += btn0.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textValue.Clear();
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            textValue.Clear();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnSum.Tag.ToString());
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnSub.Tag.ToString());
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnDiv.Tag.ToString());
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnMul.Tag.ToString());
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            valueB = (string.IsNullOrEmpty(textValue.Text))? 0 : double.Parse(textValue.Text);
            
            switch(operation)
            {
                case "somma":
                    textValue.Text = calculator.Sum(new double[] { valueA, valueB }).ToString();
                    break;
                case "sottrai":
                    textValue.Text = calculator.Subtraction(new double[] { valueA, valueB }).ToString();
                    break;
                case "dividi":
                    var risultato = calculator.Div(new double[] { valueA, valueB });
                    textValue.Text = (risultato == null) ? "Error" : risultato.ToString();
                    break;
                case "moltiplica":
                    textValue.Text = calculator.Multiiplication(new double[] { valueA, valueB }).ToString();
                    break;

            }
        }
    }
}
