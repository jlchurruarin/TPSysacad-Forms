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
        private FakeBaseDeDatos _baseDeDatos;

        public formABMEstudiante(Estudiante estudiante, FakeBaseDeDatos baseDeDatos)
        {
            _estudiante = estudiante;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formABMEstudiante_Load(object sender, EventArgs e)
        {
            if (_estudiante.Legajo == 0)
            {
                //Habilitar contraseña provisional
                lblContraseñaProvisional.Visible = true;
                txbContraseñaProvisional.Visible = true;
                btnResetearContrasenia.Visible = false;
            }
            else
            {
                lblContraseñaProvisional.Visible = false;
                txbContraseñaProvisional.Visible = false;
                btnResetearContrasenia.Visible = true;
            }

            CargarDatosDelEstudiante();
            CargarListaDePagos();
            CargarListaCursosInscriptos();
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

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            formSeleccionarCurso formSeleccionarCurso = new formSeleccionarCurso(_estudiante, _baseDeDatos);
            DialogResult dialogResultSeleccionarCurso = formSeleccionarCurso.ShowDialog();
            if (dialogResultSeleccionarCurso == DialogResult.OK)
            {
                Inscripcion inscripcion = new Inscripcion(_estudiante, DateTime.Now);
                try
                {
                    if (formSeleccionarCurso.Curso + inscripcion)
                    {
                        CargarListaCursosInscriptos();
                    }
                    else
                    {
                        MessageBox.Show("El estudiante ya está inscrito en dicho curso");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error");
                }
            }

        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursosInscriptos.SelectedIndex == -1) { MessageBox.Show("Selecione un curso a eliminar", "Error"); return; }
            Curso curso = _baseDeDatos.ListaCursos[lsbCursosInscriptos.SelectedIndex];
            Inscripcion? inscripcion = curso.ListaDeInscripciones.Find(i => i.IdEstudiante == _estudiante.Id);

            if (inscripcion is not null)
            {
                curso.ListaDeInscripciones.Remove(inscripcion);
                CargarListaCursosInscriptos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el estudiante", "Error");
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago();
            formABMPago formABMPago = new formABMPago(pago);
            DialogResult dialogResultABMPago = formABMPago.ShowDialog();
            if (dialogResultABMPago == DialogResult.OK)
            {
                _estudiante.ListaPagos.Add(pago);
                CargarListaDePagos();
            }
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            if (lsbPagos.SelectedIndex == -1) { MessageBox.Show("Selecione un pago a editar", "Error"); return; }

            Pago pagoSeleccionado = _estudiante.ListaPagos[lsbPagos.SelectedIndex];
            formABMPago formABMPago = new formABMPago(pagoSeleccionado);
            formABMPago.ShowDialog();
            CargarListaDePagos();
        }


        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (lsbPagos.SelectedIndex == -1) { MessageBox.Show("Selecione un pago a eliminar", "Error"); return; }

            Pago pagoSeleccionado = _estudiante.ListaPagos[lsbPagos.SelectedIndex];
            if (_estudiante.ListaPagos.Remove(pagoSeleccionado))
            {
                CargarListaDePagos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el pago", "Error");
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
            if (_estudiante.Legajo == 0)
            {
                _estudiante.Contraseña = Sistema.EncriptarTexto(txbContraseñaProvisional.Text);

                DialogResult resultYesNo = MessageBox.Show("¿Desea enviar la contraseña al usuario generado?", "Envio de contraseña", MessageBoxButtons.YesNo);
                if (resultYesNo == DialogResult.Yes)
                {
                    Correo.EnviarCorreo(txbCorreoElectronico.Text, "Generación de usuario", $"Se generó su usuario, contraseña provisional: {txbContraseñaProvisional.Text}");
                }
            }

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
                lsbCursosInscriptos.Items.Add($"{_baseDeDatos.BuscarMateriaPorID(cursoInscripto.IdMateria)?.ToString()} - {cursoInscripto.ToString()}");
            }
        }

        private void CargarListaDePagos()
        {
            lsbPagos.Items.Clear();
            foreach (Pago pago in _estudiante.ListaPagos)
            {
                lsbPagos.Items.Add(pago.ToString());
            }
        }
        private void formABMEstudiante_FormClosing(object sender, FormClosingEventArgs e)
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
                _estudiante.ResetContraseña(true);
            }
            else
            {
                _estudiante.ResetContraseña();
            }
        }
    }
}
