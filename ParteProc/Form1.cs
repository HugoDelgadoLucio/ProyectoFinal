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

namespace PARTE_PROC
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;  // Conexi�n a la base de datos MySQL
        private WindowsMediaPlayer player;  // Reproductor de m�sica

        public Form1()
        {
            InitializeComponent();  // Inicializa los componentes del formulario

            // Configuraci�n de reproducci�n de m�sica al abrir el formulario
            player = new WindowsMediaPlayer();
            player.URL = @"C:\Users\GAEL OVALLE\Documents\UAA 3B\ParteDeProyecto\ParteProc\PistaDeAudio\Ritmo de Maracas.mp3"; // Ruta del archivo de m�sica
            player.settings.setMode("loop", true);  // Configura la m�sica para que se reproduzca en bucle
            player.controls.play();  // Inicia la reproducci�n de la m�sica
        }

        private void TbxContrase�a_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TboxContra_TextChanged(object sender, EventArgs e)
        {

        }
        private void TboxUser_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento clic en el bot�n "Ingresar"
        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            this.Connect();  // Conecta a la base de datos

            string ContraStaple = TboxContra.Text;  // Obtiene el texto de la caja de contrase�a
            int IdStaple;
            
            if (string.IsNullOrWhiteSpace(TboxUser.Text) || string.IsNullOrWhiteSpace(TboxContra.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si el valor **no es num�rico**, muestra un mensaje de error y sal de la funci�n
            if (!int.TryParse(TboxUser.Text, out IdStaple))
            {
                MessageBox.Show("Por favor, ingresa un valor num�rico v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del m�todo para evitar continuar con l�gica incorrecta
            }

            ContraStaple = ContraStaple.ToLower();  // Convierte la contrase�a a min�sculas

            int Id;  // Variable para almacenar el nombre del usuario de la base de datos
            string contrase�a;  // Variable para almacenar la contrase�a del usuario de la base de datos
            string cuenta;  // Variable para almacenar el tipo de cuenta (admin/guest)
            bool usuarioEncontrado = false;  // Indicador para verificar si se encontr� al usuario

            MySqlDataReader reader = null;  // Objeto para leer datos de la base de datos

            try
            {
                string query = "SELECT id, Cuenta, contrase�a FROM usuarios";  // Consulta SQL para obtener los datos de los usuarios

                MySqlCommand command = new MySqlCommand(query, this.connection);  // Comando SQL

                // Ejecuta la consulta y lee los resultados
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id = Convert.ToInt32(reader["id"]);  // Lee el nombre del usuario
                    contrase�a = Convert.ToString(reader["contrase�a"]) ?? "";  // Lee la contrase�a del usuario
                    contrase�a = contrase�a.ToLower();  // Convierte la contrase�a a min�sculas

                    // Verifica si las credenciales coinciden
                    if (Id == IdStaple && contrase�a == ContraStaple)
                    {
                        usuarioEncontrado = true;  // Indica que el usuario fue encontrado
                        MessageBox.Show("Inicio de sesi�n exitoso", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cuenta = Convert.ToString(reader["Cuenta"]) ?? "";  // Lee el tipo de cuenta

                        // Determina qu� interfaz mostrar seg�n el tipo de cuenta
                        switch (cuenta.ToLower())
                        {
                            case "admin":
                                // L�gica para interfaz de administrador (falta implementar)
                                break;

                            case "usuario":
                            case "guest":
                                // L�gica para interfaz de usuario invitado (falta implementar)
                                break;

                            default:
                                MessageBox.Show("No est� registrado ni como admin o usuario");
                                break;
                        }

                        break; // Sale del bucle
                    } 
                }

                if (!usuarioEncontrado)
                {
                    // Recorre nuevamente para encontrar discrepancias espec�ficas
                    reader.Close();
                    reader = command.ExecuteReader();
                    bool idEncontrado = false;

                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["id"]);
                        if (Id == IdStaple)
                        {
                            idEncontrado = true;
                            contrase�a = Convert.ToString(reader["contrase�a"]) ?? "";
                            contrase�a = contrase�a.ToLower();

                            if (contrase�a != ContraStaple)
                            {
                                MessageBox.Show("La contrase�a no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Muestra un mensaje de error si ocurre una excepci�n
                MessageBox.Show("Error al llevar a cabo esta operaci�n: " + ex.Message);
            }
            finally
            {
                // Cierra el lector si est� abierto
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                this.Disconnect();  // Desconecta de la base de datos
            }

        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=exportable; User=root; Password=; SslMode=none;";  // Cadena de conexi�n
            try
            {
                connection = new MySqlConnection(cadena);  // Crea la conexi�n
                connection.Open();  // Abre la conexi�n
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepci�n
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para desconectar de la base de datos
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();  // Cierra la conexi�n si est� abierta
            }
        }

        // Evento clic para pausar la m�sica
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();  // Pausa la m�sica
        }

        // Evento clic para reanudar la m�sica
        private void ButtonReanudar_Click(object sender, EventArgs e)
        {
            player.controls.play();  // Reanuda la m�sica
        }
    }
}

