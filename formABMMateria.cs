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
    public partial class formABMMateria : Form
    {

        private Materia _materia;
        private BaseDeDatos _baseDeDatos;

        public formABMMateria(Materia materia, BaseDeDatos baseDeDatos)
        {
            _materia = materia;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formABMMateria_Load(object sender, EventArgs e)
        {
            CargarMateriaEnForm();
        }

        private void CargarMateriaEnForm()
        {
            if (_materia is null) { return; }

            txbNombre.Text = _materia.Nombre;
            txbDescripcion.Text = _materia.Descripcion;
            ActualizarListaMateriasRequeridas();
        }

        private void ActualizarListaMateriasRequeridas()
        {
            lsbMateriasRequeridas.Items.Clear();
            foreach (string idMateria in _materia.ListaIdMateriasRequeridas)
            {
                Materia? materia = _baseDeDatos.BuscarMateriaPorID(idMateria);
                if (materia is not null)
                {
                    lsbMateriasRequeridas.Items.Add(materia.ToString());
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarMateria();
                GuardarMateria();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            string idMateria = string.Empty;
            formSeleccionarMateria formSeleccionarMateria = new formSeleccionarMateria(ref idMateria);
            DialogResult materiaDialogResult = formSeleccionarMateria.ShowDialog();
            if (materiaDialogResult == DialogResult.OK)
            {
                if (_materia.Id == idMateria) { MessageBox.Show("No se puede agregar como materia requerida la misma materia"); }
                else
                {
                    if (_materia.ListaIdMateriasRequeridas.Contains(idMateria)) { MessageBox.Show("La materia ya se encuentra agregada"); }
                    else
                    {
                        MessageBox.Show("No se puede agregar como materia requerida la misma materia");
                    }
                }
            }

        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (lsbMateriasRequeridas.SelectedIndex == -1) { MessageBox.Show("Selecione una materia a eliminar", "Error"); return; }
            string idMateriaSeleccionada = _materia.ListaIdMateriasRequeridas[lsbMateriasRequeridas.SelectedIndex];
            if (_materia.ListaIdMateriasRequeridas.Remove(idMateriaSeleccionada))
            {
                ActualizarListaMateriasRequeridas();
            }
            else
            {
                MessageBox.Show("Error al eliminar materia", "Error");
            }
        }

        private void ValidarMateria()
        {
            if (string.IsNullOrEmpty(txbNombre.Text)) { throw new Exception("Nombre no puede estar vacio"); }
            if (string.IsNullOrEmpty(txbDescripcion.Text)) { throw new Exception("Detalle no puede estar vacio"); }
        }

        private void GuardarMateria()
        {
            _materia.Nombre = txbNombre.Text;
            _materia.Descripcion = txbDescripcion.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
