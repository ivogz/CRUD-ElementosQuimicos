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

namespace Frm
{
    public partial class FrmLogin : Form
    {
        List<Usuario> Usuarios = new List<Usuario>();

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


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
                } 
            }

            if (loginExitoso)
            {
                this.DialogResult = DialogResult.OK;
            } else { MessageBox.Show("Error, ingrese datos correctos"); }


            
        }
    }
}
