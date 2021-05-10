using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using System.Data.SqlClient;

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
            int rolObtenido = TrabajarUsuario.login(txtUserName.Text,txtPassword.Text);

            if (rolObtenido > 0)
            {
                FrmMain oFrmMain = new FrmMain();

                switch (rolObtenido)
                {
                    case 1: oFrmMain.perfil = "ADMINISTRADOR"; break;
                    case 2: oFrmMain.perfil = "OPERADOR"; break;
                    case 3: oFrmMain.perfil = "AUDITOR"; break;
                }

                MessageBox.Show("Ha ingresado al sistema como: " + oFrmMain.perfil, "Datos de acceso correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oFrmMain.Show();
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Datos de acceso erróneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

            //Boolean bUserFound = false;

            //Usuario oUsuario1 = new Usuario("Admin","123");
            //Usuario oUsuario2 = new Usuario("Operador", "123");
            //Usuario oUsuario3 = new Usuario("Auditor", "123");


            //FrmMain oFrmMain = new FrmMain();

            //if (oUsuario1.UsuNombreUsuario == txtUserName.Text && oUsuario1.UsuContrasenia == txtPassword.Text)
            //{
            //    bUserFound = true;
            //}
            //else if (oUsuario2.UsuNombreUsuario == txtUserName.Text && oUsuario2.UsuContrasenia == txtPassword.Text)
            //{
            //    bUserFound = true;
            //}

            //if (bUserFound)
            //{
            //    MessageBox.Show("Bienvenido: " + txtUserName.Text, "Datos de acceso correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    oFrmMain.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario y/o contraseña inválidos", "Datos de acceso incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


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

        //public static bool login(string usuario, string contraseña)
        //{
        //    SqlConnection cnn = new SqlConnection(Vistas.Properties.Settings.Default.agenciaConnectionString);

        //    const string sqlAction = "SELECT Rol_Codigo FROM Usuario WHERE Usu_NombreUsuario = @user AND Usu_Contraseña = @passwd";
        //    SqlCommand cmd = new SqlCommand(sqlAction, cnn);

        //    cmd.Parameters.AddWithValue("user", usuario);
        //    cmd.Parameters.AddWithValue("passwd", contraseña);



        //    return false;
        //}
    }
}
