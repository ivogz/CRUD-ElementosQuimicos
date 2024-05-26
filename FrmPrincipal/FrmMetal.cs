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

        private Elemento miElemento;

        private ECategoriasMetales subcategoria;
        private int cantidadRadioactividad;
        private string color;

        bool boolRadioactividad = false;

        public Elemento MiElemento { get { return this.miElemento; } }
        public ECategoriasMetales Subcategoria { get { return this.subcategoria; } }
        public int CantidadRadioactividad { get { return this.cantidadRadioactividad; } }
        public string Color { get { return this.color; } }
        public bool BoolRadioactividad { get { return this.boolRadioactividad; } }


        public FrmMetal()
        {
            InitializeComponent();


            //AGREGAR OPCIONES A COMBO BOX YY PONER UNA PREDETERMINADA 
            foreach (ECategoriasMetales m in Enum.GetValues(typeof(ECategoriasMetales)))
            {
                this.cboSubcategoria.Items.Add(m);
            }
            this.cboSubcategoria.SelectedIndex = 0;


        }

        private void btnAñadirLaboratorio_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtRadioactividad.Text, out this.cantidadRadioactividad)) { boolRadioactividad = true; }
            else { MessageBox.Show("Ingrese un numero valido en la radioactividad"); }



            this.color = txtColor.Text; 
            this.subcategoria = (ECategoriasMetales)this.cboSubcategoria.SelectedItem;

            if (base.BoolNAtomico && base.BoolGrupo && base.BoolPeriodo && base.BoolMasaAtomica && this.BoolRadioactividad)
            {
                try
                {
                    this.miElemento = new Metal(base.NAtomico, base.Nombre, base.Simbolo, base.Grupo, base.Periodo, this.subcategoria, base.MasaAtomica, this.CantidadRadioactividad, this.Color);
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
