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
    public partial class formMenuEstudiante : Form
    {
        private Form _formAnterior;
        private Estudiante _estudiante;
        private FakeBaseDeDatos _baseDeDatos;

        public formMenuEstudiante(Form formAnterior, Estudiante estudiante, FakeBaseDeDatos baseDeDatos)
        {
            _formAnterior = formAnterior;
            _estudiante = estudiante;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            formSeleccionarCurso formSeleccionarCurso = new formSeleccionarCurso(_estudiante, _baseDeDatos);
            DialogResult dialogResultSeleccionarCurso = formSeleccionarCurso.ShowDialog();
            if (dialogResultSeleccionarCurso == DialogResult.OK)
            {
                Inscripcion inscripcion = new Inscripcion(_estudiante, DateTime.Now);
                try
                {
                    bool agregado = formSeleccionarCurso.Curso + inscripcion;
                    if (agregado) { MessageBox.Show("Inscripto correctamente", "Inscripción"); }
                    else { MessageBox.Show("Curso lleno, se agregó a lista de espera", "Inscripción"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            formSeleccionarPagos formSeleccionarPagos = new formSeleccionarPagos(_estudiante.ListaPagos);
            formSeleccionarPagos.ShowDialog();
        }
    }
}
