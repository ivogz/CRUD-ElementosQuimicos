namespace Frm
{
    partial class FrmLogin
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
        private void InitializeComponent()
        {
            lblCorreoElectronico = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.BackColor = Color.PaleTurquoise;
            lblCorreoElectronico.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreoElectronico.Location = new Point(12, 28);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(210, 48);
            lblCorreoElectronico.TabIndex = 0;
            lblCorreoElectronico.Text = "BIENVENIDO";
            lblCorreoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 98);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(210, 23);
            txtCorreo.TabIndex = 2;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 148);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(210, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.PaleTurquoise;
            btnIngresar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.Location = new Point(32, 186);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(170, 46);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 247);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreoElectronico);
            Name = "FrmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreoElectronico;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Button btnIngresar;
    }
}