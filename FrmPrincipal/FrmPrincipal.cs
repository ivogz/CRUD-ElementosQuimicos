using Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Frm
{
    public partial class FrmPrincipal : Form
    {

        List<Laboratorio> laboratorios;
        private int lvIndex;


        public FrmPrincipal()
        {
            InitializeComponent();

            this.laboratorios = new List<Laboratorio>();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario principal.";

            Laboratorio lab1 = new Laboratorio("labo facu", "avella", ETama�os.Grande);

            this.laboratorios.Add(lab1);
            ActualizarVisor();

        }

        private void btnA�adirLaboratorio_Click(object sender, EventArgs e)
        {
            FrmA�adirLaboratorio frmA�adirLaboratorio = new FrmA�adirLaboratorio();
            frmA�adirLaboratorio.ShowDialog();

            if (frmA�adirLaboratorio.DialogResult == DialogResult.OK)
            {
                this.laboratorios.Add(frmA�adirLaboratorio.MiLaboratorio);
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

                // Verificar si hay un �tem seleccionado
                if (this.lvIndex >= 0 && lvIndex < laboratorios.Count)
                {

                    Laboratorio labo = laboratorios[lvIndex];

                    ActualizarVisorElementos(labo.Elementos);

                }
            }
        }

        private void btnA�adir_Click(object sender, EventArgs e)
        {

            if (rbtMetal.Checked == true)
            {
                FrmMetal frmMetal = new FrmMetal();
                A�adirElementoYActualizarVisor(frmMetal);
            }
            else if (rbtNoMetal.Checked == true)
            {
                FrmNoMetal frmNoMetal = new FrmNoMetal();
                A�adirElementoYActualizarVisor(frmNoMetal);
            }
            else
            {
                FrmGas frmGas = new FrmGas();
                A�adirElementoYActualizarVisor(frmGas);
            }

        }

        private void A�adirElementoYActualizarVisor(FrmElemento frm)
        {

            Laboratorio laboratorioSeleccionado = laboratorios[this.lvIndex];

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(frm.MiElemento.ToString());
                laboratorios[this.lvIndex] += frm.MiElemento;
                ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
            }


        }


        private void OrdenarPorCheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {

                switch (radioButton.Name)
                {
                    case "rbtNumeroAtomico":
                        MessageBox.Show("rbtNumeroAtomico seleccionado");


                        break;
                    case "rbtNombre":
                        MessageBox.Show("rbtNombre seleccionado");
                        break;
                    case "rbtSimbolo":
                        MessageBox.Show("rbtSimbolo seleccionado");
                        break;
                    case "rbtGrupo":
                        MessageBox.Show("rbtGrupo seleccionado");
                        break;
                    case "rbtPeriodo":
                        MessageBox.Show("rbtPeriodo seleccionado");
                        break;
                    case "rbtMasaAtomica":
                        MessageBox.Show("rbtMasaAtomica seleccionado");
                        break;
                    case "rbtProtones":
                        MessageBox.Show("rbtProtones seleccionado");
                        break;
                    case "rbtNeutrones":
                        MessageBox.Show("rbtNeutrones seleccionado");
                        break;
                    case "rbtAscendente":
                        MessageBox.Show("rbtNeutrones seleccionado");
                        break;
                    case "rbtDescendente":
                        MessageBox.Show("rbtNeutrones seleccionado");
                        break;
                    default:
                        MessageBox.Show("RadioButton no reconocido");
                        break;
                }
            }
        }



        private void OrdenarPorAtributoAscDes(AtributosElemento atributo)
        {

            Laboratorio laboratorioSeleccionado = laboratorios[this.lvIndex];

            if (rbtAscendente.Checked == true)
            {
                ActualizarVisorElementos(laboratorioSeleccionado.OrdenarPor(AtributosElemento.NumeroAtomico, laboratorioSeleccionado.Elementos, true));
            }
            else
            {
                ActualizarVisorElementos(laboratorioSeleccionado.OrdenarPor(AtributosElemento.NumeroAtomico, laboratorioSeleccionado.Elementos, false));
            }

        }



    }
}
