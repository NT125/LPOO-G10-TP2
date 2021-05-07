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

        int codI = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("¿Agregar Datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                oInquilino.InqCodigo = codI;
                oInquilino.InqNombre = txtNombre.Text;
                oInquilino.InqApellido = txtApellido.Text;
                oInquilino.InqTelefono = txtTel.Text;
                codI++;
                MessageBox.Show("¡Datos Agregados!\nNombre y Apellido: " + oInquilino.InqNombre + " " + oInquilino.InqApellido +
                    "\nN° Teléfono: " + oInquilino.InqTelefono, "Datos agregados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
    }
}
