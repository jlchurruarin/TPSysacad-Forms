using BibliotecaClases;
using BibliotecaClases.BD;
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
    public partial class formMenuEstudiante : Form
    {
        private Form _formAnterior;
        private Usuario _estudiante;
        private FakeBaseDeDatos _baseDeDatos;

        public formMenuEstudiante(Form formAnterior, Usuario estudiante, FakeBaseDeDatos baseDeDatos)
        {
            _formAnterior = formAnterior;
            _estudiante = estudiante;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            formSeleccionarCurso formSeleccionarCurso = new formSeleccionarCurso();
            DialogResult dialogResultSeleccionarCurso = formSeleccionarCurso.ShowDialog();
        }

        private void formMenuEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sistema.GuardarJson(_baseDeDatos);
            _formAnterior.Show();
        }

        private void btnVerHorarios_Click(object sender, EventArgs e)
        {
            formVerCronograma formCronograma = new formVerCronograma(_estudiante, _baseDeDatos);
            formCronograma.ShowDialog();
        }

        private void btnRealizarPagos_Click(object sender, EventArgs e)
        {
            formSeleccionarPagos formSeleccionarPagos = new formSeleccionarPagos();
            formSeleccionarPagos.ShowDialog();
        }
    }
}
