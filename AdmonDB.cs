using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class AdmonDB
    {
        private MySqlConnection connection;

        public AdmonDB()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public List<ConexionUsuario> consulta()
        {
            List<ConexionUsuario> data = new List<ConexionUsuario>();
            ConexionUsuario item;
            int id;
            string descripcion;
            double precio;
            int existencias;
            string imagen;
            try
            {
                string query = "SELECT * FROM comidas";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";

                    item = new ConexionUsuario(0, id, descripcion, precio, existencias, imagen);
                    data.Add(item);

                }
                reader.Close();
                data.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id + "," + p.Producto + "," + p.Imagen + "," + p.Precio);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }

        public ConexionUsuario consultaUnRegistro(int idp, int c)
        {

            ConexionUsuario item = null;
            int id;
            string descripcion;
            double precio;
            int existencias;
            string imagen;
            try
            {
                string query = "SELECT * FROM comidas where id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    id = Convert.ToInt32(reader["id"]);
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";

                    item = new ConexionUsuario(c, id, descripcion, precio, existencias, imagen);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=donadomingadb; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                //MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
