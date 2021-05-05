using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClasesBase;

namespace Vistas
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        /*
        SqlConnection conexion = new SqlConnection("");
        */

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        //Operaciones de inicio
        private void cargarUsuarios()
        {
            dgvUsers.DataSource = TrabajarUsuario.listarUsuarios();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
