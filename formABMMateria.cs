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

        private Form _formAnterior;
        private Materia _materia;
        private BaseDeDatos _baseDeDatos;

        public formABMMateria(Form formAnterior, Materia materia, BaseDeDatos baseDeDatos)
        {
            _formAnterior = formAnterior;
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
            foreach (string idMateria in _materia.ListaIdMateriasRequeridas)
            {
                Materia? materia = _baseDeDatos.BuscarMateriaPorID(idMateria);
                if (materia is not null)
                {
                    lsbMateriasRequeridas.Items.Add($"{materia.Nombre} - {materia.Descripcion}");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
