using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InventarioElTranquilo
{
    public partial class EliminarProducto : Form
    {
        string urlAPI = "http://localhost:50523/Api/PRODUCTO";
        public EliminarProducto()
        {
            InitializeComponent();
            cargarProductos();
        }
        private void cargarProductos()
        {
            try
            {
                dynamic respuesta = DbApi.Get(urlAPI);
                string[] contenido = respuesta.ToString().Split('}');

                for (int i = 0; i < contenido.Length - 1; i++)
                {

                    cbNombre.Items.Add(respuesta[i].NOMBRE.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Productos: " + ex.Message);
            }
        }

        public Producto leerProducto()
        {
            // Validar campos vacíos
            if (cbNombre.SelectedItem== null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.");
                return null;
            }

            try
            {
                int cod_producto = Int32.Parse(txCodigo.Text);
                string nombre = cbNombre.SelectedItem.ToString();
                double precio = Double.Parse(txPrecio.Text);
                int stock = Int32.Parse(txStock.Text);
                int nit_proveedor = Int32.Parse(txNit.Text);

                Producto objProducto = new Producto(cod_producto, nombre, precio, stock, nit_proveedor);
                return objProducto;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido en uno de los campos numéricos. Revise los valores ingresados.");
                return null;
            }
        }

        private void btEliminarProducto_Click(object sender, EventArgs e)
        {

            Producto objProducto = leerProducto();

            if (objProducto == null)
            {
                return; // No continuar si los datos son inválidos o incompletos
            }
            string json = JsonConvert.SerializeObject(objProducto);
            dynamic respuesta = DbApi.Delete(urlAPI, json);
            if (respuesta == 1)
            {
                MessageBox.Show("La eliminación del Producto fue exitoso.");
                txCodigo.Clear();             
                txPrecio.Clear();
                txStock.Clear();
                txNit.Clear();
                cbNombre.Items.Clear();
                cargarProductos();
                cbNombre.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Fallo la eliminación del Producto, revice la imformación.");
               
            }

        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbNombre.SelectedItem == null)
                return; // evitar error si no hay selección

            dynamic respuesta = DbApi.Get(urlAPI);
            string[] contenido = respuesta.ToString().Split('}');

            for (int i = 0; i < contenido.Length - 1; i++)
            {

                if (cbNombre.SelectedItem.ToString() == respuesta[i].NOMBRE.ToString())
                {
                    txCodigo.Text = respuesta[i].COD_PRODUCTO.ToString();
                    txPrecio.Text = respuesta[i].PRECIO.ToString();
                    txStock.Text = respuesta[i].STOCK.ToString();
                    txNit.Text = respuesta[i].NIT_PROVEEDOR.ToString();
                    return;
                }


            }
            MessageBox.Show("Llego al final");
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
