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
    public partial class formABMInscripcionEnCurso : Form, IABMIncripcionEnCurso
    {
        private Usuario _usuario;
        private LogicaABMInscripcionEnCurso _logicaABMInscripcion;

        public formABMInscripcionEnCurso(object estudiante)
        {
            _usuario = (Usuario)estudiante;
            _logicaABMInscripcion = new LogicaABMInscripcionEnCurso(this);
            InitializeComponent();
            lsbCursos.DisplayMember = "DisplayText";
        }

        public event Func<Usuario, List<Curso>>? AlSolicitarCursosDisponibles;

        public void MostrarListaCursosDisponibles(List<Curso> listaCursos)
        {
            lsbCursos.DataSource = listaCursos;
        }

        private void formABMInscripcion_Load(object sender, EventArgs e)
        {
            if (AlSolicitarCursosDisponibles != null)
            {
                MostrarListaCursosDisponibles(AlSolicitarCursosDisponibles.Invoke(_usuario));
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Seleccione un curso para inscribir al estudiante"); return; }

            Curso? curso = lsbCursos.SelectedItem as Curso;

            if (curso is null) { MessageBox.Show("Seleccione un curso para inscribir al estudiante"); return; }

            _logicaABMInscripcion.AgregarInscripcion(_usuario.Id, curso.Id);
        }

        public void OnAddOk()
        {
            MessageBox.Show("Se inscribió correctamente al usuario en el curso");
            this.Close();
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar al usuario: {errorMessage}");
        }

        public void OnAddListaEsperaOk()
        {
            MessageBox.Show("Se inscribió al usuario en la lista de espera del curso ya que se encuentra lleno");
            this.Close();
        }
    }
}
