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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
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
            columnHeader1 = new ColumnHeader();
            toolStrip1 = new ToolStrip();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripBtnSerializar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripBtnDeserializar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripBtnRegistros = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            toolStrip2 = new ToolStrip();
            lblNombreUsuario = new ToolStripLabel();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripSeparator9 = new ToolStripSeparator();
            lblFecha = new ToolStripLabel();
            btnTraerBD = new Button();
            btnSubirBD = new Button();
            grpElementos.SuspendLayout();
            grpbOrdenar.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
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
            btnModificar.Click += btnModificar_Click;
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
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // lstVisorLaboratorios
            // 
            lstVisorLaboratorios.Dock = DockStyle.Top;
            lstVisorLaboratorios.Location = new Point(0, 0);
            lstVisorLaboratorios.Name = "lstVisorLaboratorios";
            lstVisorLaboratorios.Size = new Size(841, 71);
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
            lstVisorElementos.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lstVisorElementos.Dock = DockStyle.Top;
            lstVisorElementos.Location = new Point(0, 71);
            lstVisorElementos.Name = "lstVisorElementos";
            lstVisorElementos.Size = new Size(841, 245);
            lstVisorElementos.TabIndex = 10;
            lstVisorElementos.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator6, toolStripSeparator3, toolStripBtnSerializar, toolStripSeparator4, toolStripBtnDeserializar, toolStripSeparator2, toolStripSeparator5, toolStripBtnRegistros, toolStripSeparator7, toolStripSeparator1 });
            toolStrip1.Location = new Point(337, 504);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(255, 28);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 28);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // toolStripBtnSerializar
            // 
            toolStripBtnSerializar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnSerializar.Image = (Image)resources.GetObject("toolStripBtnSerializar.Image");
            toolStripBtnSerializar.ImageTransparentColor = Color.Magenta;
            toolStripBtnSerializar.Name = "toolStripBtnSerializar";
            toolStripBtnSerializar.Size = new Size(57, 25);
            toolStripBtnSerializar.Text = "Serializar";
            toolStripBtnSerializar.Click += toolStripBtnSerializar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 28);
            // 
            // toolStripBtnDeserializar
            // 
            toolStripBtnDeserializar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnDeserializar.Image = (Image)resources.GetObject("toolStripBtnDeserializar.Image");
            toolStripBtnDeserializar.ImageTransparentColor = Color.Magenta;
            toolStripBtnDeserializar.Name = "toolStripBtnDeserializar";
            toolStripBtnDeserializar.Size = new Size(70, 25);
            toolStripBtnDeserializar.Text = "Deserializar";
            toolStripBtnDeserializar.Click += toolStripBtnDeserializar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 28);
            // 
            // toolStripBtnRegistros
            // 
            toolStripBtnRegistros.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnRegistros.Image = (Image)resources.GetObject("toolStripBtnRegistros.Image");
            toolStripBtnRegistros.ImageTransparentColor = Color.Magenta;
            toolStripBtnRegistros.Name = "toolStripBtnRegistros";
            toolStripBtnRegistros.Size = new Size(59, 25);
            toolStripBtnRegistros.Text = "Registros";
            toolStripBtnRegistros.Click += toolStripBtnRegistros_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 28);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { lblNombreUsuario, toolStripSeparator10, toolStripSeparator9, lblFecha });
            toolStrip2.Location = new Point(454, 396);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(161, 29);
            toolStrip2.TabIndex = 12;
            toolStrip2.Text = "toolStrip2";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(51, 26);
            lblNombreUsuario.Text = "Nombre";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 29);
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 29);
            // 
            // lblFecha
            // 
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 26);
            lblFecha.Text = "Fecha";
            // 
            // btnTraerBD
            // 
            btnTraerBD.BackColor = Color.PaleTurquoise;
            btnTraerBD.Cursor = Cursors.Hand;
            btnTraerBD.Location = new Point(724, 332);
            btnTraerBD.Margin = new Padding(25);
            btnTraerBD.Name = "btnTraerBD";
            btnTraerBD.Size = new Size(93, 51);
            btnTraerBD.TabIndex = 13;
            btnTraerBD.Text = "Traer datos de BD";
            btnTraerBD.UseVisualStyleBackColor = false;
            btnTraerBD.Click += btnTraerBD_Click;
            // 
            // btnSubirBD
            // 
            btnSubirBD.BackColor = Color.PaleTurquoise;
            btnSubirBD.Cursor = Cursors.Hand;
            btnSubirBD.Location = new Point(724, 418);
            btnSubirBD.Margin = new Padding(25);
            btnSubirBD.Name = "btnSubirBD";
            btnSubirBD.Size = new Size(93, 51);
            btnSubirBD.TabIndex = 14;
            btnSubirBD.Text = "Subir datos a BD";
            btnSubirBD.UseVisualStyleBackColor = false;
            btnSubirBD.Click += btnSubirBD_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 532);
            Controls.Add(btnSubirBD);
            Controls.Add(btnTraerBD);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
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
            FormClosing += FrmPrincipal_FormClosing;
            grpElementos.ResumeLayout(false);
            grpbOrdenar.ResumeLayout(false);
            grpbOrdenar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnSerializar;
        private ToolStripButton toolStripBtnDeserializar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton toolStripBtnRegistros;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStrip toolStrip2;
        private ToolStripLabel lblNombreUsuario;
        private ToolStripLabel lblFecha;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSeparator toolStripSeparator9;
        private ColumnHeader columnHeader1;
        private Button btnTraerBD;
        private Button btnSubirBD;
    }
}