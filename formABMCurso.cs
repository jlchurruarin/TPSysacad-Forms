using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using BibliotecaClases.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPSysacad___Forms
{
    public partial class formABMCurso : Form, IABMCurso
    {
        private LogicaABMCurso _logicaABMCurso;
        private Curso _curso;

        public event Action<string>? AlSolicitarCurso;

        public formABMCurso()
        {
            _logicaABMCurso = new LogicaABMCurso(this);
            InitializeComponent();
        }

        public formABMCurso(object selectedItem) : this()
        {
            _curso = selectedItem as Curso;
        }

        private void formABMCurso_Load(object sender, EventArgs e)
        {
            List<Usuario> profesores = Usuario.GetAll(TipoDeUsuario.Profesor);
            List<Materia> materias = Materia.GetAll();

            cbbProfesor.DataSource = profesores;
            cbbProfesor.DisplayMember = "DisplayText";

            cbbMateria.DataSource = materias;
            cbbMateria.DisplayMember = "DisplayText";

            if (_curso is not null)
            {
                AlSolicitarCurso?.Invoke(_curso.Id);
                try
                {
                    Usuario profesorSeleccionado = profesores.First(item => item.Id == _curso.ProfesorId);
                    cbbProfesor.SelectedItem = profesorSeleccionado;
                }
                catch (InvalidOperationException ex)
                {
                    cbbProfesor.SelectedIndex = -1;
                }


                try
                {
                    Materia materia = Materia.ObtenerMateriaPorCursoID(_curso.Id);
                    Materia materiaSelecionada = materias.First(item => item.Id == materia.Id);
                    cbbMateria.SelectedItem = materiaSelecionada;
                    cbbMateria.Enabled = false;
                    System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                    toolTip.ShowAlways = true;
                    lblMateria.Text = lblMateria.Text + " ?";
                    toolTip.SetToolTip(lblMateria, "No es posible modificar la materia una vez creado el curso");
                    toolTip.Active = true;

                }
                catch (InvalidOperationException ex)
                {
                    cbbMateria.SelectedIndex = -1;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_curso is not null)
            {
                Usuario? profesor = cbbProfesor.SelectedItem as Usuario;
                Materia? materia = cbbMateria.SelectedItem as Materia;
                _logicaABMCurso.UpdateCurso(_curso.Id, txbNombreCurso.Text, txbAula.Text, nudCupoMaximo.Value.ToString(), materia?.Id, profesor?.Id);
            }
            else
            {
                Usuario? profesor = cbbProfesor.SelectedItem as Usuario;
                Materia? materia = cbbMateria.SelectedItem as Materia;
                _logicaABMCurso.AddCurso(txbNombreCurso.Text, txbAula.Text, nudCupoMaximo.Value.ToString(), materia?.Id, profesor?.Id);
            }
        }

        public void MostrarCurso(Curso? curso)
        {
            if (curso is null) return;

            txbNombreCurso.Text = curso.Nombre;
            txbAula.Text = curso.Aula;
            nudCupoMaximo.Value = curso.CupoMaximo;
            cbbProfesor.SelectedItem = Usuario.ObtenerUsuarioPorID(TipoDeUsuario.Profesor, curso.ProfesorId);
            cbbMateria.SelectedItem = Materia.ObtenerMateriaPorCursoID(curso.Id);
        }

        public void OnAddOk()
        {
            MessageBox.Show("Curso agregado con exito", "Aviso");
            this.Close();
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Curso modificado con exito", "Aviso");
            this.Close();
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar el curso: {errorMessage}", "Error");
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar el curso: {errorMessage}", "Error");
        }
    }
}
