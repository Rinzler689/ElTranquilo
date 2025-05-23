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
    public partial class Login : Form
    {
        string urlAPI = "http://localhost:50523/Api/USUARIO";
        public Login()
        {
            InitializeComponent();
        }



        private void limpiar()
        {
            txUsuario.Clear();
            txClave.Clear();    
        }
        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txUsuario.Text) || string.IsNullOrEmpty(txClave.Text))
            {
                MessageBox.Show("Debe ingresar toda la información");
            }else{
                dynamic respuesta = DbApi.Get(urlAPI);
                string[] contenido = respuesta.ToString().Split('}');

                for (int i = 0; i < contenido.Length - 1; i++)
                {

    
                    if ((txUsuario.Text==respuesta[i].NOMBRE_USUARIO.ToString()) && (txClave.Text == respuesta[i].CLAVE.ToString()))
                    {

                        Menu objMenu = new Menu(Int32.Parse(respuesta[i].ID_ROL.ToString()));
                        this.Hide();
                        objMenu.Show();
                        return;
                    }

                }
                MessageBox.Show("Usuario o Clave incorrectos");
                limpiar();
            }
            
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
