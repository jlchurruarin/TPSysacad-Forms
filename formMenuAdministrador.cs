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

        private void formMenuAdministrador_Load(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
            ActualizarListaProfesores();
            ActualizarListaAdministradores();
            ActualizarListaMaterias();
            ActualizarListaCursos();
        }

        private void formMenuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sistema.GuardarJson(_baseDeDatos);
            _formAnterior.Show();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            if (_baseDeDatos + estudiante)
            {
                formABMEstudiante formABMEstudiante = new formABMEstudiante(estudiante, _baseDeDatos);
                DialogResult estudianteDialogResult = formABMEstudiante.ShowDialog();

                if (estudianteDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - estudiante;
                }

                ActualizarListaEstudiantes();

            }

        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a editar", "Error"); return; }

            Estudiante estudianteSeleccionado = _baseDeDatos.ListaEstudiantes[lsbEstudiantes.SelectedIndex];
            formABMEstudiante formABMEstudiante = new formABMEstudiante(estudianteSeleccionado, _baseDeDatos);
            formABMEstudiante.ShowDialog();
            ActualizarListaEstudiantes();
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a eliminar", "Error"); return; }

            if (_baseDeDatos - _baseDeDatos.ListaEstudiantes[lsbEstudiantes.SelectedIndex])
            {
                ActualizarListaEstudiantes();
            }
            else
            {
                MessageBox.Show("Error al eliminar el estudiante", "Error");
            }
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            if (_baseDeDatos + profesor)
            {
                formABMProfesor formABMProfesor = new formABMProfesor(profesor, _baseDeDatos);
                DialogResult ProfesorDialogResult = formABMProfesor.ShowDialog();

                if (ProfesorDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - profesor;
                }

                ActualizarListaProfesores();

            }
        }

        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            if (lsbProfesores.SelectedIndex == -1) { MessageBox.Show("Selecione un profesor a editar", "Error"); return; }

            Profesor profesorSelecionado = _baseDeDatos.ListaProfesores[lsbProfesores.SelectedIndex];
            formABMProfesor formABMProfesor = new formABMProfesor(profesorSelecionado, _baseDeDatos);
            formABMProfesor.ShowDialog();
            ActualizarListaEstudiantes();
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (lsbProfesores.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a eliminar", "Error"); return; }

            if (_baseDeDatos - _baseDeDatos.ListaProfesores[lsbProfesores.SelectedIndex])
            {
                ActualizarListaProfesores();
            }
            else
            {
                MessageBox.Show("Error al eliminar el estudiante", "Error");
            }
        }

        private void btnAgregarAdministrador_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            if (_baseDeDatos + administrador)
            {
                formABMAdministrador formABMProfesor = new formABMAdministrador(this, administrador);
                DialogResult administradorDialogResult = formABMProfesor.ShowDialog();

                if (administradorDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - administrador;
                }

                ActualizarListaAdministradores();

            }
        }

        private void btnEditarAdministrador_Click(object sender, EventArgs e)
        {
            if (lsbAdministradores.SelectedIndex == -1) { MessageBox.Show("Selecione un administrador a editar", "Error"); return; }

            Administrador administradorSeleccionado = _baseDeDatos.ListaAdministradores[lsbAdministradores.SelectedIndex];
            formABMAdministrador formABMAdministrador = new formABMAdministrador(this, administradorSeleccionado);
            formABMAdministrador.ShowDialog();
            ActualizarListaAdministradores();
        }

        private void btnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            if (lsbAdministradores.SelectedIndex == -1) { MessageBox.Show("Selecione un administrador a eliminar", "Error"); return; }

            if (_baseDeDatos - _baseDeDatos.ListaAdministradores[lsbAdministradores.SelectedIndex])
            {
                ActualizarListaAdministradores();
            }
            else
            {
                MessageBox.Show("Error al eliminar el administrador", "Error");
            }
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            if (_baseDeDatos + materia)
            {
                formABMMateria formABMMateria = new formABMMateria(materia, _baseDeDatos);
                DialogResult materiaDialogResult = formABMMateria.ShowDialog();

                if (materiaDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - materia;
                }

                ActualizarListaMaterias();

            }
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            if (lsbMaterias.SelectedIndex == -1) { MessageBox.Show("Selecione una materia a editar", "Error"); return; }

            Materia materiaSeleccionada = _baseDeDatos.ListaMaterias[lsbMaterias.SelectedIndex];
            formABMMateria formABMMateria = new formABMMateria(materiaSeleccionada, _baseDeDatos);
            formABMMateria.ShowDialog();
            ActualizarListaMaterias();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (lsbMaterias.SelectedIndex == -1) { MessageBox.Show("Selecione una materia a eliminar", "Error"); return; }

            if (_baseDeDatos - _baseDeDatos.ListaMaterias[lsbMaterias.SelectedIndex])
            {
                ActualizarListaMaterias();
            }
            else
            {
                MessageBox.Show("Error al eliminar la materia", "Error");
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            if (_baseDeDatos + curso)
            {
                formABMCurso formABMCurso = new formABMCurso(curso, _baseDeDatos);
                DialogResult cursoDialogResult = formABMCurso.ShowDialog();

                if (cursoDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - curso;
                }

                ActualizarListaCursos();

            }
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Selecione una curso a editar", "Error"); return; }

            Curso cursoSeleccionada = _baseDeDatos.ListaCursos[lsbCursos.SelectedIndex];
            formABMCurso formABMCurso = new formABMCurso(cursoSeleccionada, _baseDeDatos);
            formABMCurso.ShowDialog();
            ActualizarListaCursos();
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Selecione un curso a eliminar", "Error"); return; }

            if (_baseDeDatos - _baseDeDatos.ListaCursos[lsbCursos.SelectedIndex])
            {
                ActualizarListaCursos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el curso", "Error");
            }
        }

        private void ActualizarListaProfesores()
        {
            lsbProfesores.Items.Clear();
            foreach (Profesor profesor in _baseDeDatos.ListaProfesores)
            {
                lsbProfesores.Items.Add(profesor.ToString());
            }
        }

        private void ActualizarListaEstudiantes()
        {
            lsbEstudiantes.Items.Clear();
            foreach (Estudiante estudiante in _baseDeDatos.ListaEstudiantes)
            {
                lsbEstudiantes.Items.Add(estudiante.ToString());
            }
        }

        private void ActualizarListaAdministradores()
        {
            lsbAdministradores.Items.Clear();
            foreach (Administrador administrador in _baseDeDatos.ListaAdministradores)
            {
                lsbAdministradores.Items.Add(administrador.ToString());
            }
        }

        private void ActualizarListaMaterias()
        {
            lsbMaterias.Items.Clear();
            foreach (Materia materia in _baseDeDatos.ListaMaterias)
            {
                lsbMaterias.Items.Add(materia.ToString());
            }
        }

        private void ActualizarListaCursos()
        {
            lsbCursos.Items.Clear();
            foreach (Curso curso in _baseDeDatos.ListaCursos)
            {
                lsbCursos.Items.Add(curso.ToString());
            }
        }


    }
}
