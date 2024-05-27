using Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Frm
{
    public partial class FrmPrincipal : Form
    {

        List<Laboratorio> laboratorios;
        private int lvIndex;
        private Laboratorio labo;


        public FrmPrincipal()
        {
            InitializeComponent();

            this.laboratorios = new List<Laboratorio>();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario principal.";

            Laboratorio lab1 = new Laboratorio("labo facu", "avella", ETamaños.Grande);

            this.laboratorios.Add(lab1);
            ActualizarVisor();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnAñadirLaboratorio_Click(object sender, EventArgs e)
        {
            FrmAñadirLaboratorio frmAñadirLaboratorio = new FrmAñadirLaboratorio();
            frmAñadirLaboratorio.ShowDialog();

            if (frmAñadirLaboratorio.DialogResult == DialogResult.OK)
            {
                this.laboratorios.Add(frmAñadirLaboratorio.MiLaboratorio);
                this.ActualizarVisor();
            }

        }

        private void ActualizarVisor()
        {
            this.lstVisorLaboratorios.Items.Clear();

            foreach (Laboratorio l in this.laboratorios)
            {
                this.lstVisorLaboratorios.Items.Add(l.ToString()); //+= sino se reemplaza
            }

        }

        private void ActualizarVisorElementos(List<Elemento> listaElementos)
        {

            this.lstVisorElementos.Items.Clear();

            foreach (Elemento e in listaElementos)
            {
                this.lstVisorElementos.Items.Add(e.ToString());
            }



        }

        private void rdoAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;


            if (listView.SelectedItems.Count > 0)
            {

                this.lvIndex = listView.SelectedItems[0].Index;

                // Verificar si hay un ítem seleccionado
                if (this.lvIndex >= 0 && lvIndex < laboratorios.Count)
                {

                    Laboratorio labo = laboratorios[lvIndex];

                    ActualizarVisorElementos(labo.Elementos);

                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            Laboratorio laboratorioSeleccionado = laboratorios[this.lvIndex];


            if (rbtMetal.Checked == true)
            {
                FrmMetal frmMetal = new FrmMetal();
                frmMetal.ShowDialog();
                if (frmMetal.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(frmMetal.MiElemento.ToString());
                    laboratorioSeleccionado += frmMetal.MiElemento;
                    ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                }
            }
            else if (rbtNoMetal.Checked == true)
            {
                FrmNoMetal frmNoMetal = new FrmNoMetal();
                frmNoMetal.ShowDialog();
                if (frmNoMetal.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(frmNoMetal.MiElemento.ToString());
                    laboratorioSeleccionado += frmNoMetal.MiElemento;
                    ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                }
            }
            else
            {
                FrmGas frmGas = new FrmGas();
                frmGas.ShowDialog();
                if (frmGas.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(frmGas.MiElemento.ToString());
                    laboratorios[this.lvIndex] += frmGas.MiElemento;
                    ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                }
            }

        }
    }
}
