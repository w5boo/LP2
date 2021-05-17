using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolumeM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double raio;

            if (!double.TryParse(txtRaio.Text, out raio))
                MessageBox.Show("Raio Inválido!");
            else
            {

                double volume;

                volume = Math.PI * Math.Pow(Convert.ToDouble(txtRaio.Text), 2) *
                    Convert.ToDouble(txtAltura.Text);

                txtVolume.Text = volume.ToString("N2");
            }
        }
    }
}
