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
    public partial class FrmAgregarInquilino : Form
    {
        public FrmAgregarInquilino()
        {
            InitializeComponent();
        }

        Inquilino oInquilino = new Inquilino();

        
        private void FrmAgregarInquilino_Load(object sender, EventArgs e){

            load_Inquilino();
        }

        private void dgwInquilino_CurrentCellChanged(object sender, EventArgs e)
        {
            txtApellido.Text = dgwInquilino.CurrentRow.Cells["Apellido"].Value.ToString();
            txtNombre.Text = dgwInquilino.CurrentRow.Cells["Nombre"].Value.ToString();
            txtTel.Text = dgwInquilino.CurrentRow.Cells["Telefono"].Value.ToString();


        }

        private void load_Inquilino()
        {
            dgwInquilino.DataSource = TrabajarInquilino.list_inquilinos();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                if (txtApellido.Text != "" || txtNombre.Text != "" || txtTel.Text != "")
                {

                    var confirmResult = MessageBox.Show("¿Desea añadir al inquilino " + txtNombre.Text +" "+ txtApellido.Text+ "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Inquilino oInquilino = new Inquilino();

                        oInquilino.InqApellido = txtApellido.Text;
                        oInquilino.InqNombre = txtNombre.Text;
                        oInquilino.InqTelefono = txtTel.Text;

                        TrabajarInquilino.insert_Inquilino(oInquilino);

                        MessageBox.Show("El inquilino " + txtNombre.Text + " " + txtApellido.Text + " ha sido agregado con éxito", "Inquilino Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        //Reiniciando los campos
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                        txtTel.Text = "";

                        load_Inquilino();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtConsulta.Text != "")
            {
                dgwInquilino.DataSource = TrabajarInquilino.search_inquilinos(txtConsulta.Text);
            }
            else
            {
                load_Inquilino();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnDeleteInq_Click(object sender, EventArgs e)
        {
            if (txtTel.Text != "")
            {
                var confirmResult = MessageBox.Show("Desea eliminar este inquilino?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dgwInquilino.DataSource = TrabajarInquilino.delete_inquilinos(txtConsulta.Text);
                    MessageBox.Show("El Inquilino" + txtNombre.Text + " " + txtApellido.Text + "ha sido eliminado");
                    //reiniciando los campos
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    txtTel.Text = "";
                    load_Inquilino();
                }
            }
            else
            {
                MessageBox.Show("Por favor, Complete todos los campos", "Faltan datos", MessageBoxButtons.OK);
                
            }

        }

        private void dgwInquilino_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgwInquilino.CurrentRow != null)
                {
                    txtApellido.Text = dgwInquilino.CurrentRow.Cells[0].Value.ToString();
                    txtNombre.Text = dgwInquilino.CurrentRow.Cells[1].Value.ToString();
                    txtTel.Text = dgwInquilino.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        

        
    }
}
