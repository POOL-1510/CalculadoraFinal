using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double primerNumero = 0;
        double segundoNumero = 0;
        String operacion = "";


        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn2.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + " ";
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                primerNumero = double.Parse(txtResultado.Text); // Guardas el primer dato
                operacion = "+";                                // Guardas la operación
                txtResultado.Clear();                           // Limpias la pantalla para el segundo número
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                segundoNumero = double.Parse(txtResultado.Text);
                double resultado = 0;
                switch (operacion)
                {
                    case "+":
                        resultado = primerNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primerNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primerNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero == 0) {
                            MessageBox.Show("La división para 0 no se encuentra definida");
                            break;
                        }
                        resultado = primerNumero / segundoNumero;
                        break;
                }
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn9.Text;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + " ";
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                primerNumero = double.Parse(txtResultado.Text); 
                operacion = "-";                                
                txtResultado.Clear();                           
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + " ";
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                primerNumero = double.Parse(txtResultado.Text);
                operacion = "*";
                txtResultado.Clear();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + " ";
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                primerNumero = double.Parse(txtResultado.Text);
                operacion = "/";
                txtResultado.Clear();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " ";
            primerNumero = 0;
            segundoNumero = 0;
            operacion = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn0.Text;
        }
    }
    }

