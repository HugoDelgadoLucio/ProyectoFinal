namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonFormAdmin = new Button();
            SuspendLayout();
            // 
            // buttonFormAdmin
            // 
            buttonFormAdmin.Location = new Point(325, 169);
            buttonFormAdmin.Name = "buttonFormAdmin";
            buttonFormAdmin.Size = new Size(179, 74);
            buttonFormAdmin.TabIndex = 0;
            buttonFormAdmin.Text = "Mostrar Pantalla Admin";
            buttonFormAdmin.UseVisualStyleBackColor = true;
            buttonFormAdmin.Click += buttonFormAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFormAdmin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFormAdmin;
    }
}
