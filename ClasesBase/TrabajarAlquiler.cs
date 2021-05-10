using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarAlquiler
    {

        //operaciones de listado
        public static DataTable listarAlquileres() //Para FormAlquileres
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Alquiler";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            adaptador.Fill(dTable);
            return dTable;
        }

        public static DataTable buscarAlquiler(string cadena)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Alquiler WHERE Alq_Codigo LIKE @pattern ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + cadena + "%");

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            return dTable;
        }

        
        //PUNTO 7 (no reconoce los queries, no los lee ni reconoce errores en caso de haberlos. RETIRADO DEL FrmMain TEMPORALMENTE)
        public static DataTable listarEdificios() //Para FrmAgregarAlquiler
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * from Edificio";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            return dTable;
        }

        public static DataTable listarDepartamentos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Departamento";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            return dTable;
        }
        public static DataTable listarInquilinos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Inquilino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            return dTable;
        }


        //

    }
}
