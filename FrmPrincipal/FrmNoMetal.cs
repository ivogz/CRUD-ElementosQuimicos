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
    public partial class FrmNoMetal : FrmElemento
    {
        private ECategoriasNoMetales subcategoria;
        private EEstados estado;
        private double puntoDeEbullicion, puntoDeFusion;

        bool boolPuntoDeEbullicion, boolPuntoDeFusion = false;

        public ECategoriasNoMetales Subcategoria { get { return this.subcategoria; } }
        public EEstados Estado { get { return this.estado; } }
        public double PuntoDeEbullicion { get { return this.puntoDeEbullicion; } }
        public double PuntoDeFusion { get { return this.puntoDeFusion; } }

        public bool BoolPuntoDeEbullicion { get { return this.boolPuntoDeEbullicion; } }
        public bool BoolPuntoDeFusion { get { return this.boolPuntoDeFusion; } }

        public FrmNoMetal()
        {
            InitializeComponent();

            añadirOpcionesAComboBox();

            this.cboSubcategoria.SelectedIndex = 0;

            this.cboEstadoNatural.SelectedIndex = 0;

        }

        public FrmNoMetal(NoMetal nm) : base(nm)
        {
            InitializeComponent();

            añadirOpcionesAComboBox();


            int subcategoriaIndex = this.cboSubcategoria.FindStringExact(nm.Subcategoria.ToString());
            if (subcategoriaIndex != -1)
            {
                this.cboSubcategoria.SelectedIndex = subcategoriaIndex;
            }

            int estadoNaturalIndex = this.cboEstadoNatural.FindStringExact(nm.EstadoNatural.ToString());
            if (estadoNaturalIndex != -1)
            {
                this.cboEstadoNatural.SelectedIndex = estadoNaturalIndex;
            }

            txtPuntoDeEbullicion.Text = nm.PuntoEbullicion.ToString();
            txtPuntoDeFusion.Text = nm.PuntoFusion.ToString();

        }



        private void añadirOpcionesAComboBox()
        {
            foreach (ECategoriasNoMetales nm in Enum.GetValues(typeof(ECategoriasNoMetales)))
            {
                this.cboSubcategoria.Items.Add(nm);
            }

            foreach (EEstados e in Enum.GetValues(typeof(EEstados)))
            {
                this.cboEstadoNatural.Items.Add(e);
            }

        }

        protected override bool ObtenerValidaciones()
        {
            if (base.ObtenerValidaciones() && boolPuntoDeEbullicion && boolPuntoDeFusion)
            {
                return true;
            }
            return false;

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            boolPuntoDeFusion = TryParseCambiarBandera(txtPuntoDeFusion.Text, out this.puntoDeFusion, "Punto de fusion");
            boolPuntoDeEbullicion = TryParseCambiarBandera(txtPuntoDeEbullicion.Text, out this.puntoDeEbullicion, "Punto de ebullicion");

            this.subcategoria = (ECategoriasNoMetales)this.cboSubcategoria.SelectedItem;
            this.estado = (EEstados)this.cboEstadoNatural.SelectedItem;

            if (ObtenerValidaciones())
            {
                try
                {
                    this.MiElemento = new NoMetal(base.NAtomico, base.Nombre, base.Simbolo, base.Grupo, base.Periodo, base.MasaAtomica, this.Estado, this.PuntoDeEbullicion, this.PuntoDeFusion);
                    // Si la creación es exitosa, establecer el resultado del diálogo a OK y cerrar el formulario
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    // Mostrar un mensaje de error al usuario y permitirle volver a intentar
                    MessageBox.Show("Error al crear el Elemento, intente de nuevo");
                }
            }




        }
    }
}
