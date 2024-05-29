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
        private int nAtomico, grupo, periodo;
        private double masaAtomica;
        private string simbolo, nombre;

        private bool boolNAtomico, boolGrupo, boolPeriodo, boolMasaAtomica, boolSimbolo, boolNombre = false;

        Elemento miElemento;

        public Elemento MiElemento { get { return this.miElemento; }  set { this.miElemento = value; } }

        public int NAtomico { get { return this.nAtomico; } }
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

        public FrmElemento(Elemento elemento): this()
        {
            this.MiElemento = elemento;
            this.txtNAtomico.Text = elemento.NAtomico.ToString();
            this.txtNombre.Text = elemento.Nombre;
            this.txtSimbolo.Text = elemento.Simbolo;
            this.txtGrupo.Text = elemento.Grupo.ToString();
            this.txtPeriodo.Text = elemento.Periodo.ToString();
            this.txtMAtomica.Text = elemento.MasaAtomica.ToString();

            this.txtNAtomico.Enabled = false;
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {

            this.boolNAtomico = TryParseCambiarBandera(txtNAtomico.Text, out this.nAtomico, "Numero Atomico");
            this.boolGrupo = TryParseCambiarBandera(txtGrupo.Text, out this.grupo, "Grupo");
            this.boolPeriodo = TryParseCambiarBandera(txtPeriodo.Text, out this.periodo, "Periodo");
            this.boolMasaAtomica = TryParseCambiarBandera(txtMAtomica.Text, out this.masaAtomica, "Masa Atomica");
            if (ValidarString(txtSimbolo.Text, "Por favor ingrese un simbolo valido."))
            {
                if (txtSimbolo.Text.Length <= 2) { this.simbolo = txtSimbolo.Text; boolSimbolo = true; }
                else { MessageBox.Show("Por favor ingrese un simbolo de maximo 2 caracteres."); }
            }
            if (ValidarString(txtNombre.Text, "Por favor ingrese un nombre valido.")) { this.nombre = txtNombre.Text; boolNombre = true; }

        }

        protected virtual bool ObtenerValidaciones()
        {
            if (this.BoolNAtomico && this.boolGrupo && this.boolPeriodo && this.boolMasaAtomica && this.boolNombre && this.boolSimbolo)
            {
                return true;
            }
            return false;
        }

        protected bool ValidarString(string str, string messageBox)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return true;
            }
            else
            {
                MessageBox.Show(messageBox);
                return false;
            }
        }

        protected bool TryParseCambiarBandera(string str, out double value, string strMessageBox)
        {
            if (double.TryParse(str, out value) && double.Parse(str) > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Por favor ingrese un numero valido en: {strMessageBox}");
                return false;
            }
        }

        protected bool TryParseCambiarBandera(string str, out int value, string strMessageBox)
        {
            if (int.TryParse(str, out value) && int.Parse(str) > 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Ingrese un numero valido: {strMessageBox}");
                return false;
            }
        }

    }
}
