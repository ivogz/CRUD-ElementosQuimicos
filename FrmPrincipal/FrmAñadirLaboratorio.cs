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
    public partial class FrmAñadirLaboratorio : Form
    {
        protected List<Elemento> elementos;
        protected Laboratorio miLaboratorio;

        public Laboratorio MiLaboratorio { get { return this.miLaboratorio; } }


        public FrmAñadirLaboratorio()
        {
            InitializeComponent();
            this.elementos = new List<Elemento>();


            //AGREGAR OPCIONES A COMBO BOX YY PONER UNA PREDETERMINADA 
            foreach (ETamaños t in Enum.GetValues(typeof(ETamaños)))
            {
                this.cboTamaño.Items.Add(t);
            }
            this.cboTamaño.SelectedIndex = 2; //ETamaño.Mediano

        }

        public FrmAñadirLaboratorio(Laboratorio lab) : this()
        {
            txtNombre.Text = lab.Nombre;
            txtUbicacion.Text = lab.Ubicacion;

            int TamañoIndex = this.cboTamaño.FindStringExact(lab.Tamaño.ToString());
            if (TamañoIndex != -1)
            {
                this.cboTamaño.SelectedIndex = TamañoIndex;
            }

            this.cboTamaño.Enabled = false;
        }

        private void btnAñadirLaboratorio_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ubicacion = txtUbicacion.Text;
            ETamaños tamaño = (ETamaños)this.cboTamaño.SelectedItem;

            try
            {
                this.miLaboratorio = new Laboratorio(nombre, ubicacion, tamaño);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el laboratorio");
            }

        }
    }
}
