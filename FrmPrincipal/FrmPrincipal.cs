using Entidades;
using System;
using System.Threading;
using System.Media;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.IO;
using System.Linq.Expressions;

namespace Frm
{
    public partial class FrmPrincipal : Form
    {

        List<Laboratorio> laboratorios;
        private int lvIndex;
        private List<Elemento> listaEnUso;
        private Usuario usuarioEnUso;
        private Color[] colores = { Color.Aquamarine, Color.SpringGreen, Color.DarkSlateGray, Color.Plum, Color.MediumPurple, Color.PaleTurquoise };
        private int indiceColor = 0;
        private List<Button> listaBotones;


        public FrmPrincipal()
        {
            InitializeComponent();

            this.laboratorios = new List<Laboratorio>();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario principal.";

            Task tMusica = Task.Run(ReproducirMusica);

            this.btn.Click += this.EventoPersonalizado;
            AñadirBotonesLista();

        }

        #region evento

        public void EventoPersonalizado(object sender, EventArgs e)
        {

            if (this.indiceColor == colores.Length) { this.indiceColor = 0; }

            foreach (Button b in listaBotones)
            {

                b.BackColor = colores[this.indiceColor];

            }

            indiceColor++;

        }

        private void AñadirBotonesLista()
        {
            listaBotones = new List<Button>
            {
                btnAñadirLaboratorio,
                btnAñadir,
                btnModificar,
                BtnEliminar,
                btnModificarDatoBD,
                btnEliminarDatoBD,
                btnSubirBD,
                btnTraerBD,
                btnCambiarInformacion,
                btn
            };
        }

        #endregion

