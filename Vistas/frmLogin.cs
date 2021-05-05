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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean bUserFound = false;

            Usuario oUsuario1 = new Usuario("Admin","123");
            Usuario oUsuario2 = new Usuario("Operador", "123");
            Usuario oUsuario3 = new Usuario("Auditor", "123");


            FrmMain oFrmMain = new FrmMain();

            if (oUsuario1.UsuNombreUsuario == txtUserName.Text && oUsuario1.UsuContrasenia == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario2.UsuNombreUsuario == txtUserName.Text && oUsuario2.UsuContrasenia == txtPassword.Text)
            {
                bUserFound = true;
            }

            if (bUserFound)
            {
                MessageBox.Show("Bienvenido/a: " + txtUserName.Text,"Datos correctos",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                
                oFrmMain.perfil = "administrador";
                oFrmMain.Show();               
            }

            else
            {
                MessageBox.Show("El usuario ingresado no existe", "Datos incorrectos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.Width = 80;
            btnAceptar.Height = 27;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.Width = 75;
            btnAceptar.Height = 23;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.Width = 80;
            btnCancelar.Height = 27;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.Width = 75;
            btnCancelar.Height = 23;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
