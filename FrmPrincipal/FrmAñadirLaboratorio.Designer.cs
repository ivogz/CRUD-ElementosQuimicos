namespace Frm
{
    partial class FrmAñadirLaboratorio
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
            lblNombre = new Label();
            label2 = new Label();
            lblTamaño = new Label();
            lblCorreoElectronico = new Label();
            txtNombre = new TextBox();
            txtUbicacion = new TextBox();
            cboTamaño = new ComboBox();
            btnAñadirLaboratorio = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(67, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 35);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 143);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 1;
            label2.Text = "Ubicacion";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTamaño
            // 
            lblTamaño.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTamaño.Location = new Point(67, 227);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(100, 35);
            lblTamaño.TabIndex = 2;
            lblTamaño.Text = "Tamaño";
            lblTamaño.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.BackColor = Color.PaleTurquoise;
            lblCorreoElectronico.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreoElectronico.Location = new Point(12, 9);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(210, 48);
            lblCorreoElectronico.TabIndex = 3;
            lblCorreoElectronico.Text = "Laboratorio";
            lblCorreoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(38, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(38, 191);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(158, 23);
            txtUbicacion.TabIndex = 5;
            // 
            // cboTamaño
            // 
            cboTamaño.FormattingEnabled = true;
            cboTamaño.Location = new Point(38, 275);
            cboTamaño.Name = "cboTamaño";
            cboTamaño.Size = new Size(158, 23);
            cboTamaño.TabIndex = 6;
            // 
            // btnAñadirLaboratorio
            // 
            btnAñadirLaboratorio.BackColor = Color.PaleTurquoise;
            btnAñadirLaboratorio.Cursor = Cursors.Hand;
            btnAñadirLaboratorio.Location = new Point(38, 329);
            btnAñadirLaboratorio.Name = "btnAñadirLaboratorio";
            btnAñadirLaboratorio.Size = new Size(158, 47);
            btnAñadirLaboratorio.TabIndex = 7;
            btnAñadirLaboratorio.Text = "Añadir laboratorio";
            btnAñadirLaboratorio.UseVisualStyleBackColor = false;
            btnAñadirLaboratorio.Click += btnAñadirLaboratorio_Click;
            // 
            // FrmAñadirLaboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 392);
            Controls.Add(btnAñadirLaboratorio);
            Controls.Add(cboTamaño);
            Controls.Add(txtUbicacion);
            Controls.Add(txtNombre);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblTamaño);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Name = "FrmAñadirLaboratorio";
            Text = "FrmAñadirLaboratorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label label2;
        private Label lblTamaño;
        private Label lblCorreoElectronico;
        private TextBox txtNombre;
        private TextBox txtUbicacion;
        private ComboBox cboTamaño;
        private Button btnAñadirLaboratorio;
    }
}