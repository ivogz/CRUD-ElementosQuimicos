namespace Frm
{
    partial class FrmUsuariosLog
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
            lstRegistro = new ListBox();
            SuspendLayout();
            // 
            // lstRegistro
            // 
            lstRegistro.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lstRegistro.FormattingEnabled = true;
            lstRegistro.ItemHeight = 12;
            lstRegistro.Location = new Point(12, 12);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(590, 280);
            lstRegistro.TabIndex = 0;
            // 
            // FrmUsuariosLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 330);
            Controls.Add(lstRegistro);
            Name = "FrmUsuariosLog";
            Text = "FrmUsuariosLog";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstRegistro;
    }
}