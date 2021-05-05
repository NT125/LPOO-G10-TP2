using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public string perfil = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Perfil:: " + perfil);         

        }

        private void añadirEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarEdificio oFrmAgregarEdificio = new FrmAgregarEdificio();

            oFrmAgregarEdificio.Show();
        }


        private void añadirInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarInquilino oFrmAgregarInquilino = new FrmAgregarInquilino();

            oFrmAgregarInquilino.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Desea salir del Sistema?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarDepartamento oFrmAgregarDepartamento = new FrmAgregarDepartamento();
            oFrmAgregarDepartamento.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
