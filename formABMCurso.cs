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
        public Curso? Curso { get; }

        public event Action? AlSolicitarCurso;

        public formABMCurso()
        {
            _logicaABMCurso = new LogicaABMCurso(this);
            InitializeComponent();
        }

        public formABMCurso(object selectedItem) : this()
        {
            Curso = selectedItem as Curso;
        }

        private void formABMCurso_Load(object sender, EventArgs e)
        {
            if (Curso is not null)
            {
                AlSolicitarCurso?.Invoke();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Curso is not null)
            {
                _logicaABMCurso.UpdateCurso(Curso.Id, txbNombreCurso.Text, txbAula.Text, nudCupoMaximo.Value.ToString());
            }
            else
            {
                _logicaABMCurso.AddCurso(txbNombreCurso.Text, txbAula.Text, nudCupoMaximo.Value.ToString());
            }
        }

        public void MostrarCurso(Curso? curso)
        {
            if (curso is null) return;

            txbNombreCurso.Text = curso.Nombre;
            txbAula.Text = curso.Aula;
            nudCupoMaximo.Value = curso.CupoMaximo;

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
