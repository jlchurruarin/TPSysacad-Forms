using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formIngresarAdministrador : Form, ILoginVista
    {
        private Form _formAnterior;

        public formIngresarAdministrador(Form formAnterior)
        {
            InitializeComponent();
            _formAnterior = formAnterior;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Sistema.ValidarLogin(this, TipoDeUsuario.Administrador, txbCorreoElectronico.Text, txbContraseña.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formIngresarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            txbCorreoElectronico.Text = "Admin@admin.com";
            txbContraseña.Text = "1234";
        }

        public async void OnLoginOk()
        {
            Usuario? admin = await Usuario.ObtenerUsuario(TipoDeUsuario.Administrador, txbCorreoElectronico.Text, txbContraseña.Text);
            formMenuAdministrador formMenuAdministrador = new formMenuAdministrador(this, admin);
            formMenuAdministrador.Show();
            this.Hide();
        }

        public void OnLoginFail()
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Error alingresar");
        }

        public async void OnLoginCambioDeContraseñaObligatorio()
        {
            Usuario? admin = await Usuario.ObtenerUsuario(TipoDeUsuario.Administrador, txbCorreoElectronico.Text, txbContraseña.Text);
            formCambioDeContraseña formCambioDeContraseña = new formCambioDeContraseña(admin);
            formCambioDeContraseña.ShowDialog();
        }
    }
}
