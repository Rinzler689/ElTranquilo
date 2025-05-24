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

        public Producto leerProducto()
        {
            int id = Int32.Parse(txCodigo.Text);
            string nombre = txNombre.Text;
            double precio = Double.Parse(txPrecio.Text);
            int cantidad = Int32.Parse(txStock.Text);
            int nit = Int32.Parse(txNit.Text);
            Producto objProducto = new Producto(id,nombre,precio,cantidad,nit);
            return objProducto;
        }
        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto objProducto = leerProducto();
            string json = JsonConvert.SerializeObject(objProducto);
            dynamic respuesta = DbApi.Post(urlAPI, json);

            if (respuesta.ToString() == 1)
            {
                MessageBox.Show("La creación del Producto fue exitosa");
            }
            else
            {
                MessageBox.Show("Fallo la creación del Producto, revise la información");
            }
        }
    }
}
