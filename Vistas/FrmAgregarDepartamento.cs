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
    public partial class FrmAgregarDepartamento : Form
    {
        public FrmAgregarDepartamento()
        {
            InitializeComponent();
        }

        Departamento oDpto = new Departamento();
        int codD = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Agregar Datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (confirmResult == DialogResult.Yes)
            {

                oDpto.DeptoCodigo  = codD;
                oDpto.DptoAmbientes = Int32.Parse(txtAmbnt.Text);
                oDpto.DptoBanios = Int32.Parse(txtBan.Text);
                oDpto.DptoDormitorios = Int32.Parse(txtDorm.Text);
                oDpto.DptoPiso = Int32.Parse(txtPiso.Text);
                oDpto.DptoNumero = Int32.Parse(txtNum.Text);
                oDpto.DptoDisposicion = txtDispo.Text;
                oDpto.DptoPrecio = float.Parse(txtPrecio.Text);
                codD++;
                MessageBox.Show("¡Datos Agregados!\nPiso: " + oDpto.DptoPiso +
                    "\nNúmero: " + oDpto.DptoNumero +
                    "\nAmbientes: " + oDpto.DptoAmbientes +
                    "\nDormitorios: " + oDpto.DptoDormitorios +
                    "\nBaños: " + oDpto.DptoBanios +
                    "\nDisposición: " + oDpto.DptoDisposicion +
                    "\nPrecio: " + oDpto.DptoPrecio, "Datos agregados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
