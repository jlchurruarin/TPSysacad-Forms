using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using BibliotecaClases.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formGestionarCursosEstudiante : Form, IGestionCursoEstudiante
    {
        private Usuario _usuario;
        private LogicaGestionCursoEstudiante _logicaGestionCursoEstudiante;

        public event Func<Usuario, List<Curso>>? AlSolicitarCursos;

        public formGestionarCursosEstudiante(object estudiante)
        {
            _usuario = (Usuario)estudiante;
            _logicaGestionCursoEstudiante = new LogicaGestionCursoEstudiante(this);
            InitializeComponent();
            lsbCursos.DisplayMember = "DisplayText";
        }

        private void formGestionarCursosEstudiante_Load(object sender, EventArgs e)
        {
            if (_usuario is not null && AlSolicitarCursos is not null)
            {
                MostrarListaCursos(AlSolicitarCursos.Invoke(_usuario));
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            formABMInscripcionEnCurso formABMInscripcion = new formABMInscripcionEnCurso(_usuario);
            formABMInscripcion.ShowDialog();

            if (_usuario is not null && AlSolicitarCursos is not null)
            {
                MostrarListaCursos(AlSolicitarCursos.Invoke(_usuario));
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Debe selecionar una inscripción a eliminar"); }
            _logicaGestionCursoEstudiante.EliminarCurso(lsbCursos.SelectedItem, _usuario);

            if (_usuario is not null && AlSolicitarCursos is not null)
            {
                MostrarListaCursos(AlSolicitarCursos.Invoke(_usuario));
            }
        }

        public void MostrarListaCursos(List<Curso> listaCursos)
        {
            lsbCursos.DataSource = listaCursos;
        }

        public void OnRemoveError(string errorMessage)
        {
            MessageBox.Show($"Error al borrar el curso: {errorMessage}");
        }

        public void OnRemoveOk()
        {
            MessageBox.Show("Curso elimitado correctamente");
        }
    }
}
