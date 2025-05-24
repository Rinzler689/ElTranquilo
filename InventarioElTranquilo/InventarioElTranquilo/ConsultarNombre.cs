using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioElTranquilo
{
    public partial class ConsultarNombre : Form
    {
        string urlAPI = "http://localhost:50523/Api/PRODUCTO";
        public ConsultarNombre()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txCodigo.Clear();
            txNombre.Clear();
            txPrecio.Clear();
            txStock.Clear();
            txNit.Clear();
        }
        private void btConsultarNombre_Click(object sender, EventArgs e)
        {
            dynamic respuesta = DbApi.Get(urlAPI);
            string[] contenido = respuesta.ToString().Split('}');

            for (int i = 0; i < contenido.Length - 1; i++)
            {

                if (txNombre.Text == respuesta[i].NOMBRE.ToString())
                {
                    txCodigo.Text = respuesta[i].COD_PRODUCTO.ToString();
                    txPrecio.Text = respuesta[i].PRECIO.ToString();
                    txStock.Text = respuesta[i].STOCK.ToString();
                    txNit.Text = respuesta[i].NIT_PROVEEDOR.ToString();
                    return;
                }

            }
            limpiar();
            MessageBox.Show("Producto no encontrado");
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
