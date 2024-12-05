using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string contraseña;
        private string cuenta;
        private float monto;
        public Usuario()
        {

        }

        public Usuario(int id, string nombre, string contraseña, string cuenta, float monto)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Cuenta = cuenta;
            this.Monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public float Monto { get => monto; set => monto = value; }
    }
}
