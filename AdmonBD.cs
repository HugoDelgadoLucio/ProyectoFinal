using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal
{
    internal class AdmonBD
    {
        private MySqlConnection connection;
        public AdmonBD() 
        {
            this.Connect();
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
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void insertarComida(int id,string descripcion, float precio, int existencias, string imagen)
        {
            string query = "";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/
                query = "INSERT INTO comidas (id,Descripcion,Precio,Existencias,Imagen) VALUES ("
               + "'" + id + "',"
               + "'" + descripcion + "',"
               + "'" + precio + "', "
               + "'" + existencias + "', "
               + "'" + imagen + "')";



                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado con Exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void eliminar(int id)
        {
            string query = "";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/

                query = "DELETE FROM comidas WHERE id=" + id + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }
        public Comida consultaUnRegistroComida(int idc)
        {

            Comida item = null;
            int id;
            string descripcion;
            float precio;
            int existencias;
            string imagen;
            try
            {
                string query = "SELECT * FROM comidas where id=" + idc + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {

                    

                    id = Convert.ToInt32(reader["id"]);
                    descripcion = Convert.ToString(reader["descripcion"])??"";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    imagen = Convert.ToString(reader["imagen"])??"";

                    item = new Comida(id, descripcion, precio, existencias, imagen);


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
        public List<Comida> consultaComida()
        {
            List<Comida> data = new List<Comida>();
            Comida item = null;
            int id;
            string descripcion;
            float precio;
            int existencias;
            string imagen;
            try
            {
                
                string query = "SELECT * FROM comidas ORDER BY existencias ASC";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                
                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";

                    item = new Comida(id, descripcion, precio, existencias, imagen);
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
        public List<Usuario> consultaUsuarios()
        {
            List<Usuario> data = new List<Usuario>();
            Usuario item = null;
            int id;
            string nombre;
            string contraseña;
            string cuenta;
            float monto;
            try
            {

                string query = "SELECT * FROM usuarios";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    contraseña = Convert.ToString(reader["contraseña"])??"";
                    cuenta = Convert.ToString(reader["cuenta"])??"";
                    monto = Convert.ToSingle(reader["monto"]);

                    item = new Usuario(id, nombre, contraseña, cuenta, monto);
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
    }
}
