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
    public partial class FrmUsuariosLog : Form
    {
        public FrmUsuariosLog()
        {
            InitializeComponent();
            MostrarRegistro();
        }

        private void MostrarRegistro()
        {
            try
            {
                // Leer todas las líneas del archivo de registro
                string[] lineas = File.ReadAllLines("./usuarios.log");

                // Agregar cada línea al ListBox
                foreach (string linea in lineas)
                {
                    this.lstRegistro.Items.Add(linea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de registro: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
