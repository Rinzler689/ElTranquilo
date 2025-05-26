using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace ElTranquiloWeb.Modelo
{
    public class DB
    {
        public static SqlConnection conectar(string nomBD)
        {
            SqlConnection conectar = new SqlConnection("Server=db20030.public.databaseasp.net; " +
            "Database=" + nomBD + "; User Id=db20030; Password=eltranquilo777; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");

            try
            {
                conectar.Open();
                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString()); return null;
            }
        }
        public static SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader(); return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString()); return null;
            }
        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery(); return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta" + e.ToString()); return num;
            }
        }
        public static void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq) { }
        }
    }
}