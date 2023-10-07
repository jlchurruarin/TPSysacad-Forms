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
    public partial class formIngresarProfesor : Form
    {

        private BaseDeDatos _baseDeDatos;
        private Form _formAnterior;

        public formIngresarProfesor(Form formAnterior)
        {
            InitializeComponent();
            _baseDeDatos = Sistema.LeerJson();
            _formAnterior = formAnterior;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Profesor? profesor = _baseDeDatos.BuscarProfesorPorCorreo(txbCorreoElectronico.Text);
            if (profesor is null) { MessageBox.Show("Usuario no encontrado", "Logueo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (profesor.ValidarContraseña(txbContraseña.Text) == false) { MessageBox.Show("Contraseña incorrecta", "Logueo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                //formInicio formclonado = new formInicio(this);
                //formclonado.Show();
                //this.Hide();
            }
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
