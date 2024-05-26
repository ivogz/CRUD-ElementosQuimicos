namespace Frm
{
    partial class FrmMetal
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
            txtRadioactividad = new TextBox();
            txtColor = new TextBox();
            lblColor = new Label();
            lblRadioactividad = new Label();
            SuspendLayout();
            // 
            // lblCorreoElectronico
            // 
            lblElemento.Text = "Elemento Metal";
            // 
            // btnAñadir
            // 
            btnAñadir.Text = "Añadir metal";
            btnAñadir.Click += btnAñadir_Click_1;
            // 
            // txtRadioactividad
            // 
            txtRadioactividad.Location = new Point(425, 232);
            txtRadioactividad.Name = "txtRadioactividad";
            txtRadioactividad.Size = new Size(158, 23);
            txtRadioactividad.TabIndex = 32;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(425, 148);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(158, 23);
            txtColor.TabIndex = 31;
            // 
            // lblColor
            // 
            lblColor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblColor.Location = new Point(454, 100);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(100, 35);
            lblColor.TabIndex = 29;
            lblColor.Text = "Color";
            lblColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRadioactividad
            // 
            lblRadioactividad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRadioactividad.Location = new Point(425, 184);
            lblRadioactividad.Name = "lblRadioactividad";
            lblRadioactividad.Size = new Size(158, 35);
            lblRadioactividad.TabIndex = 33;
            lblRadioactividad.Text = "NºRadioactividad";
            lblRadioactividad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMetal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 526);
            Controls.Add(lblRadioactividad);
            Controls.Add(txtRadioactividad);
            Controls.Add(txtColor);
            Controls.Add(lblColor);
            Name = "FrmMetal";
            Text = "FrmMetal";
            Controls.SetChildIndex(txtNAtomico, 0);
            Controls.SetChildIndex(txtSimbolo, 0);
            Controls.SetChildIndex(lblElemento, 0);
            Controls.SetChildIndex(btnAñadir, 0);
            Controls.SetChildIndex(lblNAtomico, 0);
            Controls.SetChildIndex(lblSimbolo, 0);
            Controls.SetChildIndex(lblMasaAtomica, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblGrupo, 0);
            Controls.SetChildIndex(lblPeriodo, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtGrupo, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(cboSubcategoria, 0);
            Controls.SetChildIndex(txtPeriodo, 0);
            Controls.SetChildIndex(txtMAtomica, 0);
            Controls.SetChildIndex(lblColor, 0);
            Controls.SetChildIndex(txtColor, 0);
            Controls.SetChildIndex(txtRadioactividad, 0);
            Controls.SetChildIndex(lblRadioactividad, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected ComboBox comboBox1;
        protected Label label1;
        protected TextBox txtRadioactividad;
        protected TextBox txtColor;
        protected Label label2;
        protected Label lblColor;
        protected Label lblRadioactividad;
    }
}