using Frm;

namespace FrmPrincipal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // Si el login es exitoso, iniciar el formulario principal
                Application.Run(new FrmPrincipal());
            }
            
        }
    }
}