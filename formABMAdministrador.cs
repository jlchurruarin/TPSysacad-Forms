using BibliotecaClases;
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
    public partial class formABMAdministrador : Form
    {
        private Form _formAnterior;
        private Administrador _administrador;

        public formABMAdministrador(Form formAnterior, Administrador administrador)
        {
            _administrador = administrador;
            _formAnterior = formAnterior;
            InitializeComponent();
        }

        private void formABMAdministrador_Load(object sender, EventArgs e)
        {
            if (_administrador is null) { return; }

            CargarDatosDelAdministrador();
        }


        private void CargarDatosDelAdministrador()
        {
            txbNombre.Text = _administrador.Nombre;
            txbApellido.Text = _administrador.Apellido;
            txbCorreoElectronico.Text = _administrador.CorreoElectronico;
            chkCambioContraseñaObligatorio.Checked = _administrador.CambioDeContraseñaObligatorio;
        }

        private void ValidarAdministrador()
        {
            if (string.IsNullOrEmpty(txbNombre.Text)) { throw new Exception("Nombre no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbApellido.Text)) { throw new Exception("Apellido no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbCorreoElectronico.Text)) { throw new Exception("Correo Electronico no puede estar vacio"); }

        }

        private void GuardarAdministrador()
        {
            _administrador.Nombre = txbNombre.Text;
            _administrador.Apellido = txbApellido.Text;
            _administrador.CorreoElectronico = txbCorreoElectronico.Text;
            _administrador.CambioDeContraseñaObligatorio = chkCambioContraseñaObligatorio.Checked;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarAdministrador();
                GuardarAdministrador();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _formAnterior.Show();
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void formABMAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btnResetearContrasenia_Click(object sender, EventArgs e)
        {

        }
    }
}
