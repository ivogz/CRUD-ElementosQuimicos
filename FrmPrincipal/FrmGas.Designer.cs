namespace Frm
{
    partial class FrmGas
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
            txtUsoPrincipal = new TextBox();
            txtLugarDeObtencion = new TextBox();
            lblUsoPrincipal = new Label();
            lblLugarDeObtencion = new Label();
            SuspendLayout();
            // 
            // lblElemento
            // 
            lblElemento.Text = "Elemento Gas";
            // 
            // btnAñadir
            // 
            btnAñadir.Text = "Añadir Gas.";
            btnAñadir.Click += btnAñadir_Click_1;
            // 
            // txtUsoPrincipal
            // 
            txtUsoPrincipal.Location = new Point(425, 232);
            txtUsoPrincipal.Name = "txtUsoPrincipal";
            txtUsoPrincipal.Size = new Size(158, 23);
            txtUsoPrincipal.TabIndex = 30;
            // 
            // txtLugarDeObtencion
            // 
            txtLugarDeObtencion.Location = new Point(425, 148);
            txtLugarDeObtencion.Name = "txtLugarDeObtencion";
            txtLugarDeObtencion.Size = new Size(158, 23);
            txtLugarDeObtencion.TabIndex = 29;
            // 
            // lblUsoPrincipal
            // 
            lblUsoPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsoPrincipal.Location = new Point(425, 184);
            lblUsoPrincipal.Name = "lblUsoPrincipal";
            lblUsoPrincipal.Size = new Size(158, 35);
            lblUsoPrincipal.TabIndex = 28;
            lblUsoPrincipal.Text = "Uso principal";
            lblUsoPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLugarDeObtencion
            // 
            lblLugarDeObtencion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLugarDeObtencion.Location = new Point(425, 100);
            lblLugarDeObtencion.Name = "lblLugarDeObtencion";
            lblLugarDeObtencion.Size = new Size(158, 35);
            lblLugarDeObtencion.TabIndex = 27;
            lblLugarDeObtencion.Text = "Lugar de obtencion";
            lblLugarDeObtencion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmGas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 526);
            Controls.Add(txtUsoPrincipal);
            Controls.Add(txtLugarDeObtencion);
            Controls.Add(lblUsoPrincipal);
            Controls.Add(lblLugarDeObtencion);
            Name = "FrmGas";
            Text = "FrmGas";
            Controls.SetChildIndex(lblElemento, 0);
            Controls.SetChildIndex(btnAñadir, 0);
            Controls.SetChildIndex(lblNAtomico, 0);
            Controls.SetChildIndex(lblSimbolo, 0);
            Controls.SetChildIndex(lblMasaAtomica, 0);
            Controls.SetChildIndex(txtNAtomico, 0);
            Controls.SetChildIndex(txtSimbolo, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblGrupo, 0);
            Controls.SetChildIndex(lblPeriodo, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtGrupo, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(cboSubcategoria, 0);
            Controls.SetChildIndex(txtPeriodo, 0);
            Controls.SetChildIndex(txtMAtomica, 0);
            Controls.SetChildIndex(lblLugarDeObtencion, 0);
            Controls.SetChildIndex(lblUsoPrincipal, 0);
            Controls.SetChildIndex(txtLugarDeObtencion, 0);
            Controls.SetChildIndex(txtUsoPrincipal, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox txtUsoPrincipal;
        protected TextBox txtLugarDeObtencion;
        protected Label lblUsoPrincipal;
        protected Label lblLugarDeObtencion;
    }
}