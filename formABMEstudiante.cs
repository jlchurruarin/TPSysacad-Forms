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
    public partial class formABMEstudiante : Form
    {
        private Form _formAnterior;
        private Estudiante? _estudiante;
        private BaseDeDatos? _baseDeDatos;

        private formABMEstudiante(Form formAnterior)
        {
            _formAnterior = formAnterior;
            InitializeComponent();
        }

        public formABMEstudiante(Form formAnterior, Estudiante estudiante) : this(formAnterior)
        {
            _estudiante = estudiante;
        }

        public formABMEstudiante(Form formAnterior, BaseDeDatos baseDeDatos) : this(formAnterior)
        {
            _baseDeDatos = baseDeDatos;
        }

        private void formABMEstudiante_Load(object sender, EventArgs e)
        {
            if (_estudiante is null) { return; }

            txbNombre.Text = _estudiante.Nombre;
            txbApellido.Text = _estudiante.Apellido;
            txbDNI.Text = _estudiante.Dni.ToString();
            txbLegajo.Text = _estudiante.Legajo.ToString();
            txbNumeroDeTelefono.Text = _estudiante.NumeroTelefono.ToString();
            txbDireccion.Text = _estudiante.Direccion;
            txbCorreoElectronico.Text = _estudiante.CorreoElectronico;
            txbContrasenia.Text = _estudiante.Contraseña;
            chkCambioContraseñaObligatorio.Checked = _estudiante.CambioDeContraseñaObligatorio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _formAnterior.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_baseDeDatos is not null)
            {
                Estudiante estudiante = new Estudiante();
                if ((_baseDeDatos + estudiante) == false)
                {
                    MessageBox.Show("Error al agregar el estudiante");
                }
            }
            if (_estudiante is not null)
            {
                _estudiante.Nombre = txbNombre.Text;
                _estudiante.Apellido = txbApellido.Text;
                _estudiante.Dni = int.Parse(txbDNI.Text);
                _estudiante.Legajo = int.Parse(txbLegajo.Text);
                _estudiante.NumeroTelefono = int.Parse(txbNumeroDeTelefono.Text);
                _estudiante.Direccion = txbDireccion.Text;
                _estudiante.CorreoElectronico = txbCorreoElectronico.Text;
                _estudiante.Contraseña = txbContrasenia.Text;
                _estudiante.CambioDeContraseñaObligatorio = chkCambioContraseñaObligatorio.Checked;
            }

        }
    }
}
