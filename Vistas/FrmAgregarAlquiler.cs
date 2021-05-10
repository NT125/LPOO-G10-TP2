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
    public partial class FrmAgregarAlquiler : Form
    {
        public FrmAgregarAlquiler()
        {
            InitializeComponent();
        }


        private void FrmAgregarAlquiler_Load(object sender, EventArgs e)
        {

            CargarEdificiosCmb();
            CargarDepartamentoCmb();
            
        }


        //operaciones de inicio
        private void CargarEdificiosCmb() {

            cmbEdif_Id.DisplayMember = "Edif_Nombre";
            cmbEdif_Id.ValueMember = "Edif_Codigo";
            cmbEdif_Id.DataSource = TrabajarAlquiler.listarEdificios();
        }

        private void CargarDepartamentoCmb() {

            cmbDepa_Id.DisplayMember = "Dpto_Numero +' -'+ Dpto_Piso";
            cmbDepa_Id.ValueMember = "Dpto_Codigo";
            txtDptoPrecio.Text = "Dpto_Precio";
            cmbDepa_Id.DataSource = TrabajarAlquiler.listarDepartamentos();
            
        }
        private void CargarInquilinoCmb() {
            cmbInq_Id.DataSource = TrabajarAlquiler.listarInquilinos();
            cmbInq_Id.DisplayMember = "Inq_Apellido, Inq_Nombre";
            cmbInq_Id.ValueMember = "Inq_Codigo";
            //Refrescar el contenido del combobox
            cmbDepa_Id.Refresh();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmAgregarAlquiler oFrmAgregarAlquiler = new FrmAgregarAlquiler();
        }

    }
}
