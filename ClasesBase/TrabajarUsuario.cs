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
        public static int login(string user, string passwd)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Rol_Codigo FROM Usuario WHERE Usu_NombreUsuario = @user AND Usu_Contraseña = @passwd";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("user", user);
            cmd.Parameters.AddWithValue("passwd", passwd);

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            int rolObtenido = 0;

            if (dTable.Rows.Count == 1)
            {
                switch (dTable.Rows[0][0].ToString())
                {
                    case "1": rolObtenido = 1; break;
                    case "2": rolObtenido = 2; break;
                    case "3": rolObtenido = 3; break;
                }

                if(dTable.Rows[0][0].ToString()=="0")
                {
                    rolObtenido = 1;
                }
            }

            return rolObtenido;
        }
         
        public static DataTable listarRoles()
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
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Usu_ID as 'ID', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Nombre y Apellido', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Contraseña', ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', U.Rol_Codigo ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            return dTable;
        }

        public static void insertarUsuario(Usuario usr)
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

        public static DataTable buscarUsuario(string cadena)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Usu_ID as 'ID', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Nombre y Apellido', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Contraseña', ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', U.Rol_Codigo ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " U.Usu_NombreUsuario LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + cadena + "%");

            // Ejecuta la consulta
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            return dTable;
        }

        public static DataTable actualizarUsuario(string rol, string usuario, string contraseña, string nombreapellido, string cadena)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET Rol_Codigo = @rol, Usu_ApellidoNombre = @nomape, ";
            cmd.CommandText += "Usu_NombreUsuario = @usu, ";
            cmd.CommandText += "Usu_Contraseña = @pwd WHERE Usu_ID LIKE @pattern";

            //estableciendo los valores
            cmd.Parameters.AddWithValue("@rol", "%" + rol + "%");
            cmd.Parameters.AddWithValue("@usu", "%" + usuario + "%");
            cmd.Parameters.AddWithValue("@pwd", "%" + contraseña + "%");
            cmd.Parameters.AddWithValue("@nomape", "%" + nombreapellido + "%");
            cmd.Parameters.AddWithValue("@pattern", "%" + cadena + "%");
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();

            return dTable;

        }

        public static DataTable borrarUsuario(string cadena)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario ";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " Usu_NombreUsuario LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + cadena + "%");

            // Ejecuta la consulta
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            return dTable;
        }

    }
}
