﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou no menu copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou no menu colar");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio2"];

            if (fc != null)
                fc.Close();

            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this; // objeto que está ativo no momento
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio3"];

            if (fc != null)
                fc.Close();

            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this; // objeto que está ativo no momento
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio4"];

            if (fc != null)
                fc.Close();

            frmExercicio4 objFrm4 = new frmExercicio4();
            objFrm4.MdiParent = this; // objeto que está ativo no momento
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio5"];

            if (fc != null)
                fc.Close();

            frmExercicio5 objFrm5 = new frmExercicio5();
            objFrm5.MdiParent = this; // objeto que está ativo no momento
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
