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
        private Estudiante _estudiante;
        private BaseDeDatos _baseDeDatos;

        public formABMEstudiante(Estudiante estudiante, BaseDeDatos baseDeDatos)
        {
            _estudiante = estudiante;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formABMEstudiante_Load(object sender, EventArgs e)
        {
            if (_estudiante is null) { return; }

            CargarDatosDelEstudiante();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarEstudiante();
                GuardarEstudiante();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarEstudiante()
        {
            if (string.IsNullOrEmpty(txbNombre.Text)) { throw new Exception("Nombre no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbApellido.Text)) { throw new Exception("Apellido no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbDNI.Text)) { throw new Exception("DNI no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbLegajo.Text)) { throw new Exception("Legajo no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbNumeroDeTelefono.Text)) { throw new Exception("Numero De Telefono no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbDireccion.Text)) { throw new Exception("Dirección no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbCorreoElectronico.Text)) { throw new Exception("Correo Electronico no puede estar vacio"); }

        }

        private void CargarDatosDelEstudiante()
        {
            txbNombre.Text = _estudiante.Nombre;
            txbApellido.Text = _estudiante.Apellido;
            txbDNI.Text = _estudiante.Dni.ToString();
            txbLegajo.Text = _estudiante.Legajo.ToString();
            txbNumeroDeTelefono.Text = _estudiante.NumeroTelefono.ToString();
            txbDireccion.Text = _estudiante.Direccion;
            txbCorreoElectronico.Text = _estudiante.CorreoElectronico;
            chkCambioContraseñaObligatorio.Checked = _estudiante.CambioDeContraseñaObligatorio;
            CargarListaCursosInscriptos();
        }

        private void GuardarEstudiante()
        {
            _estudiante.Nombre = txbNombre.Text;
            _estudiante.Apellido = txbApellido.Text;
            _estudiante.Dni = int.Parse(txbDNI.Text);
            _estudiante.Legajo = int.Parse(txbLegajo.Text);
            _estudiante.NumeroTelefono = int.Parse(txbNumeroDeTelefono.Text);
            _estudiante.Direccion = txbDireccion.Text;
            _estudiante.CorreoElectronico = txbCorreoElectronico.Text;
            _estudiante.CambioDeContraseñaObligatorio = chkCambioContraseñaObligatorio.Checked;
        }

        private void CargarListaCursosInscriptos()
        {
            lsbCursosInscriptos.Items.Clear();
            List<Curso> listaCursosInscriptos = _baseDeDatos.BuscarCursosInscriptos(_estudiante);
            foreach (Curso cursoInscripto in listaCursosInscriptos)
            {
                lsbCursosInscriptos.Items.Add($"{cursoInscripto.Nombre} - {cursoInscripto.Descripcion}");
            }
        }
    }
}
