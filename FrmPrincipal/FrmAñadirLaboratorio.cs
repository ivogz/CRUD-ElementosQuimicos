using Entidades;
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

        private void btnAñadirLaboratorio_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ubicacion = txtUbicacion.Text;
            ETamaños tamaño = (ETamaños)this.cboTamaño.SelectedItem;

            try
            {
                this.miLaboratorio = new Laboratorio(nombre, ubicacion, tamaño);
                // Si la creación es exitosa, establecer el resultado del diálogo a OK y cerrar el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                // Mostrar un mensaje de error al usuario y permitirle volver a intentar
                MessageBox.Show("Error al crear el laboratorio");
            }

        }
    }
}
