using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FormAlquileres : Form
    {
        public FormAlquileres()
        {
            InitializeComponent();
        }

        private void dataGridViewAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultaAlquiler_Click(object sender, EventArgs e)
        {
            dataGridViewAlquileres.DataSource = TrabajarAlquiler.listarAlquileres();
        }

        private void btnBuscarAlq_Click(object sender, EventArgs e)
        {
            dataGridViewAlquileres.DataSource = TrabajarAlquiler.buscarAlquiler(txtBuscarAlq.Text);
        }
    }
}
