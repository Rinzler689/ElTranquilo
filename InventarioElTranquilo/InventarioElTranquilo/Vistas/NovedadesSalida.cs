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
    public partial class NovedadesSalida : Form
    {
        private string urlAPI = "http://localhost:50523/Api/PRODUCTO";
        private string urlAPIProveedor = "http://localhost:50523/Api/PROVEEDOR";
        private string nit_proveedor = "";
        public NovedadesSalida()
        {
            InitializeComponent();
            cargarProducto();
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
        public Producto leerProducto()
        {
            // Validar campos vacíos
            if (cbCodigo.SelectedItem == null || string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txPrecio.Text) || string.IsNullOrEmpty(txUnidades.Text) || nit_proveedor == null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.");
                return null;
            }

            try
            {
                int cod_producto = Int32.Parse(cbCodigo.SelectedItem.ToString());
                string nombre = txNombre.Text;
                double precio = Double.Parse(txPrecio.Text);
                int stock = Int32.Parse(txUnidades.Text) - Int32.Parse(txCantUnidades.Text);
                int nit_Proveedor = Int32.Parse(nit_proveedor); // Atributo objeto = varibale global nit Proveedor

                Producto objProducto = new Producto(cod_producto, nombre, precio, stock, nit_Proveedor);
                return objProducto;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido en uno de los campos numéricos. Revise los valores ingresados.");
                return null;
            }
        }


        private void buscarProducto(object sender, EventArgs e)
        {

            // Validar campos vacíos
            if (cbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione un Codigo antes de continuar.");
                return;
            }

            try
            {
                dynamic respuesta1 = DbApi.Get(urlAPI);
                string[] contenido1 = respuesta1.ToString().Split('}');

                for (int i = 0; i < contenido1.Length - 1; i++)
                {

                    if (cbCodigo.Text == respuesta1[i].COD_PRODUCTO.ToString())
                    {
                        txNombre.Text = respuesta1[i].NOMBRE.ToString();
                        txPrecio.Text = respuesta1[i].PRECIO.ToString();
                        txUnidades.Text = respuesta1[i].STOCK.ToString();
                        nit_proveedor = respuesta1[i].NIT_PROVEEDOR.ToString();

                        dynamic respuesta2 = DbApi.Get(urlAPIProveedor);
                        string[] contenido2 = respuesta2.ToString().Split('}');

                        for (int j = 0; j < contenido2.Length - 1; j++)
                        {

                            if (nit_proveedor == respuesta2[j].NIT.ToString())
                            {
                                txProveedor.Text = respuesta2[j].NOMBRE.ToString();
                                btSalida.Enabled = true;
                                return;
                            }

                        }


                    }

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido en uno de los campos numéricos. Revise los valores ingresados.");
                return;
            }
        }

        private void btSalida_Click(object sender, EventArgs e)
        {


            Producto objProducto = leerProducto();

            // Validar si leerProducto() retornó null
            if (objProducto == null)
            {
                return; // No continuar si los datos son inválidos o incompletos
            }

            if (objProducto.Stock < Int32.Parse(txCantUnidades.Text) || Int32.Parse(txCantUnidades.Text)<0 )
            {
                MessageBox.Show("El valor ingresado no es valido");
                txCantUnidades.Clear();
                return; // No continuar si los datos son inválidos o incompletos
            }


            string json = JsonConvert.SerializeObject(objProducto);
            dynamic respuesta = DbApi.Put(urlAPI, json);
            if (respuesta == 1)
            {
                MessageBox.Show("Se ha dado salida a " + txCantUnidades.Text + " de " + objProducto.Nombre + "\r\n"
                    + " la nueva cantidad de unidades es: " + objProducto.Stock);
                btSalida.Enabled = false;
                txNombre.Clear();
                txPrecio.Clear();
                txUnidades.Clear();
                txProveedor.Clear();
                txCantUnidades.Clear();

            }
            else
            {
                MessageBox.Show("No se pudo dar salida a las unidades.");
            }
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
