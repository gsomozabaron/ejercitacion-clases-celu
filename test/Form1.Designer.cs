namespace test
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
            txtUsuario = new TextBox();
            button1 = new Button();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(165, 58);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese Usuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(191, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(165, 101);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingrese Contraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(button1);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Button button1;
        private TextBox txtContraseña;
    }
}