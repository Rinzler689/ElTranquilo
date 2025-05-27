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
    public partial class ActualizarProducto : Form
    {

        string urlAPI = "http://localhost:50523/Api/PRODUCTO";
        string urlAPIProveedor = "http://localhost:50523/Api/PROVEEDOR";
        public ActualizarProducto()
        {
            InitializeComponent();
            cargarProducto();
            cargarProveedores();
        }

        private void panelActualizarProductoAjustar(object sender, EventArgs e)
        {
            panelActualizarProducto.Left = (this.ClientSize.Width - panelActualizarProducto.Width) / 2;
            panelActualizarProducto.Top = (this.ClientSize.Height - panelActualizarProducto.Height) / 2;
            panelActualizarProducto.Anchor = AnchorStyles.None;
        }

        private void limpiar()
        {
            
            txNombre.Clear();
            txPrecio.Clear();
            txStock.Clear();
            cbNit.SelectedIndex = -1;
        }
        private void cargarProducto()
        {
            try
            {
                dynamic respuesta = DbApi.Get(urlAPI);
                string[] contenido = respuesta.ToString().Split('}');

                for (int i = 0; i < contenido.Length - 1; i++)
                {

                    cbCodigo.Items.Add(respuesta[i].COD_PRODUCTO.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
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

         public Producto leerProducto()
          {
            // Validar campos vacíos
            if (cbCodigo.SelectedItem== null || string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txPrecio.Text) || string.IsNullOrEmpty(txStock.Text) || cbNit.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.");
                return null;
            }

            try
            {
                int cod_producto = Int32.Parse(cbCodigo.SelectedItem.ToString());
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

        private void btActualizarProducto_Click(object sender, EventArgs e)
        {
            

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

                if (objProducto.Cod_producto == Int32.Parse(respuesta1[i].COD_PRODUCTO.ToString()) && objProducto.Nombre == respuesta1[i].NOMBRE.ToString() 
                    && objProducto.Precio == Double.Parse(respuesta1[i].PRECIO.ToString()) && objProducto.Stock == Int32.Parse(respuesta1[i].STOCK.ToString()) && 
                    objProducto.Nit_proveedor == Int32.Parse(respuesta1[i].NIT_PROVEEDOR.ToString()))
                {
                    MessageBox.Show("Ya existe un producto con esa informacion, No te olvides de modificar los campos.");
                    return;
                }

            }

            
            string json = JsonConvert.SerializeObject(objProducto);
            dynamic respuesta2 = DbApi.Put(urlAPI, json);
            if (respuesta2 == 1)
            {
                MessageBox.Show("La actualización del Producto fue exitoso");             
                cbCodigo.Enabled = true;
                txNombre.Enabled = false;
                txPrecio.Enabled = false;
                txStock.Enabled = false;
                cbNit.Enabled = false;
                btCancelar.Enabled = false;
                btActualizarProducto.Enabled = false;   
                limpiar();
            }
            else
            {
               MessageBox.Show("Fallo la actualización del Producto revise la información");
            }


        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (cbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione un Codigo antes de continuar.");
                return ;
            }

            try
            {
                dynamic respuesta = DbApi.Get(urlAPI);
                string[] contenido = respuesta.ToString().Split('}');

                for (int i = 0; i < contenido.Length - 1; i++)
                {

                    if (cbCodigo.SelectedItem.ToString() == respuesta[i].COD_PRODUCTO.ToString())
                    {
                        txNombre.Text = respuesta[i].NOMBRE.ToString();
                        txPrecio.Text = respuesta[i].PRECIO.ToString();
                        txStock.Text = respuesta[i].STOCK.ToString();
                        cbNit.Text= respuesta[i].NIT_PROVEEDOR.ToString();
                        cbCodigo.Enabled = false; 
                        txNombre.Enabled = true;
                        txPrecio.Enabled = true;
                        txStock.Enabled = true;
                        cbNit.Enabled = true;
                        btCancelar.Enabled = true;                      
                        btActualizarProducto.Enabled = true;
                        
                        return;
                    }

                }
 
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido en uno de los campos numéricos. Revise los valores ingresados.");
                return;
            }
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbCodigo.Enabled = true;
            txNombre.Enabled = false;
            txPrecio.Enabled = false;
            txStock.Enabled = false;
            cbNit.Enabled = false;
            btActualizarProducto.Enabled = false;
            btCancelar.Enabled = false;
            
        }
    }
}
