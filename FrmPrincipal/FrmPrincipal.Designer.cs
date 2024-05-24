namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            rbtMetal = new RadioButton();
            rbtNoMetal = new RadioButton();
            rbtGas = new RadioButton();
            grpElementos = new GroupBox();
            btnAñadir = new Button();
            btnModificar = new Button();
            BtnEliminar = new Button();
            listView1 = new ListView();
            grpElementos.SuspendLayout();
            SuspendLayout();
            // 
            // rbtMetal
            // 
            rbtMetal.Location = new Point(204, 22);
            rbtMetal.Name = "rbtMetal";
            rbtMetal.Size = new Size(100, 25);
            rbtMetal.TabIndex = 0;
            rbtMetal.TabStop = true;
            rbtMetal.Text = "Metal";
            rbtMetal.UseVisualStyleBackColor = true;
            rbtMetal.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtNoMetal
            // 
            rbtNoMetal.Location = new Point(204, 53);
            rbtNoMetal.Name = "rbtNoMetal";
            rbtNoMetal.Size = new Size(100, 25);
            rbtNoMetal.TabIndex = 1;
            rbtNoMetal.TabStop = true;
            rbtNoMetal.Text = "No Metal";
            rbtNoMetal.UseVisualStyleBackColor = true;
            rbtNoMetal.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbtGas
            // 
            rbtGas.Location = new Point(204, 84);
            rbtGas.Name = "rbtGas";
            rbtGas.Size = new Size(100, 25);
            rbtGas.TabIndex = 2;
            rbtGas.TabStop = true;
            rbtGas.Text = "Gas";
            rbtGas.UseVisualStyleBackColor = true;
            rbtGas.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // grpElementos
            // 
            grpElementos.Controls.Add(btnAñadir);
            grpElementos.Controls.Add(rbtNoMetal);
            grpElementos.Controls.Add(rbtGas);
            grpElementos.Controls.Add(rbtMetal);
            grpElementos.Location = new Point(12, 396);
            grpElementos.Name = "grpElementos";
            grpElementos.Size = new Size(325, 125);
            grpElementos.TabIndex = 3;
            grpElementos.TabStop = false;
            grpElementos.Text = "Elementos";
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(23, 28);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(150, 75);
            btnAñadir.TabIndex = 3;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(352, 424);
            btnModificar.Margin = new Padding(12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 75);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(539, 424);
            BtnEliminar.Margin = new Padding(25);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(150, 75);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Top;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(708, 351);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 532);
            Controls.Add(listView1);
            Controls.Add(BtnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(grpElementos);
            Name = "FrmPrincipal";
            Text = "Form1";
            grpElementos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbtMetal;
        private RadioButton rbtNoMetal;
        private RadioButton rbtGas;
        private GroupBox grpElementos;
        private Button btnAñadir;
        private Button btnModificar;
        private Button BtnEliminar;
        private ListView listView1;
    }
}