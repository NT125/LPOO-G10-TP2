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
    public partial class FrmAgregarEdificio : Form
    {
        public FrmAgregarEdificio()
        {
            InitializeComponent();
        }

        Edificio oEdificio = new Edificio();
        int codE = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("¿Agregar Datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (confirmResult == DialogResult.Yes)
            {
                oEdificio.EdifCodigo = codE;
                oEdificio.EdifNombre = txtNombreEdificio.Text;
                oEdificio.EdifDireccion = txtDireccionEdificio.Text;
                oEdificio.EdifAdministrador = txtAdministradorEdificio.Text;
                oEdificio.EdifTelefono = txtTelefonoEdificio.Text;
                codE++;
                MessageBox.Show("¡Datos Agregados!\nNombre: "+ oEdificio.EdifNombre +
                    "\nDirección: " + oEdificio.EdifDireccion +
                    "\nAdministrador: " + oEdificio.EdifAdministrador +
                    "\nN° Teléfono: " + oEdificio.EdifTelefono, "Datos agregados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                codE++;
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
