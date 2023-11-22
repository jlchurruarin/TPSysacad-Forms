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
    public partial class formSeleccionarCurso : Form
    {

        private Usuario? _estudiante;

        public formSeleccionarCurso()
        {
            InitializeComponent();
        }

        public formSeleccionarCurso(Usuario estudiante) : this()
        {
            _estudiante = estudiante;
        }

        private void formSeleccionarCurso_Load(object sender, EventArgs e)
        {
            ActualizarListaCursos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            if (lsbCursos.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar un curso", "Error"); return; }
            else
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ActualizarListaCursos()
        {
            List<Curso> cursosDisponibles = new List<Curso>();
            lsbCursos.Items.Clear();
            foreach (Curso curso in cursosDisponibles)
            {
                lsbCursos.Items.Add($"{curso}");
            }
        }

    }
}
