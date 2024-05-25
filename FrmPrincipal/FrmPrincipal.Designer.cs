namespace Frm
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
            lstVisor = new ListView();
            groupBox1 = new GroupBox();
            rdoNeutrones = new RadioButton();
            rdoPeriodo = new RadioButton();
            rdoProtones = new RadioButton();
            rdoNombre = new RadioButton();
            rdoSimbolo = new RadioButton();
            rdoMasaAtomica = new RadioButton();
            rdoNumeroAtomico = new RadioButton();
            rdoGrupo = new RadioButton();
            rdoAscendente = new RadioButton();
            rdoDescendente = new RadioButton();
            btnAñadirLaboratorio = new Button();
            grpElementos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbtMetal
            // 
            rbtMetal.Checked = true;
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
            rbtNoMetal.Text = "No Metal";
            rbtNoMetal.UseVisualStyleBackColor = false;
            rbtNoMetal.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbtGas
            // 
            rbtGas.Location = new Point(204, 84);
            rbtGas.Name = "rbtGas";
            rbtGas.Size = new Size(100, 25);
            rbtGas.TabIndex = 2;
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
            btnAñadir.BackColor = Color.PaleTurquoise;
            btnAñadir.Cursor = Cursors.Hand;
            btnAñadir.Location = new Point(23, 28);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(150, 75);
            btnAñadir.TabIndex = 3;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.PaleTurquoise;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(352, 424);
            btnModificar.Margin = new Padding(12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 75);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.PaleTurquoise;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Location = new Point(539, 424);
            BtnEliminar.Margin = new Padding(25);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(150, 75);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // lstVisor
            // 
            lstVisor.Dock = DockStyle.Top;
            lstVisor.Location = new Point(0, 0);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(708, 316);
            lstVisor.TabIndex = 6;
            lstVisor.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoNeutrones);
            groupBox1.Controls.Add(rdoPeriodo);
            groupBox1.Controls.Add(rdoProtones);
            groupBox1.Controls.Add(rdoNombre);
            groupBox1.Controls.Add(rdoSimbolo);
            groupBox1.Controls.Add(rdoMasaAtomica);
            groupBox1.Controls.Add(rdoNumeroAtomico);
            groupBox1.Controls.Add(rdoGrupo);
            groupBox1.Location = new Point(197, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 71);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenar por:";
            // 
            // rdoNeutrones
            // 
            rdoNeutrones.AutoSize = true;
            rdoNeutrones.Location = new Point(377, 46);
            rdoNeutrones.Name = "rdoNeutrones";
            rdoNeutrones.Size = new Size(80, 19);
            rdoNeutrones.TabIndex = 7;
            rdoNeutrones.Text = "Neutrones";
            rdoNeutrones.UseVisualStyleBackColor = true;
            // 
            // rdoPeriodo
            // 
            rdoPeriodo.AutoSize = true;
            rdoPeriodo.Location = new Point(129, 46);
            rdoPeriodo.Name = "rdoPeriodo";
            rdoPeriodo.Size = new Size(66, 19);
            rdoPeriodo.TabIndex = 6;
            rdoPeriodo.Text = "Periodo";
            rdoPeriodo.UseVisualStyleBackColor = true;
            // 
            // rdoProtones
            // 
            rdoProtones.AutoSize = true;
            rdoProtones.Location = new Point(377, 22);
            rdoProtones.Name = "rdoProtones";
            rdoProtones.Size = new Size(72, 19);
            rdoProtones.TabIndex = 3;
            rdoProtones.Text = "Protones";
            rdoProtones.UseVisualStyleBackColor = true;
            // 
            // rdoNombre
            // 
            rdoNombre.AutoSize = true;
            rdoNombre.Location = new Point(129, 22);
            rdoNombre.Name = "rdoNombre";
            rdoNombre.Size = new Size(69, 19);
            rdoNombre.TabIndex = 5;
            rdoNombre.Text = "Nombre";
            rdoNombre.UseVisualStyleBackColor = true;
            // 
            // rdoSimbolo
            // 
            rdoSimbolo.AutoSize = true;
            rdoSimbolo.Location = new Point(253, 22);
            rdoSimbolo.Name = "rdoSimbolo";
            rdoSimbolo.Size = new Size(69, 19);
            rdoSimbolo.TabIndex = 4;
            rdoSimbolo.Text = "Simbolo";
            rdoSimbolo.UseVisualStyleBackColor = true;
            // 
            // rdoMasaAtomica
            // 
            rdoMasaAtomica.AutoSize = true;
            rdoMasaAtomica.Location = new Point(253, 46);
            rdoMasaAtomica.Name = "rdoMasaAtomica";
            rdoMasaAtomica.Size = new Size(101, 19);
            rdoMasaAtomica.TabIndex = 2;
            rdoMasaAtomica.Text = "Masa Atomica";
            rdoMasaAtomica.UseVisualStyleBackColor = true;
            // 
            // rdoNumeroAtomico
            // 
            rdoNumeroAtomico.AutoSize = true;
            rdoNumeroAtomico.Checked = true;
            rdoNumeroAtomico.Location = new Point(5, 22);
            rdoNumeroAtomico.Name = "rdoNumeroAtomico";
            rdoNumeroAtomico.Size = new Size(88, 19);
            rdoNumeroAtomico.TabIndex = 0;
            rdoNumeroAtomico.TabStop = true;
            rdoNumeroAtomico.Text = "Nº Atomico";
            rdoNumeroAtomico.UseVisualStyleBackColor = true;
            // 
            // rdoGrupo
            // 
            rdoGrupo.AutoSize = true;
            rdoGrupo.Location = new Point(5, 46);
            rdoGrupo.Name = "rdoGrupo";
            rdoGrupo.Size = new Size(58, 19);
            rdoGrupo.TabIndex = 1;
            rdoGrupo.Text = "Grupo";
            rdoGrupo.UseVisualStyleBackColor = true;
            // 
            // rdoAscendente
            // 
            rdoAscendente.Checked = true;
            rdoAscendente.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rdoAscendente.Location = new Point(535, 316);
            rdoAscendente.Name = "rdoAscendente";
            rdoAscendente.Size = new Size(80, 15);
            rdoAscendente.TabIndex = 9;
            rdoAscendente.TabStop = true;
            rdoAscendente.Text = "Ascendente";
            rdoAscendente.UseVisualStyleBackColor = true;
            rdoAscendente.CheckedChanged += rdoAscendente_CheckedChanged;
            // 
            // rdoDescendente
            // 
            rdoDescendente.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rdoDescendente.Location = new Point(616, 316);
            rdoDescendente.Name = "rdoDescendente";
            rdoDescendente.Size = new Size(80, 15);
            rdoDescendente.TabIndex = 8;
            rdoDescendente.Text = "Descendente";
            rdoDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAñadirLaboratorio
            // 
            btnAñadirLaboratorio.BackColor = Color.PaleTurquoise;
            btnAñadirLaboratorio.Cursor = Cursors.Hand;
            btnAñadirLaboratorio.Location = new Point(12, 328);
            btnAñadirLaboratorio.Name = "btnAñadirLaboratorio";
            btnAñadirLaboratorio.Size = new Size(173, 59);
            btnAñadirLaboratorio.TabIndex = 4;
            btnAñadirLaboratorio.Text = "Añadir laboratorio";
            btnAñadirLaboratorio.UseVisualStyleBackColor = false;
            btnAñadirLaboratorio.Click += btnAñadirLaboratorio_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 532);
            Controls.Add(rdoAscendente);
            Controls.Add(rdoDescendente);
            Controls.Add(btnAñadirLaboratorio);
            Controls.Add(groupBox1);
            Controls.Add(lstVisor);
            Controls.Add(BtnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(grpElementos);
            Name = "FrmPrincipal";
            Text = "Form1";
            grpElementos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ListView lstVisor;
        private GroupBox groupBox1;
        private RadioButton rdoNumeroAtomico;
        private RadioButton rdoSimbolo;
        private RadioButton rdoProtones;
        private RadioButton rdoGrupo;
        private RadioButton rdoMasaAtomica;
        private RadioButton rdoNeutrones;
        private RadioButton rdoPeriodo;
        private RadioButton rdoNombre;
        private Button btnAñadirLaboratorio;
        private RadioButton rdoDescendente;
        private RadioButton rdoAscendente;
    }
}