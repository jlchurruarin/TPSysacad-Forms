using BibliotecaClases;
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

namespace TPSysacad___Forms
{
    public partial class formABMProfesor : Form
    {
        private Profesor _profesor;
        private BaseDeDatos _baseDeDatos;

        public formABMProfesor(Profesor profesor, BaseDeDatos baseDeDatos)
        {
            _profesor = profesor;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formABMProfesor_Load(object sender, EventArgs e)
        {
            CargarProfesorEnForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarProfesor();
                GuardarProfesor();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarProfesor()
        {
            if (string.IsNullOrEmpty(txbNombre.Text)) { throw new Exception("Nombre no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbApellido.Text)) { throw new Exception("Apellido no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbCUIT.Text)) { throw new Exception("DNI no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbCorreoElectronico.Text)) { throw new Exception("Correo Electronico no puede estar vacio"); }
        }

        private void GuardarProfesor()
        {
            _profesor.Nombre = txbNombre.Text;
            _profesor.Apellido = txbApellido.Text;
            _profesor.Cuit = int.Parse(txbCUIT.Text);
            _profesor.CorreoElectronico = txbCorreoElectronico.Text;
            _profesor.CambioDeContraseñaObligatorio = chkCambioContraseñaObligatorio.Checked;
        }

        private void CargarProfesorEnForm()
        {
            if (_profesor is null) { return; }

            txbNombre.Text = _profesor.Nombre;
            txbApellido.Text = _profesor.Apellido;
            txbCUIT.Text = _profesor.Cuit.ToString();
            txbCorreoElectronico.Text = _profesor.CorreoElectronico;
            chkCambioContraseñaObligatorio.Checked = _profesor.CambioDeContraseñaObligatorio;
            ActualizarListaCursos();
        }

        private void ActualizarListaCursos()
        {
            lsbCursos.Items.Clear();
            List<Curso> listaCursos = _baseDeDatos.BuscarCursos(_profesor);
            foreach (Curso curso in listaCursos)
            {
                lsbCursos.Items.Add($"{_baseDeDatos.BuscarMateriaPorID(curso.IdMateria)?.ToString()} - {curso.ToString()}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void formABMProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //this.DialogResult = DialogResult.Abort;
            }
        }

        private void btnResetearContrasenia_Click(object sender, EventArgs e)
        {
            DialogResult resultYesNo = MessageBox.Show("¿Desea enviar la contraseña al usuario?", "Envio de contraseña", MessageBoxButtons.YesNo);
            if (resultYesNo == DialogResult.Yes)
            {
                _profesor.ResetContraseña(true);
            }
            else
            {
                _profesor.ResetContraseña();
            }

        }
    }
}

