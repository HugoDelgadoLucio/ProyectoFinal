using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ConexionUsuario
    {
        private int cantidad;
        private int id;
        private string descripcion;
        private double precio;
        private int existencias;
        private string imagen;

        public ConexionUsuario()
        {
        }

        public ConexionUsuario(int cantidad, int id, string descripcion, double precio, int existencias, string imagen)
        {
            this.cantidad = cantidad;
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
            this.existencias = existencias;
            this.imagen = imagen;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
