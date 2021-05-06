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
            cargarRolesComboBox();
            cargarUsuarios();
        }

        //Operaciones de inicio
        private void cargarUsuarios()
        {
            dgvUsers.DataSource = TrabajarUsuario.listarUsuarios();
        }

        private void cargarRolesComboBox()
        {

            cmbRoles.DisplayMember = "Rol_Descripcion";
            cmbRoles.ValueMember = "Rol_Codigo";
            cmbRoles.DataSource = TrabajarUsuario.listarRoles();
        }
        ///////////////////////

        // OPERACIONES DEL ABM
        private void btnModifyUsr_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUsr_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();

            oUser.RolCodigo = (int)cmbRoles.SelectedValue;
            oUser.UsuApellidoNombre = txtApeNom.Text;
            oUser.UsuNombreUsuario = txtUsuario.Text;
            oUser.UsuContrasenia = txtPasswd.Text;

            TrabajarUsuario.insertarUsuario(oUser);

            cargarUsuarios();
        }

        private void btnDeleteUsr_Click(object sender, EventArgs e)
        {

        }





        //no se porque pero si borro el método el programa no arranca
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
