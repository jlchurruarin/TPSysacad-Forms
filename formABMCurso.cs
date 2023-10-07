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
        private Form _formAnterior;
        private Curso _curso;
        private BaseDeDatos _baseDeDatos;

        public formABMCurso(Form formAnterior, Curso curso, BaseDeDatos baseDeDatos)
        {
            _formAnterior = formAnterior;
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
    }
}
