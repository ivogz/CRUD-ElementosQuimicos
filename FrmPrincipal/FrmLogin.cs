using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Frm
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        public Usuario usuarioExitoso;

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario login.";

            Serializacion usuariosData = new Serializacion("./MOCK_DATA.json");
            this.Usuarios = usuariosData.DeserializarJson();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool loginExitoso = false;

            foreach (Usuario u in Usuarios)
            {
                if (u.Correo == this.txtCorreo.Text && u.Clave == this.txtContraseña.Text)
                {
                    loginExitoso = true;
                    this.usuarioExitoso = u;
                    break;
                }
            }

            if (loginExitoso)
            {
                string logData = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {this.usuarioExitoso.MostrarInfo()}";

                try
                {
                    using (StreamWriter writer = new StreamWriter("./usuarios.log", true))
                    {
                        writer.WriteLine(logData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else { MessageBox.Show("Error, ingrese datos correctos"); }

        }
    }
}
