namespace ProyectoFinal
{
    partial class CarritoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion

        private ListView listViewCarrito;
        private Label labelTotal;
        private Button btnComprar;
        private Button btnCancelar;
        private ColumnHeader Producto;
        private ColumnHeader cantidad;
        private ColumnHeader Precio;
        private Button btnPDF;
        private Label labelTaxes;
        private Button button1;
    }
}