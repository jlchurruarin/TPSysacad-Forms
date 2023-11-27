using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using BibliotecaClases.Logica;
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
    public partial class formABMUsuario : Form, IABMUsuario
    {
        private LogicaAMBUsuario _logicaABMUsuario;
        public TipoDeUsuario TipoDeUsuario { get; }

        public Usuario? Usuario { get; }

        public event Action? AlSolicitarUsuario;

        public formABMUsuario(TipoDeUsuario tipoDeUsuario)
        {
            _logicaABMUsuario = new LogicaAMBUsuario(this);
            TipoDeUsuario = tipoDeUsuario;
            InitializeComponent();
        }

        public formABMUsuario(TipoDeUsuario tipoDeUsuario, object selectedItem) : this(tipoDeUsuario)
        {
            Usuario = selectedItem as Usuario;
        }

        private void formABMEstudiante_Load(object sender, EventArgs e)
        {

            if (Usuario is not null)
            {
                AlSolicitarUsuario?.Invoke();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Usuario is not null)
            {
                _logicaABMUsuario.UpdateUsuario(Usuario.Id, TipoDeUsuario, txbLegajo.Text, txbNombre.Text, txbApellido.Text,
                                        txbCorreoElectronico.Text, txbContraseñaProvisional.Text, txbDNI.Text,
                                        chkCambioContraseñaObligatorio.Checked, txbNumeroDeTelefono.Text, txbDireccion.Text);
            }
            else
            {
                _logicaABMUsuario.AddUsuario(TipoDeUsuario, txbLegajo.Text, txbNombre.Text, txbApellido.Text,
                                        txbCorreoElectronico.Text, txbContraseñaProvisional.Text, txbDNI.Text,
                                        chkCambioContraseñaObligatorio.Checked, txbNumeroDeTelefono.Text, txbDireccion.Text);
            }
        }


        private void btnResetearContrasenia_Click(object sender, EventArgs e)
        {
            DialogResult resultYesNo = MessageBox.Show("¿Desea enviar la contraseña al usuario?", "Envio de contraseña", MessageBoxButtons.YesNo);
            if (resultYesNo == DialogResult.Yes)
            {
                try
                {
                    Usuario?.ResetContraseña(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar el correo electronico: {ex.Message}");
                }
            }
            else
            {
                Usuario?.ResetContraseña();
            }
        }

        public void OnAddOk()
        {
            MessageBox.Show("Usuario agregado con exito", "Aviso");
            this.Close();
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Usuario modificado con exito", "Aviso");
            this.Close();
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar el usuario: {errorMessage}", "Error");
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar el usuario: {errorMessage}", "Error");
        }

        public void MostrarUsuario(Usuario? usuario)
        {
            if (usuario is null) return;

            txbNombre.Text = usuario.Nombre;
            txbApellido.Text = usuario.Apellido;
            txbDNI.Text = usuario.Dni.ToString();
            txbLegajo.Text = usuario.Legajo.ToString();
            txbNumeroDeTelefono.Text = usuario.NumeroDeTelefono;
            txbDireccion.Text = usuario.Direccion;
            txbCorreoElectronico.Text = usuario.CorreoElectronico;
            chkCambioContraseñaObligatorio.Checked = usuario.CambioDeContraseñaObligatorio;
        }

    }
}
