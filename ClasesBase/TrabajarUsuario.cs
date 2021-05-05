using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable listadoRoles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            return dTable;
        }

        public static DataTable listarUsuarios()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM USuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_usuario(Usuario usr)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_NombreUsuario,Usu_Contraseña,Usu_ApellidoNombre,Rol_Codigo) values(@nomusu,@pwd,@apnom,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", usr.RolCodigo);
            cmd.Parameters.AddWithValue("@apnom", usr.UsuApellidoNombre);
            cmd.Parameters.AddWithValue("@nomusu", usr.UsuNombreUsuario);
            cmd.Parameters.AddWithValue("@pwd", usr.UsuContrasenia);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
