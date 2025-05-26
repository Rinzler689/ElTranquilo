using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace ElTranquiloWeb.Controlador
{
    public class ManejoProductos
    {
        public static bool consultarProductos(Producto objProducto)
        {
            SqlConnection objConector = Modelo.DB.conectar("db20030");
            try
            {
                string sql = "SELECT * FROM PRODUCTO WHERE COD_PRODUCTO = " + objProducto.Cod_producto;
                SqlDataReader objTabla = Modelo.DB.consulta(sql, objConector);
                if (objTabla.Read())
                {
                    objProducto.Nombre = objTabla["NOMBRE"].ToString();
                    objProducto.Precio = Double.Parse(objTabla["PRECIO"].ToString());
                    objProducto.Stock = Int32.Parse(objTabla["STOCK"].ToString());
                    objProducto.Nit_proveedor = Int32.Parse(objTabla["NIT_PROVEEDOR"].ToString());
                    objConector.Close();
                    return true;
                }
                else
                {
                    objConector.Close();
                    return false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return false;
            }
        }
    }
}