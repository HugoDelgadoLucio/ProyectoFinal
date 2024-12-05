using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{

    
    public class Comida
    {
        private int id;
        private string descripcion;
        private float precio;
        private int existencias;
        private string imagen;
        
        public Comida()
        {
           
        }

        public Comida(int id, string descripcion, float precio, int existencias, string imagen)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencias = existencias;
            this.Imagen = imagen;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }

}
