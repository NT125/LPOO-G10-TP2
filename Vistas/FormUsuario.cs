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

        // ABM-CONSULTAS
        private void btnModifyUsr_Click(object sender, EventArgs e)
        {
            if (txtApeNom.Text != "" || txtPasswd.Text != "" || txtUsuario.Text != "")
            {                
                dgvUsers.DataSource = TrabajarUsuario.actualizarUsuario(cmbRoles.Text, txtUsuario.Text, txtPasswd.Text, txtApeNom.Text, txtNombreBuscado.Text);
                MessageBox.Show("Los datos han sido actualizados con éxito", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Reiniciando los campos
                txtApeNom.Text = "";
                txtUsuario.Text = "";
                txtPasswd.Text = "";

                cargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUsr_Click(object sender, EventArgs e)
        {
            if (txtApeNom.Text != "" || txtPasswd.Text != "" || txtUsuario.Text != "")
            {

                var confirmResult = MessageBox.Show("¿Desea añadir al usuario " + txtUsuario.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    Usuario oUser = new Usuario();

                    oUser.RolCodigo = (int)cmbRoles.SelectedValue;
                    oUser.UsuApellidoNombre = txtApeNom.Text;
                    oUser.UsuNombreUsuario = txtUsuario.Text;
                    oUser.UsuContrasenia = txtPasswd.Text;

                    TrabajarUsuario.insertarUsuario(oUser);
                    MessageBox.Show("El usuario " + txtUsuario.Text + " ha sido agregado con éxito", "Usuario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    //Reiniciando los campos
                    txtApeNom.Text = "";
                    txtUsuario.Text = "";
                    txtPasswd.Text = "";
                }

                cargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUsr_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                var confirmResult = MessageBox.Show("¿Realmente desea eliminar este Usuario?\nEsta acción no se puede deshacer", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {

                    dgvUsers.DataSource = TrabajarUsuario.borrarUsuario(txtUsuario.Text);
                    MessageBox.Show("El usuario " + txtUsuario.Text + " ha sido eliminado", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    
                    //Reiniciando los campos
                    txtApeNom.Text = "";
                    txtUsuario.Text = "";
                    txtPasswd.Text = "";
                }
                cargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de Usuario", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearchUsr_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = TrabajarUsuario.buscarUsuario(txtSearch.Text);
        }


        private void btnShowUsr_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
        
        ////////////////////////////////////

        private void dgvUsers_CurrentCellChanged(object sender, EventArgs e)
        {
           
        }


        /////////no se porque pero si borro el método el programa no arranca
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        ////////


        private void btnClose_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void dgvUsers_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow != null)
                {
                    cmbRoles.SelectedValue = dgvUsers.CurrentRow.Cells["Rol_Codigo"].Value.ToString();
                    //no toma la tabla Usuario (pq?), cargando según número de columna
                    txtApeNom.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                    txtUsuario.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                    txtPasswd.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                }                
            }
            catch (Exception ex)
            {

            }

        }
    }
}
