using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPSysacad___Forms
{
    public partial class formIngresarEstudiante : Form, ILoginVista
    {
        private Form _formAnterior;

        public formIngresarEstudiante(Form formAnterior)
        {
            InitializeComponent();
            _formAnterior = formAnterior;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Sistema.ValidarLogin(this, TipoDeUsuario.Estudiante, txbCorreoElectronico.Text, txbContraseña.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formIngresarEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            txbCorreoElectronico.Text = "jlchurruarin@gmail.com";
            txbContraseña.Text = "Hola";
        }

        public async void OnLoginOk()
        {
            Usuario? estudiante = await Usuario.ObtenerUsuario(TipoDeUsuario.Estudiante, txbCorreoElectronico.Text, txbContraseña.Text);
            formMenuEstudiante formMenuEstudiante = new formMenuEstudiante(this, estudiante);
            formMenuEstudiante.Show();
            this.Hide();
        }

        public void OnLoginFail()
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Error alingresar");
        }

        public async void OnLoginCambioDeContraseñaObligatorio()
        {
            Usuario? estudiante = await Usuario.ObtenerUsuario(TipoDeUsuario.Estudiante, txbCorreoElectronico.Text, txbContraseña.Text);
            formCambioDeContraseña formCambioDeContraseña = new formCambioDeContraseña(estudiante);
            formCambioDeContraseña.ShowDialog();
        }
    }
}
