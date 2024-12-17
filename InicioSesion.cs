using System.IO.Packaging;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using System.Media;
using System.Numerics;
using WMPLib;

namespace ProyectoFinal
{
    public partial class InicioSesion : Form
    {
        private MySqlConnection connection;
        private WindowsMediaPlayer player;

        public InicioSesion()
        {
            InitializeComponent();

            player = new WindowsMediaPlayer();
            string rutaRelativa = Path.Combine(Application.StartupPath, @"SoundBase\Ritmo de Maracas.mp3");

            if (File.Exists(rutaRelativa))
            {   // Asignar la ruta al reproductor
                player.URL = rutaRelativa;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo: " + rutaRelativa);
            }
            player.settings.setMode("loop", true);  // Configura la música para que se reproduzca en bucle
            player.controls.play();  // Inicia la reproducción de la música
        }

        private void IdUsuarioBox_Click(object sender, EventArgs e)
        {

        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            this.Connect();  // Conecta a la base de datos

            string ContraStaple = TboxContra.Text;  // Obtiene el texto de la caja de contraseña
            int IdStaple;

            if (string.IsNullOrWhiteSpace(TboxUser.Text) || string.IsNullOrWhiteSpace(TboxContra.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si el valor **no es numérico**, muestra un mensaje de error y sal de la función
            if (!int.TryParse(TboxUser.Text, out IdStaple))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método para evitar continuar con lógica incorrecta
            }

            ContraStaple = ContraStaple.ToLower();  // Convierte la contraseña a minúsculas

            int Id;  // Variable para almacenar el nombre del usuario de la base de datos
            string contraseña;  // Variable para almacenar la contraseña del usuario de la base de datos
            string cuenta;  // Variable para almacenar el tipo de cuenta (admin/guest)
            bool usuarioEncontrado = false;  // Indicador para verificar si se encontró al usuario

            MySqlDataReader reader = null;  // Objeto para leer datos de la base de datos

            try
            {
                string query = "SELECT id, Nombre, Cuenta, contraseña FROM usuarios";  // Consulta SQL para obtener los datos de los usuarios

                MySqlCommand command = new MySqlCommand(query, this.connection);  // Comando SQL

                // Ejecuta la consulta y lee los resultados
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id = Convert.ToInt32(reader["id"]);  // Lee el nombre del usuario
                    contraseña = Convert.ToString(reader["contraseña"]) ?? "";  // Lee la contraseña del usuario
                    contraseña = contraseña.ToLower();  // Convierte la contraseña a minúsculas

                    // Verifica si las credenciales coinciden
                    if (Id == IdStaple && contraseña == ContraStaple)
                    {
                        usuarioEncontrado = true;  // Indica que el usuario fue encontrado
                        MessageBox.Show("Inicio de sesión exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cuenta = Convert.ToString(reader["Cuenta"]) ?? "";  // Lee el tipo de cuenta

                        // Determina qué interfaz mostrar según el tipo de cuenta
                        switch (cuenta.ToLower())
                        {
                            case "admin":
                                // Lógica para interfaz de administrador (falta implementar)
                                FormCarga pantallaCarga = new FormCarga(Convert.ToString(reader["Nombre"]));
                                pantallaCarga.ShowDialog();
                                break;


                            case "guest":
                                // Lógica para interfaz de usuario invitado (falta implementar)
                                InterfazUsuario pantallaUsuario = new InterfazUsuario(Convert.ToInt32(reader["id"]), Convert.ToString(reader["Nombre"]));
                                           
                                pantallaUsuario.ShowDialog();   
                                break;

                            default:
                                MessageBox.Show("No está registrado ni como admin o usuario");
                                break;
                        }

                        break; // Sale del bucle
                    }
                }

                if (!usuarioEncontrado)
                {
                    // Recorre nuevamente para encontrar discrepancias específicas
                    reader.Close();
                    reader = command.ExecuteReader();
                    bool idEncontrado = false;

                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["id"]);
                        if (Id == IdStaple)
                        {
                            idEncontrado = true;
                            contraseña = Convert.ToString(reader["contraseña"]) ?? "";
                            contraseña = contraseña.ToLower();

                            if (contraseña != ContraStaple)
                            {
                                MessageBox.Show("La contraseña no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }

                    if (!idEncontrado)
                    {
                        MessageBox.Show("El ID no coincide o no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show("Error al llevar a cabo esta operación: " + ex.Message);
            }
            finally
            {
                // Cierra el lector si está abierto
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                this.Disconnect();  // Desconecta de la base de datos
            }

        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=donadomingadb; User=root; Password=; SslMode=none;"; // Cadena de conexión
            try
            {
                connection = new MySqlConnection(cadena);  // Crea la conexión
                connection.Open();  // Abre la conexión
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para desconectar de la base de datos
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();  // Cierra la conexión si está abierta
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();  // Pausa la música

        }

        private void ButtonReanudar_Click(object sender, EventArgs e)
        {
            player.controls.play();  // Reanuda la música

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
