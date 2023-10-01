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
    public partial class formMenuAdministrador : Form
    {
        private Form _formAnterior;
        private BaseDeDatos _baseDeDatos;

        public formMenuAdministrador(Form formAnterior, BaseDeDatos baseDeDatos)
        {
            _formAnterior = formAnterior;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formMenuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            if (_baseDeDatos + estudiante)
            {
                formABMEstudiante formABMEstudiante = new formABMEstudiante(this, estudiante);
                DialogResult estudianteDialogResult = formABMEstudiante.ShowDialog();

                if (estudianteDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - estudiante;
                }
            }

        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}
