using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
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

        private Usuario _estudiante;
        private IRecibidorDeItemSeleccionado<Curso> _recibidorDeCurso;

        private formSeleccionarCurso()
        {
            InitializeComponent();
        }

        public formSeleccionarCurso(IRecibidorDeItemSeleccionado<Curso> recibidorDeCurso, Usuario estudiante) : this()
        {
            _estudiante = estudiante;
            _recibidorDeCurso = recibidorDeCurso;
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
                _recibidorDeCurso.RecibirItemSeleccionada(lsbCursos.SelectedItem);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ActualizarListaCursos()
        {
            lsbCursos.DataSource = await _recibidorDeCurso.ItemsAMostrar();
        }

    }
}
