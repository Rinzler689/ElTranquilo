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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(int rol)
        {
            InitializeComponent();
            switch (rol)
            {
                case 11:
                    btConsultarProducto.Visible = true;
                    btNovedades.Visible = true;
                    break;
                case 22:
                    btConsultarProducto.Visible= true;
                    btAgregarProducto.Visible = true;
                    btActualizarProducto.Visible = true;
                    btEliminarProducto.Visible = true;  

                    break;

                case 33:
                    btConsultarProducto.Visible = true;
                    btAgregarProducto.Visible = true;
                    btActualizarProducto.Visible = true;
                    btEliminarProducto.Visible = true;
                    btNovedades.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void btConsultarCodigo_Click(object sender, EventArgs e)
        {
            ConsultarPorCodigo objConsultarPorCodigo = new ConsultarPorCodigo();
            objConsultarPorCodigo.MdiParent = this;
            objConsultarPorCodigo.Show();
        }
    }
}
