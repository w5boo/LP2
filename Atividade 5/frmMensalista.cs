using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciarMensalista_Click(object sender, EventArgs e)
        {
            //Criar ou instanciar o objeto da classe Mensalista
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = 
                Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objMensalista.SalarioMensal = 
                Convert.ToDouble(txtSalarioMensal.Text);

            // get
            MessageBox.Show("Matricula    :" + objMensalista.Matricula + "\n" +
                            "Nome         :" + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada :" + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto:" + objMensalista.SalarioBruto().ToString() + "\n" +
                            "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());
        }
    }
}
