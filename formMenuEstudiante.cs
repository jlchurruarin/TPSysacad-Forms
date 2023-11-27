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
    public partial class formMenuEstudiante : Form, IRecibidorDeItemSeleccionado<Curso>, IMenuEstudiante
    {
        private Form _formAnterior;
        private Usuario _estudiante;
        private LogicaMenuEstudiante _logicaMenuEstudiante;

        public formMenuEstudiante(Form formAnterior, Usuario estudiante)
        {
            _formAnterior = formAnterior;
            _estudiante = estudiante;
            _logicaMenuEstudiante = new LogicaMenuEstudiante(this);
            InitializeComponent();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            formSeleccionarCurso formSeleccionarCurso = new formSeleccionarCurso(this, _estudiante);
            formSeleccionarCurso.ShowDialog();
        }

        private void formMenuEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }

        private void btnVerHorarios_Click(object sender, EventArgs e)
        {
            formVerCronograma formCronograma = new formVerCronograma(_estudiante);
            formCronograma.ShowDialog();
        }

        private void btnRealizarPagos_Click(object sender, EventArgs e)
        {
            formSeleccionarPagos formSeleccionarPagos = new formSeleccionarPagos(_estudiante);
            formSeleccionarPagos.ShowDialog();
        }

        public async Task<List<Curso>> ItemsAMostrar()
        {
            return await _logicaMenuEstudiante.ObtenerInscripcionesPosibles(_estudiante);
        }

        public void RecibirItemSeleccionada(object item)
        {
            Curso? curso = item as Curso;

            if (curso is not null) { _logicaMenuEstudiante.AgregarInscripcion(_estudiante.Id, curso.Id, DateTime.Now); }
        }

        public void OnAddOk()
        {
            MessageBox.Show("Se agrego con exito");
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Se modificó con exito");
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar: {errorMessage}");
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar: {errorMessage}");
        }
    }
}
