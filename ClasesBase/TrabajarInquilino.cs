using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
   public class TrabajarInquilino
    {
        public static void insert_Inquilino(Inquilino inq) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Inquilino(Inq_Apellido,Inq_Nombre,Inq_Telefono) values(@ape,@nom,@tel)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ape",inq.InqApellido);
            cmd.Parameters.AddWithValue("@nom",inq.InqNombre);
            cmd.Parameters.AddWithValue("@tel",inq.InqTelefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }


       //Cargar la grilla
       public static DataTable list_inquilinos(){

           SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "SELECT ";
           cmd.CommandText += "Inq_Apellido as 'Apellido', Inq_Nombre as 'Nombre', ";
           cmd.CommandText += "Inq_Telefono as 'Télefono' ";
           cmd.CommandText += "FROM Inquilino";
           cmd.CommandType = CommandType.Text;
           cmd.Connection = cnn;

           //Ejecuta la consulta
           SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

           //Llena los datos de la consulta en el datatable
           DataTable dTable = new DataTable();
           dAdapter.Fill(dTable);

           return dTable;
       }

       //Consultar - Busqueda
       public static DataTable search_inquilinos(string sPattern)
       {
           SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "SELECT Inq_Apellido as 'Apellido', Inq_Nombre as 'Nombre', Inq_Telefono as 'Telefono' FROM Inquilino ";
           cmd.CommandText += " WHERE ";
           cmd.CommandText += " Inq_Apellido LIKE @pattern OR Inq_Nombre LIKE @pattern ";
           
           cmd.CommandType = CommandType.Text;
           cmd.Connection = cnn;
           cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

           //Ejecuta la consulta
           SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

           //Llena los datos de la consulta en el datatable
           DataTable dTable = new DataTable();
           dAdapter.Fill(dTable);
           return dTable;

       }
       //Borrar
       public static DataTable delete_inquilinos(string sPattern)
       {
           SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "DELETE FROM Inquilino ";
           cmd.CommandText += "WHERE ";
           cmd.CommandText += "Inq_Telefono LIKE @pattern ";

           cmd.CommandType = CommandType.Text;
           cmd.Connection = cnn;
           cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

           //Ejecuta la consulta
           SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

           //Llena los datos de la consulta en el datatable
           DataTable dTable = new DataTable();
           dAdapter.Fill(dTable);
           return dTable;

       }


    }

}
