using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ElTranquiloWeb.Controlador;

namespace ElTranquiloWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btConsultar_Click(object sender, EventArgs e)
        {
            {
                int cod = Int32.Parse(cbCodigo.SelectedItem.ToString());
                Producto objProducto = new Producto(cod, "", 0, 0, 0);
                if (ManejoProductos.consultarProductos(objProducto))
                {
                    txNombre.Text = objProducto.Nombre;
                    txPrecio.Text = objProducto.Precio.ToString();
                    txStock.Text = objProducto.Stock.ToString();
                    txNitProveedor.Text = objProducto.Nit_proveedor.ToString();
                }
            }
        }

        protected void btLimpiar_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
            txPrecio.Text = "";
            txStock.Text = "";
            txNitProveedor.Text = "";
        }
    }
}