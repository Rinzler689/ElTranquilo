using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioElTranquilo
{
    public class Usuario
    {
        private int id;
        private string nombre_usuario;
        private string clave;
        private int id_rol;

        public Usuario(int id, string nombre_usuario, string clave, int id_rol)
        {
            this.Id = id;
            this.Nombre_usuario = nombre_usuario;
            this.Clave = clave;
            this.Id_rol = id_rol;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
    }
}
