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
            this.lstVisor.Clear();

            foreach (Laboratorio l in this.laboratorios)
            {
                this.lstVisor.Text += l.ToString(); //+= sino se reemplaza
            }

        }

        private void rdoAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}