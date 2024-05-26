namespace Frm
{
    partial class FrmElemento
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
            btnAñadir = new Button();
            txtSimbolo = new TextBox();
            txtNAtomico = new TextBox();
            lblMasaAtomica = new Label();
            lblSimbolo = new Label();
            lblNAtomico = new Label();
            txtGrupo = new TextBox();
            txtNombre = new TextBox();
            lblPeriodo = new Label();
            lblGrupo = new Label();
            lblNombre = new Label();
            cboSubcategoria = new ComboBox();
            label5 = new Label();
            txtPeriodo = new TextBox();
            txtMAtomica = new TextBox();
            SuspendLayout();
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.BackColor = Color.PaleTurquoise;
            lblCorreoElectronico.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreoElectronico.Location = new Point(54, 9);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(500, 45);
            lblCorreoElectronico.TabIndex = 4;
            lblCorreoElectronico.Text = "Elemento";
            lblCorreoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.PaleTurquoise;
            btnAñadir.Cursor = Cursors.Hand;
            btnAñadir.Location = new Point(435, 467);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(158, 47);
            btnAñadir.TabIndex = 8;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click_1;
            // 
            // txtSimbolo
            // 
            txtSimbolo.Location = new Point(25, 232);
            txtSimbolo.Name = "txtSimbolo";
            txtSimbolo.Size = new Size(158, 23);
            txtSimbolo.TabIndex = 13;
            // 
            // txtNAtomico
            // 
            txtNAtomico.Location = new Point(25, 148);
            txtNAtomico.Name = "txtNAtomico";
            txtNAtomico.Size = new Size(158, 23);
            txtNAtomico.TabIndex = 12;
            // 
            // lblMasaAtomica
            // 
            lblMasaAtomica.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaAtomica.Location = new Point(54, 268);
            lblMasaAtomica.Name = "lblMasaAtomica";
            lblMasaAtomica.Size = new Size(100, 35);
            lblMasaAtomica.TabIndex = 11;
            lblMasaAtomica.Text = "M.Atomica";
            lblMasaAtomica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSimbolo
            // 
            lblSimbolo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSimbolo.Location = new Point(54, 184);
            lblSimbolo.Name = "lblSimbolo";
            lblSimbolo.Size = new Size(100, 35);
            lblSimbolo.TabIndex = 10;
            lblSimbolo.Text = "Simbolo";
            lblSimbolo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNAtomico
            // 
            lblNAtomico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNAtomico.Location = new Point(54, 100);
            lblNAtomico.Name = "lblNAtomico";
            lblNAtomico.Size = new Size(100, 35);
            lblNAtomico.TabIndex = 9;
            lblNAtomico.Text = "Nº Atomico";
            lblNAtomico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(225, 232);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(158, 23);
            txtGrupo.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(225, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 18;
            // 
            // lblPeriodo
            // 
            lblPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeriodo.Location = new Point(254, 268);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(100, 35);
            lblPeriodo.TabIndex = 17;
            lblPeriodo.Text = "Periodo";
            lblPeriodo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrupo
            // 
            lblGrupo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrupo.Location = new Point(254, 184);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(100, 35);
            lblGrupo.TabIndex = 16;
            lblGrupo.Text = "Grupo";
            lblGrupo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(254, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 35);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboSubcategoria
            // 
            cboSubcategoria.FormattingEnabled = true;
            cboSubcategoria.Location = new Point(225, 400);
            cboSubcategoria.Name = "cboSubcategoria";
            cboSubcategoria.Size = new Size(158, 23);
            cboSubcategoria.TabIndex = 22;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(254, 352);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 21;
            label5.Text = "Subcategoria";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(225, 316);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(158, 23);
            txtPeriodo.TabIndex = 25;
            // 
            // txtMAtomica
            // 
            txtMAtomica.Location = new Point(25, 316);
            txtMAtomica.Name = "txtMAtomica";
            txtMAtomica.Size = new Size(158, 23);
            txtMAtomica.TabIndex = 26;
            // 
            // FrmElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 526);
            Controls.Add(txtMAtomica);
            Controls.Add(txtPeriodo);
            Controls.Add(cboSubcategoria);
            Controls.Add(label5);
            Controls.Add(txtGrupo);
            Controls.Add(txtNombre);
            Controls.Add(lblPeriodo);
            Controls.Add(lblGrupo);
            Controls.Add(lblNombre);
            Controls.Add(txtSimbolo);
            Controls.Add(txtNAtomico);
            Controls.Add(lblMasaAtomica);
            Controls.Add(lblSimbolo);
            Controls.Add(lblNAtomico);
            Controls.Add(btnAñadir);
            Controls.Add(lblCorreoElectronico);
            Name = "FrmElemento";
            Text = "FrmElemento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblCorreoElectronico;
        protected TextBox txtSimbolo;
        protected TextBox txtNAtomico;
        protected Label lblMasaAtomica;
        protected Label lblSimbolo;
        protected Label lblNAtomico;
        protected TextBox txtGrupo;
        protected TextBox txtNombre;
        protected Label lblPeriodo;
        protected Label lblGrupo;
        protected Label lblNombre;
        protected ComboBox cboSubcategoria;
        protected Label label5;
        protected TextBox txtPeriodo;
        protected TextBox txtMAtomica;
        public Button btnAñadir;
    }
}