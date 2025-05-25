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
        string urlAPIProveedor = "http://localhost:50523/Api/PROVEEDOR";

        public AgregarProducto()
        {
            InitializeComponent();
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            try
            {
                dynamic respuesta = DbApi.Get(urlAPIProveedor);
                string[] contenido = respuesta.ToString().Split('}');

                for (int i = 0; i < contenido.Length - 1; i++)
                {

                    cbNit.Items.Add(respuesta[i].NIT.ToString());  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void limpiar()
        {
            txCodigo.Clear();
            txNombre.Clear();
            txPrecio.Clear();
            txStock.Clear();
            cbNit.SelectedIndex = -1;
        }
        public Producto leerProducto()
        {
            // Validar campos vacíos
            if (string.IsNullOrEmpty(txCodigo.Text) || string.IsNullOrEmpty(txNombre.Text) ||string.IsNullOrEmpty(txPrecio.Text) ||  string.IsNullOrEmpty(txStock.Text) ||   cbNit.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.");
                return null;
            }

            try
            {
                int cod_producto = Int32.Parse(txCodigo.Text);
                string nombre = txNombre.Text;
                double precio = Double.Parse(txPrecio.Text);
                int stock = Int32.Parse(txStock.Text);
                int nit_proveedor = Int32.Parse(cbNit.SelectedItem.ToString());

                Producto objProducto = new Producto(cod_producto, nombre, precio, stock, nit_proveedor);
                return objProducto;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido en uno de los campos numéricos. Revise los valores ingresados.");
                return null;
            }
        }
        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            bool encontro = false;

            Producto objProducto = leerProducto();

            // Validar si leerProducto() retornó null
            if (objProducto == null)
            {
                return; // No continuar si los datos son inválidos o incompletos
            }

            dynamic respuesta1 = DbApi.Get(urlAPI);
            string[] contenido = respuesta1.ToString().Split('}');

            for (int i = 0; i < contenido.Length - 1; i++)
            {
                if (objProducto.Cod_producto == Int32.Parse(respuesta1[i].COD_PRODUCTO.ToString()))
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
                    limpiar();
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
