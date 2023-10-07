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
    public partial class formABMCurso : Form
    {
        private Curso _curso;
        private BaseDeDatos _baseDeDatos;

        public formABMCurso(Curso curso, BaseDeDatos baseDeDatos)
        {
            _curso = curso;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formABMCurso_Load(object sender, EventArgs e)
        {
            CargarCursoEnForm();
        }

        private void CargarCursoEnForm()
        {
            if (_curso is null) { return; }





        }

        private void CargarListaDeHorarios()
        {

        }

        private void CargarListaEstudiantesInscriptos()
        {

        }

        private void CargarListaEstudiantesEnEspera()
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void formABMCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
