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
    public partial class FrmMetal : FrmElemento
    {

        private ECategoriasMetales subcategoria;
        private int cantidadRadioactividad;
        private string color;

        bool boolRadioactividad, boolColor = false;

        public ECategoriasMetales Subcategoria { get { return this.subcategoria; } }
        public int CantidadRadioactividad { get { return this.cantidadRadioactividad; } }
        public string Color { get { return this.color; } }
        public bool BoolRadioactividad { get { return this.boolRadioactividad; } }

        public bool BoolColor { get { return this.boolColor; } }

        public FrmMetal()
        {
            InitializeComponent();

            añadirOpcionesAComboBox();

            this.cboSubcategoria.SelectedIndex = 0;


        }

        public FrmMetal(Metal metal) : base(metal)
        {
            InitializeComponent();

            añadirOpcionesAComboBox();

            int subcategoriaIndex = this.cboSubcategoria.FindStringExact(metal.Subcategoria.ToString());
            if (subcategoriaIndex != -1)
            {
                this.cboSubcategoria.SelectedIndex = subcategoriaIndex;
            }

            txtRadioactividad.Text = metal.CantidadRadioactividad.ToString();
            txtColor.Text = metal.Color;




        }



        private void añadirOpcionesAComboBox()
        {
            foreach (ECategoriasMetales m in Enum.GetValues(typeof(ECategoriasMetales)))
            {
                this.cboSubcategoria.Items.Add(m);
            }


        }

        protected override bool ObtenerValidaciones()
        {
            if (base.ObtenerValidaciones() && boolRadioactividad && boolColor)
            {
                return true;
            }
            return false;

        }


        private void btnAñadir_Click_1(object sender, EventArgs e)
        {



            boolRadioactividad = TryParseCambiarBandera(txtRadioactividad.Text, out this.cantidadRadioactividad, "Radioactividad");

            if (ValidarString(txtColor.Text, "Por favor ingresar un color valido.")) { this.color = txtColor.Text; boolColor = true; }

            this.subcategoria = (ECategoriasMetales)this.cboSubcategoria.SelectedItem;

            if (ObtenerValidaciones())
            {
                try
                {
                    this.MiElemento = new Metal(base.NAtomico, base.Nombre, base.Simbolo, base.Grupo, base.Periodo, this.subcategoria, base.MasaAtomica, this.CantidadRadioactividad, this.Color);
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
