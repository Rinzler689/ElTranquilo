using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioElTranquilo
{
    public class Producto
    {
        private int cod_producto;
        private string nombre;
        private double precio;
        private int stock;
        private int nit_proveedor;

        public Producto(int cod_producto, string nombre, double precio, int stock, int nit_proveedor)
        {
            this.Cod_producto = cod_producto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.Nit_proveedor = nit_proveedor;
        }

        public int Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Nit_proveedor { get => nit_proveedor; set => nit_proveedor = value; }
    }
}
