using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioElTranquilo
{
    public class Producto
    {
        private int id;
        private string nombreProducto;
        private double precio;
        private int cantidad;
        private int nit;

        public Producto(int id, string nombreProducto, double precio, int cantidad, int nit)
        {
            this.Id = id;
            this.NombreProducto = nombreProducto;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Nit = nit;
        }

        public int Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Nit { get => nit; set => nit = value; }
    }
}
