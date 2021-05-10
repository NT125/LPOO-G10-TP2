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
            if (this.perfil == "ADMINISTRADOR")
            {
                inquilinosToolStripMenuItem.Enabled = false;
                alquilerToolStripMenuItem.Enabled = false;
            }
            if (this.perfil == "OPERADOR")
            {
                sistemaToolStripMenuItem.Enabled = false;
                edificiosToolStripMenuItem.Enabled = false;
                departamentosToolStripMenuItem.Enabled = false;
            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario oFrmUsuario = new FormUsuario();
            oFrmUsuario.Show();
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
            var confirmResult = MessageBox.Show("¿Desea salir del Sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Desea salir del Sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void mostrarAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlquileres oFormAlquileres = new FormAlquileres();

            oFormAlquileres.Show();
        }
        
        /*
        private void aBMAlquilersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarAlquiler oFrmAgregarAlquiler = new FrmAgregarAlquiler();

            oFrmAgregarAlquiler.Show();
        }
        */
    }
}
