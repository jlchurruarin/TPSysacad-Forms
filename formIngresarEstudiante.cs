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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPSysacad___Forms
{
    public partial class formIngresarEstudiante : Form
    {
        private BaseDeDatos _baseDeDatos;
        private Form _formAnterior;

        public formIngresarEstudiante(Form formAnterior)
        {
            InitializeComponent();
            _baseDeDatos = Sistema.LeerJson();
            _formAnterior = formAnterior;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Estudiante? estudiante = _baseDeDatos.BuscarEstudiantePorCorreo(txbCorreoElectronico.Text);
            if (estudiante is null) { MessageBox.Show("Usuario no encontrado", "Logueo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (estudiante.ValidarContraseña(txbContraseña.Text) == false) { MessageBox.Show("Contraseña incorrecta", "Logueo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            _formAnterior.Show();
            Sistema.GuardarJson(_baseDeDatos);
        }
    }
}
