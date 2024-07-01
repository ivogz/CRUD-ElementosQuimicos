using Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Frm
{
    public partial class FrmPrincipal : Form
    {

        List<Laboratorio> laboratorios;
        private int lvIndex;
        private List<Elemento> listaEnUso;
        private Usuario usuarioEnUso;


        public FrmPrincipal()
        {
            InitializeComponent();

            this.laboratorios = new List<Laboratorio>();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario principal.";

        }

        public FrmPrincipal(Usuario usuarioExitoso) : this()
        {
            this.usuarioEnUso = usuarioExitoso;
            this.lblNombreUsuario.Text = this.usuarioEnUso.Nombre;
            this.lblFecha.Text = $"{DateTime.Now:yyyy-MM-dd}";
            ActualizarVisor();
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

            foreach (ColumnHeader columna in lstVisorElementos.Columns)
            {
                columna.Width = 200;
            }
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

            if (rbtMetal.Checked == true)
            {
                FrmMetal frmMetal = new FrmMetal();
                AñadirElementoYActualizarVisor(frmMetal);
            }
            else if (rbtNoMetal.Checked == true)
            {
                FrmNoMetal frmNoMetal = new FrmNoMetal();
                AñadirElementoYActualizarVisor(frmNoMetal);
            }
            else
            {
                FrmGas frmGas = new FrmGas();
                AñadirElementoYActualizarVisor(frmGas);
            }

        }

        private void AñadirElementoYActualizarVisor(FrmElemento frm)
        {
            if (this.laboratorios.Count > 0)
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
            else
            {
                MessageBox.Show("Falta añadir un laboratorio");
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
                        OrdenarPorAtributoAscDes(AtributosElemento.NumeroAtomico);
                        break;
                    case "rbtNombre":
                        OrdenarPorAtributoAscDes(AtributosElemento.Nombre);
                        break;
                    case "rbtSimbolo":
                        OrdenarPorAtributoAscDes(AtributosElemento.Simbolo);
                        break;
                    case "rbtGrupo":
                        OrdenarPorAtributoAscDes(AtributosElemento.Grupo);
                        break;
                    case "rbtPeriodo":
                        OrdenarPorAtributoAscDes(AtributosElemento.Periodo);
                        break;
                    case "rbtMasaAtomica":
                        OrdenarPorAtributoAscDes(AtributosElemento.MasaAtomica);
                        break;
                    case "rbtProtones":
                        OrdenarPorAtributoAscDes(AtributosElemento.Protones);
                        break;
                    case "rbtNeutrones":
                        OrdenarPorAtributoAscDes(AtributosElemento.Neutrones);
                        break;
                    case "rbtAscendente":
                        darVueltaListaYActualizar();
                        break;
                    case "rbtDescendente":
                        darVueltaListaYActualizar();
                        break;
                    default:
                        MessageBox.Show("RadioButton no reconocido");
                        OrdenarPorAtributoAscDes(AtributosElemento.NumeroAtomico);
                        break;
                }
            }
        }

        private void darVueltaListaYActualizar()
        {

            if (this.listaEnUso != null && this.listaEnUso.Count > 0)
            {
                this.listaEnUso.Reverse();
                ActualizarVisorElementos(this.listaEnUso);

            }


        }

        private void OrdenarPorAtributoAscDes(AtributosElemento atributo)
        {
            if (laboratorios.Count > 1)
            {
                Laboratorio laboratorioSeleccionado = laboratorios[this.lvIndex];

                if (rbtAscendente.Checked == true)
                {
                    this.listaEnUso = laboratorioSeleccionado.OrdenarPor(atributo, laboratorioSeleccionado.Elementos, true);
                    ActualizarVisorElementos(this.listaEnUso);
                }
                else
                {
                    this.listaEnUso = laboratorioSeleccionado.OrdenarPor(atributo, laboratorioSeleccionado.Elementos, false);
                    ActualizarVisorElementos(this.listaEnUso);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (lstVisorElementos.SelectedItems.Count == 1)
            {

                int indice = this.lstVisorElementos.SelectedIndices[0];

                if (indice != -1)
                {
                    DialogResult confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (confirm == DialogResult.OK)
                    {
                        if (this.listaEnUso == null)
                        {
                            this.laboratorios[lvIndex].Elementos.RemoveAt(indice);
                            this.ActualizarVisorElementos(this.laboratorios[lvIndex].Elementos);
                        }
                        else
                        {
                            this.laboratorios[lvIndex].Elementos.Remove(this.listaEnUso[indice]);
                            this.ActualizarVisorElementos(this.laboratorios[lvIndex].Elementos);
                        }
                    }
                }


            }
            else if (lstVisorLaboratorios.SelectedItems.Count == 1)
            {
                this.laboratorios.RemoveAt(lvIndex);
                ActualizarVisor();
                this.lstVisorElementos.Items.Clear();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Laboratorio laboratorioSeleccionado = this.laboratorios[lvIndex];

            if (lstVisorElementos.SelectedItems.Count == 1)
            {
                int indice = this.lstVisorElementos.SelectedIndices[0];

                if (indice != -1)
                {
                    if (laboratorioSeleccionado.Elementos[indice] is Gas gas)
                    {
                        FrmGas frmGas = new(gas);
                        frmGas.ShowDialog();

                        if (frmGas.DialogResult == DialogResult.OK)
                        {
                            laboratorioSeleccionado.Elementos[indice] = frmGas.MiElemento;
                            ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                        }
                    }
                    else if (laboratorioSeleccionado.Elementos[indice] is NoMetal nm)
                    {
                        FrmNoMetal frmNoMetal = new(nm);
                        frmNoMetal.ShowDialog();

                        if (frmNoMetal.DialogResult == DialogResult.OK)
                        {
                            laboratorioSeleccionado.Elementos[indice] = frmNoMetal.MiElemento;
                            ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                        }
                    }
                    else if (laboratorioSeleccionado.Elementos[indice] is Metal metal)
                    {
                        FrmMetal frmMetal = new(metal);
                        frmMetal.ShowDialog();
                        if (frmMetal.DialogResult == DialogResult.OK)
                        {
                            laboratorioSeleccionado.Elementos[indice] = frmMetal.MiElemento;
                            ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                        }
                    }
                }
            }
            else if (lstVisorLaboratorios.SelectedItems.Count == 1)
            {
                FrmAñadirLaboratorio frmLabo = new(laboratorioSeleccionado);
                frmLabo.ShowDialog();

                if (frmLabo.DialogResult == DialogResult.OK)
                {
                    this.laboratorios[lvIndex] = frmLabo.MiLaboratorio;
                    ActualizarVisor();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripBtnSerializar_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog.Title = "Save an XML File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = saveFileDialog.FileName;

                    Serializacion srlz = new Serializacion(selectedPath);

                    srlz.SerializacionXML(this.laboratorios);
                }

            }



        }

        private void toolStripBtnDeserializar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = "Open an XML File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;

                    try
                    {
                        Serializacion srlz = new Serializacion(selectedPath);
                        List<Laboratorio> laboratoriosDeserializados = srlz.DeserializarXML();

                        if (laboratoriosDeserializados != null)
                        {
                            this.laboratorios = laboratoriosDeserializados;
                            ActualizarVisor();
                        }
                        else
                        {
                            MessageBox.Show("El archivo XML no contiene datos válidos.", "Error de deserialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al deserializar el archivo: {ex.Message}", "Error de deserialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripBtnRegistros_Click(object sender, EventArgs e)
        {
            FrmUsuariosLog frmRegistros = new FrmUsuariosLog();
            frmRegistros.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?",
                                          "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
