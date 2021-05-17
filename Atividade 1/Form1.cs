using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {

        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            txtResultado.Text = String.Empty;

            txtNum1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                if (numero2 == 0)
                    MessageBox.Show("não pode dividir por zero!!!");
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }

            }
            else
                MessageBox.Show("Números inválidos!!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!!!");

        }
    }
}
