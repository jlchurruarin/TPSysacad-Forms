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
    public partial class formIngresarAdministrador : Form
    {
        private BaseDeDatos _baseDeDatos;
        private Form _formAnterior;

        public formIngresarAdministrador(Form formAnterior)
        {
            InitializeComponent();
            _baseDeDatos = Sistema.LeerJson();
            _formAnterior = formAnterior;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Administrador? administrador = _baseDeDatos.BuscarAdministradorPorCorreo(txbCorreoElectronico.Text);
            if (administrador is null) { MessageBox.Show("Usuario no encontrado", "Logueo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (administrador.ValidarContraseña(txbContraseña.Text) == false) { MessageBox.Show("Contraseña incorrecta", "Logueo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                Form formMenuAdministrador = new formMenuAdministrador(this, _baseDeDatos);
                formMenuAdministrador.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            _formAnterior.Show();
        }

        private void formIngresarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }
    }
}