        public FrmPrincipal(Usuario usuarioExitoso) : this()
        {
            this.usuarioEnUso = usuarioExitoso;
            this.lblNombreUsuario.Text = this.usuarioEnUso.Nombre;
            this.lblFecha.Text = $"{DateTime.Now:yyyy-MM-dd}";
            ActualizarVisor();

            switch (this.usuarioEnUso.Perfil)
            {
                case "vendedor":
                    MessageBox.Show("Usted solo puede ver el CRUD.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAñadir.Enabled = false;
                    btnModificar.Enabled = false;
                    BtnEliminar.Enabled = false;
                    btnSubirBD.Enabled = false;
                    btnModificarDatoBD.Enabled = false;
                    btnEliminarDatoBD.Enabled = false;
                    break;
                case "supervisor":
                    MessageBox.Show("Usted no puede eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnEliminar.Enabled = false;
                    btnEliminarDatoBD.Enabled = false;
                    break;
                case "administrador":
                    MessageBox.Show("Usted tiene el control total", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
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

        private void btnAñadirLaboratorio_Click(object sender, EventArgs e)
        {
            if (this.laboratorios.Count == 0)
            {
                FrmAñadirLaboratorio frmAñadirLaboratorio = new FrmAñadirLaboratorio();
                frmAñadirLaboratorio.ShowDialog();

                if (frmAñadirLaboratorio.DialogResult == DialogResult.OK)
                {
                    this.laboratorios.Add(frmAñadirLaboratorio.MiLaboratorio);
                    this.ActualizarVisor();
                }
            }
            else
            {
                MessageBox.Show("Ya existe un laboratorio");
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
                    if (laboratorioSeleccionado.Elementos.Count > 0)
                    {
                        frm.MiElemento.CambiarInformacion = laboratorioSeleccionado.Elementos[0].CambiarInformacion;
                    }
                    laboratorioSeleccionado += frm.MiElemento;
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
            if (laboratorios.Count > 0)
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
            try
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
            catch (Exception) { MessageBox.Show("No hay ningun laboratorio"); }
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

        // SEGUNDO PARCIAL


        private void btnTraerBD_Click(object sender, EventArgs e)
        {

            if (this.laboratorios.Count > 0)
            {
                AccesoDatos ado = new AccesoDatos();

                try
                {

                    this.laboratorios[this.lvIndex].Elementos = ado.ObtenerListaBD();

                    ActualizarVisorElementos(this.laboratorios[this.lvIndex].Elementos);

                    MessageBox.Show("todo ok");
                }

                catch
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
            else
            {
                MessageBox.Show("Debe crear un laboratorio primero");
            }
        }

        private void btnSubirBD_Click(object sender, EventArgs e)
        {
            if (this.laboratorios.Count > 0)
            {
                AccesoDatos ado = new AccesoDatos();

                try
                {

                    ado.SubirLista(this.laboratorios[this.lvIndex].Elementos);

                    MessageBox.Show("se subieron los datos correctamente");
                }

                catch
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
            else
            {
                MessageBox.Show("Debe crear un laboratorio primero");
            }
        }

        private void btnModificarDatoBD_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.laboratorios == null || this.laboratorios.Count == 0) { throw new ExceptionNoList("No hay ningun laboratorio:p"); }

                if (lstVisorElementos.SelectedItems.Count == 1)
                {
                    int indice = this.lstVisorElementos.SelectedIndices[0];
                    Laboratorio laboratorioSeleccionado = this.laboratorios[lvIndex];

                    if (indice != -1)
                    {

                        AccesoDatos ado = new AccesoDatos();

                        if (laboratorioSeleccionado.Elementos[indice] is Gas gas)
                        {
                            FrmGas frmGas = new(gas);
                            frmGas.ShowDialog();

                            if (frmGas.DialogResult == DialogResult.OK)
                            {
                                laboratorioSeleccionado.Elementos[indice] = frmGas.MiElemento;
                                bool rta = ado.ModificarElemento(frmGas.MiElemento);
                                ActualizarVisorElementos(laboratorioSeleccionado.Elementos);

                                if (rta) { MessageBox.Show("Se aplicaron los cambios"); }
                                else { MessageBox.Show("No se pudieron aplicar los cambios"); }
                            }
                        }
                        else if (laboratorioSeleccionado.Elementos[indice] is NoMetal nm)
                        {
                            FrmNoMetal frmNoMetal = new(nm);
                            frmNoMetal.ShowDialog();

                            if (frmNoMetal.DialogResult == DialogResult.OK)
                            {
                                laboratorioSeleccionado.Elementos[indice] = frmNoMetal.MiElemento;
                                bool rta = ado.ModificarElemento(frmNoMetal.MiElemento);
                                ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                                if (rta) { MessageBox.Show("Se aplicaron los cambios"); }
                                else { MessageBox.Show("No se pudieron aplicar los cambios"); }
                            }
                        }
                        else if (laboratorioSeleccionado.Elementos[indice] is Metal metal)
                        {
                            FrmMetal frmMetal = new(metal);
                            frmMetal.ShowDialog();
                            if (frmMetal.DialogResult == DialogResult.OK)
                            {
                                laboratorioSeleccionado.Elementos[indice] = frmMetal.MiElemento;
                                bool rta = ado.ModificarElemento(frmMetal.MiElemento);
                                ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                                if (rta) { MessageBox.Show("Se aplicaron los cambios"); }
                                else { MessageBox.Show("No se pudieron aplicar los cambios"); }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un elemento para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (ExceptionNoList) { MessageBox.Show(" - excepcion personalizada - \n Se requiere de un laboratorio"); }


        }

        private void btnEliminarDatoBD_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.laboratorios == null || this.laboratorios.Count == 0) { throw new ExceptionNoList("No hay ningun laboratorio:p"); }


                if (lstVisorElementos.SelectedItems.Count == 1)
                {
                    Laboratorio laboratorioSeleccionado = this.laboratorios[lvIndex];
                    int indice = this.lstVisorElementos.SelectedIndices[0];

                    if (indice != -1)
                    {


                        DialogResult confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (confirm == DialogResult.OK)
                        {

                            AccesoDatos ado = new AccesoDatos();

                            if (this.listaEnUso == null)
                            {
                                bool rta = ado.EliminarElemento(laboratorioSeleccionado.Elementos[indice]);
                                laboratorioSeleccionado.Elementos.RemoveAt(indice);
                                this.ActualizarVisorElementos(laboratorioSeleccionado.Elementos);
                                if (rta) { MessageBox.Show("Elemento eliminado correctamente"); }
                                else { MessageBox.Show("No se pudo eliminar el elemento"); }

                            }
                            else
                            {
                                bool rta = ado.EliminarElemento(this.listaEnUso[indice]);
                                this.laboratorios[lvIndex].Elementos.Remove(this.listaEnUso[indice]);
                                this.ActualizarVisorElementos(laboratorioSeleccionado.Elementos);

                                if (rta) { MessageBox.Show("Elemento eliminado correctamente"); }
                                else { MessageBox.Show("No se pudo eliminar el elemento"); }
                            }
                        }
                    }
                }

            }
            catch (ExceptionNoList) { MessageBox.Show(" - excepcion personalizada - \n Se requiere de un laboratorio"); }



        }

        private static void ReproducirMusica()
        {

            using (SoundPlayer player = new SoundPlayer("./sound.wav"))
            {
                Thread.Sleep(300); // lo uso para que el msgbox de abajo aparezca despues del form principal
                MessageBox.Show("Se prendio la musica");
                for (int i = 0; i < 5; i++)
                {
                    player.PlaySync(); // Reproduce y espera hasta que termine para avanzar
                }
                MessageBox.Show("Se termino la musica");
            }

        }

        private void btnCambiarInformacion_Click(object sender, EventArgs e)
        {
            if (this.laboratorios.Count > 0)
            {
                List<Elemento> laboratorio = this.laboratorios[0].Elementos;

                foreach (Elemento ele in laboratorio)
                {
                    ele.SwitchCambiarInformacion();
                }

                this.ActualizarVisorElementos(laboratorio);

            }
            else { MessageBox.Show("Se requiere un laboratorio con datos"); }




        }
    }
}
