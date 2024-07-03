namespace Frm
{
    partial class FrmNoMetal
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
            txtPuntoDeFusion = new TextBox();
            txtPuntoDeEbullicion = new TextBox();
            lblEstadoNatural = new Label();
            lblPuntoDeEbullicion = new Label();
            cboEstadoNatural = new ComboBox();
            lblPuntoDeFusion = new Label();
            SuspendLayout();
            // 
            // lblElemento
            // 
            lblElemento.Text = "Elemento No Metal";
            // 
            // cboSubcategoria
            // 
            cboSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // btnAñadir
            // 
            btnAñadir.Text = "Añadir no metal.";
            btnAñadir.Click += btnAñadir_Click;
            // 
            // txtPuntoDeFusion
            // 
            txtPuntoDeFusion.Location = new Point(425, 232);
            txtPuntoDeFusion.Name = "txtPuntoDeFusion";
            txtPuntoDeFusion.Size = new Size(158, 23);
            txtPuntoDeFusion.TabIndex = 31;
            // 
            // txtPuntoDeEbullicion
            // 
            txtPuntoDeEbullicion.Location = new Point(425, 148);
            txtPuntoDeEbullicion.Name = "txtPuntoDeEbullicion";
            txtPuntoDeEbullicion.Size = new Size(158, 23);
            txtPuntoDeEbullicion.TabIndex = 30;
            // 
            // lblEstadoNatural
            // 
            lblEstadoNatural.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoNatural.Location = new Point(425, 268);
            lblEstadoNatural.Name = "lblEstadoNatural";
            lblEstadoNatural.Size = new Size(158, 35);
            lblEstadoNatural.TabIndex = 29;
            lblEstadoNatural.Text = "Estado natural";
            lblEstadoNatural.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPuntoDeEbullicion
            // 
            lblPuntoDeEbullicion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntoDeEbullicion.Location = new Point(425, 100);
            lblPuntoDeEbullicion.Name = "lblPuntoDeEbullicion";
            lblPuntoDeEbullicion.Size = new Size(158, 35);
            lblPuntoDeEbullicion.TabIndex = 27;
            lblPuntoDeEbullicion.Text = "Punto de ebullicion";
            lblPuntoDeEbullicion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboEstadoNatural
            // 
            cboEstadoNatural.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoNatural.FormattingEnabled = true;
            cboEstadoNatural.Location = new Point(425, 316);
            cboEstadoNatural.Name = "cboEstadoNatural";
            cboEstadoNatural.Size = new Size(158, 23);
            cboEstadoNatural.TabIndex = 32;
            // 
            // lblPuntoDeFusion
            // 
            lblPuntoDeFusion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntoDeFusion.Location = new Point(425, 185);
            lblPuntoDeFusion.Name = "lblPuntoDeFusion";
            lblPuntoDeFusion.Size = new Size(158, 35);
            lblPuntoDeFusion.TabIndex = 33;
            lblPuntoDeFusion.Text = "Punto de fusion";
            lblPuntoDeFusion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmNoMetal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 526);
            Controls.Add(lblPuntoDeFusion);
            Controls.Add(cboEstadoNatural);
            Controls.Add(txtPuntoDeFusion);
            Controls.Add(txtPuntoDeEbullicion);
            Controls.Add(lblEstadoNatural);
            Controls.Add(lblPuntoDeEbullicion);
            Name = "FrmNoMetal";
            Text = "FrmNoMetal";
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
            Controls.SetChildIndex(lblPuntoDeEbullicion, 0);
            Controls.SetChildIndex(lblEstadoNatural, 0);
            Controls.SetChildIndex(txtPuntoDeEbullicion, 0);
            Controls.SetChildIndex(txtPuntoDeFusion, 0);
            Controls.SetChildIndex(cboEstadoNatural, 0);
            Controls.SetChildIndex(lblPuntoDeFusion, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox textBox1;
        protected TextBox txtPuntoDeFusion;
        protected TextBox txtPuntoDeEbullicion;
        protected Label lblEstadoNatural;
        protected Label label2;
        protected Label lblPuntoDeEbullicion;
        protected ComboBox cboEstadoNatural;
        protected Label lblPuntoDeFusion;
    }
}