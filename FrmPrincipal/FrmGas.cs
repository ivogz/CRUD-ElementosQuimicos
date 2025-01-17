﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm
{
    public partial class FrmGas : FrmElemento
    {

        private ECategoriasGases subcategoria;
        private string lugarDeObtencion, usoPrincipal;

        bool boolLugarDeObtencion, boolUsoPrincipal = false;

        public ECategoriasGases Subcategoria { get { return this.subcategoria; } }

        public string LugarDeObtencion { get { return this.lugarDeObtencion; } }
        public string UsoPrincipal { get { return this.usoPrincipal; } }

        public bool BoolLugarDeObtencion { get { return this.boolLugarDeObtencion; } }
        public bool BoolUsoPrincipal { get { return this.boolUsoPrincipal; } }

        public FrmGas()
        {
            InitializeComponent();

            añadirOpcionesAComboBox();

            this.cboSubcategoria.SelectedIndex = 0;

        }

        public FrmGas(Gas gas) : base(gas)
        {
            InitializeComponent();

            añadirOpcionesAComboBox();

            int subcategoriaIndex = this.cboSubcategoria.FindStringExact(gas.Subcategoria.ToString());
            if (subcategoriaIndex != -1)
            {
                this.cboSubcategoria.SelectedIndex = subcategoriaIndex;
            }

            this.txtLugarDeObtencion.Text = gas.LugarDeObtencion;
            this.txtUsoPrincipal.Text = gas.UsoPrincipal;



        }

        private void añadirOpcionesAComboBox() 
        {
            foreach (ECategoriasGases g in Enum.GetValues(typeof(ECategoriasGases)))
            {
                this.cboSubcategoria.Items.Add(g);
            }


        }

        protected override bool ObtenerValidaciones()
        {
            if (base.ObtenerValidaciones() && boolLugarDeObtencion && boolUsoPrincipal)
            {
                return true;
            }
            return false;

        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            if (ValidarString(txtLugarDeObtencion.Text, "Por favor ingrese un lugar de obtencion valido")) { this.lugarDeObtencion = txtLugarDeObtencion.Text; boolLugarDeObtencion = true; }
            if (ValidarString(txtUsoPrincipal.Text, "Por favor ingrese un uso principal valido")) { this.usoPrincipal = txtUsoPrincipal.Text; boolUsoPrincipal = true; }

            this.subcategoria = (ECategoriasGases)this.cboSubcategoria.SelectedItem;

            if (ObtenerValidaciones())
            {
                try
                {
                    this.MiElemento = new Gas(base.NAtomico, base.Nombre, base.Simbolo, base.Grupo, base.Periodo, base.MasaAtomica, this.LugarDeObtencion, this.UsoPrincipal);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al crear el Elemento, intente de nuevo");
                }
            }
        }
    }
}
