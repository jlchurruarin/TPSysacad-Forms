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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formMenuAdministrador : Form, ISQLRemoveVista, IMenuAdministrador
    {
        public event Action? AlSolicitarEstudiantes;
        public event Action? AlSolicitarProfesores;
        public event Action? AlSolicitarAdministradores;
        public event Action? AlSolicitarMaterias;
        public event Action? AlSolicitarCursos;

        private Form _formAnterior;
        private Usuario _administrador;
        private LogicaMenuAdministrador _logicaMenuAdministrador;

        public formMenuAdministrador(Form formAnterior, Usuario administrador)
        {
            _formAnterior = formAnterior;
            _administrador = administrador;
            _logicaMenuAdministrador = new LogicaMenuAdministrador(this);
            InitializeComponent();
            lsbEstudiantes.DisplayMember = "DisplayText";
            lsbProfesores.DisplayMember = "DisplayText";
            lsbAdministradores.DisplayMember = "DisplayText";
            lsbMaterias.DisplayMember = "DisplayText";
            lsbCursos.DisplayMember = "DisplayText";
        }

        private void formMenuAdministrador_Load(object sender, EventArgs e)
        {

            AlSolicitarEstudiantes?.Invoke();
            AlSolicitarProfesores?.Invoke();
            AlSolicitarAdministradores?.Invoke();
            AlSolicitarMaterias?.Invoke();
            AlSolicitarCursos?.Invoke();

            btnGestionarCursosEstudiante.Enabled = false;
            btnGestionarPagosEstudiante.Enabled = false;
        }

        private void formMenuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            formABMUsuario formABMEstudiante = new formABMUsuario(TipoDeUsuario.Estudiante);
            formABMEstudiante.ShowDialog();

            AlSolicitarEstudiantes?.Invoke();
        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a editar", "Error"); return; }

            formABMUsuario formABMEstudiante = new formABMUsuario(TipoDeUsuario.Estudiante, lsbEstudiantes.SelectedItem);
            formABMEstudiante.ShowDialog();

            AlSolicitarEstudiantes?.Invoke();
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a eliminar", "Error"); return; }

            Usuario? usuarioSeleccionado = lsbEstudiantes.SelectedItem as Usuario;

            if (usuarioSeleccionado is null) { MessageBox.Show("Error al eliminar el estudiante seleccionado."); }
            else { _logicaMenuAdministrador.EliminarEstudiante(usuarioSeleccionado); }

            AlSolicitarEstudiantes?.Invoke();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            formABMUsuario formABMUsuario = new formABMUsuario(TipoDeUsuario.Profesor);
            formABMUsuario.ShowDialog();

            AlSolicitarProfesores?.Invoke();
        }

        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            if (lsbProfesores.SelectedIndex == -1) { MessageBox.Show("Selecione un profesor a editar", "Error"); return; }

            formABMUsuario formABMUsuario = new formABMUsuario(TipoDeUsuario.Profesor, lsbProfesores.SelectedItem);
            formABMUsuario.ShowDialog();

            AlSolicitarProfesores?.Invoke();
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (lsbProfesores.SelectedIndex == -1) { MessageBox.Show("Selecione un profesor a eliminar", "Error"); return; }

            Usuario? usuarioSeleccionado = lsbProfesores.SelectedItem as Usuario;

            if (usuarioSeleccionado is null) { MessageBox.Show("Error al eliminar el profesor seleccionado."); }
            else { _logicaMenuAdministrador.EliminarProfesor(usuarioSeleccionado); }

            AlSolicitarProfesores?.Invoke();
        }

        private void btnAgregarAdministrador_Click(object sender, EventArgs e)
        {
            formABMUsuario formABMUsuario = new formABMUsuario(TipoDeUsuario.Administrador);
            formABMUsuario.ShowDialog();

            AlSolicitarAdministradores?.Invoke();
        }

        private void btnEditarAdministrador_Click(object sender, EventArgs e)
        {
            if (lsbAdministradores.SelectedIndex == -1) { MessageBox.Show("Selecione un administrador a editar", "Error"); return; }

            formABMUsuario formABMUsuario = new formABMUsuario(TipoDeUsuario.Administrador, lsbAdministradores.SelectedItem);
            formABMUsuario.ShowDialog();

            AlSolicitarAdministradores?.Invoke();
        }

        private void btnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            if (lsbAdministradores.SelectedIndex == -1) { MessageBox.Show("Selecione un administrador a eliminar", "Error"); return; }

            Usuario? usuarioSeleccionado = lsbAdministradores.SelectedItem as Usuario;

            if (usuarioSeleccionado is null) { MessageBox.Show("Error al eliminar el administrador seleccionado."); }
            else { _logicaMenuAdministrador.EliminarAdministrador(usuarioSeleccionado); }

            AlSolicitarAdministradores?.Invoke();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            formABMMateria formABMMateria = new formABMMateria();
            formABMMateria.ShowDialog();
            AlSolicitarMaterias?.Invoke();
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            if (lsbMaterias.SelectedIndex == -1) { MessageBox.Show("Selecione una materia a editar", "Error"); return; }

            formABMMateria formABMMateria = new formABMMateria(lsbMaterias.SelectedItem);
            formABMMateria.ShowDialog();
            AlSolicitarMaterias?.Invoke();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (lsbMaterias.SelectedIndex == -1) { MessageBox.Show("Selecione una materia a eliminar", "Error"); return; }

            Materia? materiaSeleccionada = lsbMaterias.SelectedItem as Materia;

            if (materiaSeleccionada is null) { MessageBox.Show("Error al eliminar la materia seleccionada."); }
            else { _logicaMenuAdministrador.EliminarMateria(materiaSeleccionada); }

            AlSolicitarMaterias?.Invoke();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            formABMCurso formABMCurso = new formABMCurso();
            formABMCurso.ShowDialog();

            AlSolicitarCursos?.Invoke();
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Selecione una curso a editar", "Error"); return; }

            formABMCurso formABMCurso = new formABMCurso(lsbCursos.SelectedItem);
            formABMCurso.ShowDialog();

            AlSolicitarCursos?.Invoke();
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Selecione un curso a eliminar", "Error"); return; }

            Curso? cursoSeleccionado = lsbCursos.SelectedItem as Curso;

            if (cursoSeleccionado is null) { MessageBox.Show("Error al eliminar la materia seleccionada."); }
            else { _logicaMenuAdministrador.EliminarCurso(cursoSeleccionado); }

            AlSolicitarCursos?.Invoke();
        }

        private void btnGestionarPagosEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { return; }
            formGestionarPagosEstudiante formPago = new formGestionarPagosEstudiante(lsbEstudiantes.SelectedItem);
            formPago.ShowDialog();
        }

        private void btnGestionarCursosEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarCursosProfesor_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarMateriasRequeridas_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarHorariosCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarInscriptosCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarListaEsperaCurso_Click(object sender, EventArgs e)
        {

        }

        private void lsbEstudiantes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex != -1)
            {
                btnGestionarCursosEstudiante.Enabled = true;
                btnGestionarPagosEstudiante.Enabled = true;
            }
            else
            {
                btnGestionarCursosEstudiante.Enabled = false;
                btnGestionarPagosEstudiante.Enabled = false;
            }
        }

        private void lsbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbProfesores.SelectedIndex != -1)
            {
                btnGestionarCursosProfesor.Enabled = true;
            }
            else
            {
                btnGestionarCursosProfesor.Enabled = false;
            }
        }

        private void lsbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbMaterias.SelectedIndex != -1)
            {
                btnGestionarMateriasRequeridas.Enabled = true;
            }
            else
            {
                btnGestionarMateriasRequeridas.Enabled = false;
            }
        }

        private void lsbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex != -1)
            {
                btnGestionarHorariosCurso.Enabled = true;
                btnGestionarInscriptosCurso.Enabled = true;
                btnGestionarListaEsperaCurso.Enabled = true;
            }
            else
            {
                btnGestionarHorariosCurso.Enabled = false;
                btnGestionarInscriptosCurso.Enabled = false;
                btnGestionarListaEsperaCurso.Enabled = false;
            }
        }

        public void MostrarListaEstudiantes(List<Usuario> listaEstudiantes)
        {
            lsbEstudiantes.Items.Clear();
            foreach (Usuario estudiante in listaEstudiantes)
            {
                lsbEstudiantes.Items.Add(estudiante);
            }
        }

        public void MostrarListaProfesores(List<Usuario> listaProfesores)
        {
            lsbProfesores.Items.Clear();
            foreach (Usuario profesor in listaProfesores)
            {
                lsbProfesores.Items.Add(profesor);
            }
        }

        public void MostrarListaAdministradores(List<Usuario> listaAdministradores)
        {
            lsbAdministradores.Items.Clear();
            foreach (Usuario administrador in listaAdministradores)
            {
                lsbAdministradores.Items.Add(administrador);
            }
        }

        public void MostrarListaMaterias(List<Materia> listaMaterias)
        {
            lsbMaterias.Items.Clear();
            foreach (Materia materia in listaMaterias)
            {
                lsbMaterias.Items.Add(materia);
            }
        }

        public void MostrarListaCursos(List<Curso> listaCursos)
        {
            lsbCursos.Items.Clear();
            foreach (Curso curso in listaCursos)
            {
                lsbCursos.Items.Add(curso);
            }
        }

        public void OnRemoveOk()
        {
            MessageBox.Show("Eliminado con exito");
        }

        public void OnRemoveError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

    }
}
