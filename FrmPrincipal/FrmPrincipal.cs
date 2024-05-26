using Entidades;

namespace Frm
{
    public partial class FrmPrincipal : Form
    {

        List<Laboratorio> laboratorios;


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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
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

        private void rdoAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnA�adir_Click(object sender, EventArgs e)
        {

            if (rbtMetal.Checked == true)
            {
                FrmMetal frmMetal = new FrmMetal();
                frmMetal.ShowDialog();
                if (frmMetal.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(frmMetal.MiElemento.ToString());
                }
            }
            else if (rbtNoMetal.Checked == true)
            {
                FrmNoMetal frmNoMetal = new FrmNoMetal();
                frmNoMetal.ShowDialog();
                if (frmNoMetal.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(frmNoMetal.MiElemento.ToString());
                }
            }
            else
            {
                FrmGas frmGas = new FrmGas();
                frmGas.ShowDialog();
                if (frmGas.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(frmGas.MiElemento.ToString());
                }
            }
        }
    }
}