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
    public partial class formSeleccionarEstudiante : Form
    {
        private Usuario _estudiante;
        private FakeBaseDeDatos _baseDeDatos;


        public Usuario Estudiante
        {
            get { return _estudiante; }
        }

        public formSeleccionarEstudiante()
        {
            InitializeComponent();
        }
        private void formSeleccionarEstudiante_Load(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar un estudiante", "Error"); return; }
            else
            {
                Usuario estudiante = _baseDeDatos.ListaEstudiantes[lsbEstudiantes.SelectedIndex];
                _estudiante = estudiante;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void formSeleccionarEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //this.DialogResult = DialogResult.Abort;
            }
        }

        private void ActualizarListaEstudiantes()
        {
            lsbEstudiantes.Items.Clear();
            foreach (Usuario estudiante in _baseDeDatos.ListaEstudiantes)
            {
                lsbEstudiantes.Items.Add(estudiante.ToString());
            }
        }
    }
}
