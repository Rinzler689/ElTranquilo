using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InventarioElTranquilo
{
    public partial class AgregarProducto : Form
    {
        string urlAPI = "http://localhost:50523/Api/PRODUCTO";
        public AgregarProducto()
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
        public Producto leerProducto()
        {
            int cod_producto = Int32.Parse(txCodigo.Text);
            string nombre = txNombre.Text;
            double precio = Double.Parse(txPrecio.Text);
            int stock = Int32.Parse(txStock.Text);
            int nit_proveedor = Int32.Parse(txNit.Text);
            Producto objProducto = new Producto(cod_producto,nombre,precio,stock,nit_proveedor);
            return objProducto;
        }
        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            bool encontro = false;

            Producto objProducto = leerProducto();

            dynamic respuesta1 = DbApi.Get(urlAPI);
            string[] contenido = respuesta1.ToString().Split('}');

            for (int i = 0; i < contenido.Length - 1; i++)
            {
                if (objProducto.Cod_producto== Int32.Parse(respuesta1[i].COD_PRODUCTO.ToString()))
                {
                    MessageBox.Show("El código del producto que estás ingresando ya existe.");
                    encontro = true;
                    return;
                }
            }

            if (encontro == false)
            {
                string json = JsonConvert.SerializeObject(objProducto);
                dynamic respuesta2 = DbApi.Post(urlAPI, json);

                if (respuesta2 == 1)
                {
                    MessageBox.Show("La creación del Producto fue exitosa");
                }
                else
                {
                    MessageBox.Show("Falló la creación del Producto, revise la información");
                }
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
