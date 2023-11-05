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

namespace TPSysacad___Forms
{
    public partial class formSeleccionarMateria : Form
    {
        private Materia _materia;
        private FakeBaseDeDatos _baseDeDatos;

        public Materia Materia
        {
            get { return _materia; }
        }

        public formSeleccionarMateria(FakeBaseDeDatos baseDeDatos)
        {
            _materia = new Materia();
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formSeleccionarMateria_Load(object sender, EventArgs e)
        {
            ActualizarListaMaterias();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (lsbMateria.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar una materia", "Error"); return; }
            else
            {
                Materia materia = _baseDeDatos.ListaMaterias[lsbMateria.SelectedIndex];
                _materia = materia;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void formSeleccionarMateria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //this.DialogResult = DialogResult.Abort;
            }
        }

        private void ActualizarListaMaterias()
        {
            lsbMateria.Items.Clear();
            foreach (Materia materia in _baseDeDatos.ListaMaterias)
            {
                lsbMateria.Items.Add(materia.ToString());
            }
        }
    }
}
