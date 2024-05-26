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
    public partial class FrmElemento : Form
    {
        private int nAtomico;
        private int grupo;
        private int periodo;
        private double masaAtomica;
        private string simbolo;
        private string nombre;

        private bool boolNAtomico = false;
        private bool boolGrupo = false;
        private bool boolPeriodo = false;
        private bool boolMasaAtomica = false;

        public int NAtomico { get { return this.nAtomico; }}
        public int Grupo { get { return this.grupo; } }
        public int Periodo { get { return this.periodo; } }
        public double MasaAtomica { get { return this.masaAtomica; } }
        public string Simbolo { get { return this.simbolo; } }
        public string Nombre { get { return this.nombre; } }
        public bool BoolNAtomico { get { return this.boolNAtomico; } }
        public bool BoolGrupo { get { return this.boolGrupo; } }
        public bool BoolPeriodo { get { return this.boolPeriodo; } }
        public bool BoolMasaAtomica { get { return this.boolMasaAtomica; } }



        public FrmElemento()
        {
            InitializeComponent();
        }

        private void btnAñadirLaboratorio_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtNAtomico.Text, out this.nAtomico)) { this.boolNAtomico = true; }
            else { MessageBox.Show("Ingrese un numero valido en NºAtomico"); }

            if (int.TryParse(txtGrupo.Text, out this.grupo)) { this.boolGrupo = true; }
            else { MessageBox.Show("Ingrese un numero valido en el grupo"); }

            if (int.TryParse(txtPeriodo.Text, out this.periodo)) { this.boolPeriodo = true; }
            else { MessageBox.Show("Ingrese un numero valido en el periodo"); }

            if (double.TryParse(txtMAtomica.Text, out this.masaAtomica)) { this.boolMasaAtomica = true; }
            else { MessageBox.Show("Ingrese un numero valido en la masa atomica"); }

        }
    }
}
