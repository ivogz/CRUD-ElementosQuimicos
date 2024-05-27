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
            lstVisorLaboratorios = new ListView();
            grpbOrdenar = new GroupBox();
            rbtNeutrones = new RadioButton();
            rbtPeriodo = new RadioButton();
            rbtProtones = new RadioButton();
            rbtNombre = new RadioButton();
            rbtSimbolo = new RadioButton();
            rbtMasaAtomica = new RadioButton();
            rbtNumeroAtomico = new RadioButton();
            rbtGrupo = new RadioButton();
            rbtAscendente = new RadioButton();
            rbtDescendente = new RadioButton();
            btnAñadirLaboratorio = new Button();
            lstVisorElementos = new ListView();
            grpElementos.SuspendLayout();
            grpbOrdenar.SuspendLayout();
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
            // 
            // rbtNoMetal
            // 
            rbtNoMetal.Location = new Point(204, 53);
            rbtNoMetal.Name = "rbtNoMetal";
            rbtNoMetal.Size = new Size(100, 25);
            rbtNoMetal.TabIndex = 1;
            rbtNoMetal.Text = "No Metal";
            rbtNoMetal.UseVisualStyleBackColor = false;
            // 
            // rbtGas
            // 
            rbtGas.Location = new Point(204, 84);
            rbtGas.Name = "rbtGas";
            rbtGas.Size = new Size(100, 25);
            rbtGas.TabIndex = 2;
            rbtGas.Text = "Gas";
            rbtGas.UseVisualStyleBackColor = true;
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
            btnAñadir.Click += btnAñadir_Click;
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
            // lstVisorLaboratorios
            // 
            lstVisorLaboratorios.Dock = DockStyle.Top;
            lstVisorLaboratorios.Location = new Point(0, 0);
            lstVisorLaboratorios.Name = "lstVisorLaboratorios";
            lstVisorLaboratorios.Size = new Size(708, 71);
            lstVisorLaboratorios.TabIndex = 6;
            lstVisorLaboratorios.UseCompatibleStateImageBehavior = false;
            lstVisorLaboratorios.SelectedIndexChanged += lstVisor_SelectedIndexChanged;
            // 
            // grpbOrdenar
            // 
            grpbOrdenar.Controls.Add(rbtNeutrones);
            grpbOrdenar.Controls.Add(rbtPeriodo);
            grpbOrdenar.Controls.Add(rbtProtones);
            grpbOrdenar.Controls.Add(rbtNombre);
            grpbOrdenar.Controls.Add(rbtSimbolo);
            grpbOrdenar.Controls.Add(rbtMasaAtomica);
            grpbOrdenar.Controls.Add(rbtNumeroAtomico);
            grpbOrdenar.Controls.Add(rbtGrupo);
            grpbOrdenar.Location = new Point(197, 322);
            grpbOrdenar.Name = "grpbOrdenar";
            grpbOrdenar.Size = new Size(499, 71);
            grpbOrdenar.TabIndex = 7;
            grpbOrdenar.TabStop = false;
            grpbOrdenar.Text = "Ordenar por:";
            // 
            // rbtNeutrones
            // 
            rbtNeutrones.AutoSize = true;
            rbtNeutrones.Location = new Point(377, 46);
            rbtNeutrones.Name = "rbtNeutrones";
            rbtNeutrones.Size = new Size(80, 19);
            rbtNeutrones.TabIndex = 7;
            rbtNeutrones.Text = "Neutrones";
            rbtNeutrones.UseVisualStyleBackColor = true;
            rbtNeutrones.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtPeriodo
            // 
            rbtPeriodo.AutoSize = true;
            rbtPeriodo.Location = new Point(129, 46);
            rbtPeriodo.Name = "rbtPeriodo";
            rbtPeriodo.Size = new Size(66, 19);
            rbtPeriodo.TabIndex = 6;
            rbtPeriodo.Text = "Periodo";
            rbtPeriodo.UseVisualStyleBackColor = true;
            rbtPeriodo.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtProtones
            // 
            rbtProtones.AutoSize = true;
            rbtProtones.Location = new Point(377, 22);
            rbtProtones.Name = "rbtProtones";
            rbtProtones.Size = new Size(72, 19);
            rbtProtones.TabIndex = 3;
            rbtProtones.Text = "Protones";
            rbtProtones.UseVisualStyleBackColor = true;
            rbtProtones.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtNombre
            // 
            rbtNombre.AutoSize = true;
            rbtNombre.Location = new Point(129, 22);
            rbtNombre.Name = "rbtNombre";
            rbtNombre.Size = new Size(69, 19);
            rbtNombre.TabIndex = 5;
            rbtNombre.Text = "Nombre";
            rbtNombre.UseVisualStyleBackColor = true;
            rbtNombre.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtSimbolo
            // 
            rbtSimbolo.AutoSize = true;
            rbtSimbolo.Location = new Point(253, 22);
            rbtSimbolo.Name = "rbtSimbolo";
            rbtSimbolo.Size = new Size(69, 19);
            rbtSimbolo.TabIndex = 4;
            rbtSimbolo.Text = "Simbolo";
            rbtSimbolo.UseVisualStyleBackColor = true;
            rbtSimbolo.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtMasaAtomica
            // 
            rbtMasaAtomica.AutoSize = true;
            rbtMasaAtomica.Location = new Point(253, 46);
            rbtMasaAtomica.Name = "rbtMasaAtomica";
            rbtMasaAtomica.Size = new Size(101, 19);
            rbtMasaAtomica.TabIndex = 2;
            rbtMasaAtomica.Text = "Masa Atomica";
            rbtMasaAtomica.UseVisualStyleBackColor = true;
            rbtMasaAtomica.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtNumeroAtomico
            // 
            rbtNumeroAtomico.AutoSize = true;
            rbtNumeroAtomico.Checked = true;
            rbtNumeroAtomico.Location = new Point(5, 22);
            rbtNumeroAtomico.Name = "rbtNumeroAtomico";
            rbtNumeroAtomico.Size = new Size(88, 19);
            rbtNumeroAtomico.TabIndex = 0;
            rbtNumeroAtomico.TabStop = true;
            rbtNumeroAtomico.Text = "Nº Atomico";
            rbtNumeroAtomico.UseVisualStyleBackColor = true;
            rbtNumeroAtomico.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtGrupo
            // 
            rbtGrupo.AutoSize = true;
            rbtGrupo.Location = new Point(5, 46);
            rbtGrupo.Name = "rbtGrupo";
            rbtGrupo.Size = new Size(58, 19);
            rbtGrupo.TabIndex = 1;
            rbtGrupo.Text = "Grupo";
            rbtGrupo.UseVisualStyleBackColor = true;
            rbtGrupo.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtAscendente
            // 
            rbtAscendente.Checked = true;
            rbtAscendente.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rbtAscendente.Location = new Point(535, 316);
            rbtAscendente.Name = "rbtAscendente";
            rbtAscendente.Size = new Size(80, 15);
            rbtAscendente.TabIndex = 9;
            rbtAscendente.TabStop = true;
            rbtAscendente.Text = "Ascendente";
            rbtAscendente.UseVisualStyleBackColor = true;
            rbtAscendente.CheckedChanged += OrdenarPorCheckedChanged;
            // 
            // rbtDescendente
            // 
            rbtDescendente.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rbtDescendente.Location = new Point(616, 316);
            rbtDescendente.Name = "rbtDescendente";
            rbtDescendente.Size = new Size(80, 15);
            rbtDescendente.TabIndex = 8;
            rbtDescendente.Text = "Descendente";
            rbtDescendente.UseVisualStyleBackColor = true;
            rbtDescendente.CheckedChanged += OrdenarPorCheckedChanged;
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
            // lstVisorElementos
            // 
            lstVisorElementos.Dock = DockStyle.Top;
            lstVisorElementos.Location = new Point(0, 71);
            lstVisorElementos.Name = "lstVisorElementos";
            lstVisorElementos.Size = new Size(708, 245);
            lstVisorElementos.TabIndex = 10;
            lstVisorElementos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 532);
            Controls.Add(lstVisorElementos);
            Controls.Add(rbtAscendente);
            Controls.Add(rbtDescendente);
            Controls.Add(btnAñadirLaboratorio);
            Controls.Add(grpbOrdenar);
            Controls.Add(lstVisorLaboratorios);
            Controls.Add(BtnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(grpElementos);
            Name = "FrmPrincipal";
            Text = "Form1";
            grpElementos.ResumeLayout(false);
            grpbOrdenar.ResumeLayout(false);
            grpbOrdenar.PerformLayout();
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
        private ListView lstVisorLaboratorios;
        private GroupBox grpbOrdenar;
        private RadioButton rbtNumeroAtomico;
        private RadioButton rbtSimbolo;
        private RadioButton rbtProtones;
        private RadioButton rbtGrupo;
        private RadioButton rbtMasaAtomica;
        private RadioButton rbtNeutrones;
        private RadioButton rbtPeriodo;
        private RadioButton rbtNombre;
        private Button btnAñadirLaboratorio;
        private RadioButton rbtDescendente;
        private RadioButton rbtAscendente;
        private ListView lstVisorElementos;
    }
}