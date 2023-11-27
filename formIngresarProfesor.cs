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
    public partial class formIngresarProfesor : Form, ILoginVista
    {

        private Form _formAnterior;

        public formIngresarProfesor(Form formAnterior)
        {
            InitializeComponent();
            _formAnterior = formAnterior;
        }

        public async void OnLoginCambioDeContraseñaObligatorio()
        {
            Usuario? profesor = await Usuario.ObtenerUsuario(TipoDeUsuario.Profesor, txbCorreoElectronico.Text, txbContraseña.Text);
            formCambioDeContraseña formCambioDeContraseña = new formCambioDeContraseña(profesor);
            formCambioDeContraseña.ShowDialog();
        }

        public void OnLoginFail()
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Error alingresar");
        }

        public void OnLoginOk()
        {
            MessageBox.Show("Menu profesor no implemtado, no hay casos de uso sobre profesor");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Sistema.ValidarLogin(this, TipoDeUsuario.Profesor, txbCorreoElectronico.Text, txbContraseña.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formIngresarProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }
    }
}
