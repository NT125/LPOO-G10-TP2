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
        public static DataTable ListarAlquileres()
        {
            //se crea cadena de conexion
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            //configurar comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Alquiler";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            //configuracion adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            //crear tabla
            DataTable dTable = new DataTable();
            //llenar tabla
            adaptador.Fill(dTable);
            return dTable;
        }
    }
}
