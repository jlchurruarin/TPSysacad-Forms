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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCurso();
                GuardarCurso();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEstudianteInscripto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarEstudianteInscripto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEstudianteEspera_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarEstudianteEspera_Click(object sender, EventArgs e)
        {

        }

        private void formABMCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //this.DialogResult = DialogResult.Abort;
            }
        }

        private void ValidarCurso()
        {
            try
            {
                _ = (cbbMateria.SelectedItem as dynamic).Value;
            }
            catch
            {
                throw new Exception("Debe seleccionar una materia");
            }

            try
            {
                _ = (cbbProfesor.SelectedItem as dynamic).Value;
            }
            catch
            {
                throw new Exception("Debe seleccionar un profesor");
            }


        }

        private void GuardarCurso()
        {
            _curso.IdMateria = (cbbMateria.SelectedItem as dynamic).Value;
            _curso.NombreCursada = txbNombreCurso.Text;
            _curso.IdProfesor = (cbbProfesor.SelectedItem as dynamic).Value;
            _curso.Aula = txbAula.Text;
            _curso.CupoMaximo = (int)nudCupoMaximo.Value;
        }

        private void CargarCursoEnForm()
        {
            if (_curso is null) { return; }

            CargarMaterias();
            CargarProfesores();

            Materia? materia = _baseDeDatos.BuscarMateriaPorID(_curso.IdMateria);

            cbbMateria.Text = materia?.ToString();
            txbNombreCurso.Text = _curso.NombreCursada;
            cbbProfesor.Text = _baseDeDatos.BuscarProfesorPorID(_curso.IdProfesor)?.ToString();
            txbAula.Text = _curso.Aula;
            nudCupoMaximo.Value = _curso.CupoMaximo;

            CargarListaDeHorarios();
            CargarListaEstudiantesInscriptos();
            CargarListaEstudiantesEnEspera();

        }

        private void CargarMaterias()
        {
            cbbMateria.Items.Clear();
            cbbMateria.DisplayMember = "Text";
            cbbMateria.ValueMember = "Value";

            foreach (Materia materia in _baseDeDatos.ListaMaterias)
            {
                cbbMateria.Items.Add(new { Text = materia.ToString(), Value = materia.Id });
            }
        }

        private void CargarProfesores()
        {
            cbbProfesor.Items.Clear();
            cbbProfesor.DisplayMember = "Text";
            cbbProfesor.ValueMember = "Value";

            cbbProfesor.Items.Clear();
            foreach (Profesor profesor in _baseDeDatos.ListaProfesores)
            {
                cbbProfesor.Items.Add(new { Text = profesor.ToString(), Value = profesor.Id });
            }
        }

        private void CargarListaDeHorarios()
        {
            lsbHorarios.Items.Clear();
            foreach (Horario? horario in _curso.Horario)
            {
                lsbHorarios.Items.Add(horario.ToString());
            }
        }

        private void CargarListaEstudiantesInscriptos()
        {
            lsbEstudiantesInscriptos.Items.Clear();
            foreach (Inscripcion inscripcion in _curso.ListaDeInscripciones)
            {
                Estudiante? estudiante = _baseDeDatos.BuscarEstudiantePorID(inscripcion.IdEstudiante);
                if (estudiante is not null)
                {
                    lsbEstudiantesInscriptos.Items.Add(estudiante.ToString());
                }
                else
                {
                    MessageBox.Show("Base de datos con errores, existe un estudiante" +
                        " inscripto que no se encuentra en la lista de estudiantes" +
                        $"ID: {inscripcion.IdEstudiante}");
                }
            }
        }

        private void CargarListaEstudiantesEnEspera()
        {
            lsbEstudiantesEnEspera.Items.Clear();
            foreach (string idEstudiante in _curso.ListaIdEstudiantesEnEspera)
            {
                Estudiante? estudiante = _baseDeDatos.BuscarEstudiantePorID(idEstudiante);
                if (estudiante is not null)
                {
                    lsbEstudiantesEnEspera.Items.Add(estudiante.ToString());
                }
                else
                {
                    MessageBox.Show("Base de datos con errores, existe un estudiante" +
                        " inscripto que no se encuentra en la lista de estudiantes" +
                        $"ID: {idEstudiante}");
                }
            }
        }

    }
}
