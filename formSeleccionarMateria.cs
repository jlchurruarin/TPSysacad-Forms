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
    public partial class formSeleccionarMateria : Form
    {
        private IRecibidorDeItemSeleccionado<Materia> _recibidorDeMateria;


        public formSeleccionarMateria(IRecibidorDeItemSeleccionado<Materia> recibidorDeMateria)
        {
            _recibidorDeMateria = recibidorDeMateria;
            InitializeComponent();
            lsbMateria.DisplayMember = "DisplayText";
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
                _recibidorDeMateria.RecibirItemSeleccionada(lsbMateria.SelectedItem);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarListaMaterias()
        {
            lsbMateria.DataSource = _recibidorDeMateria.ItemsAMostrar();
        }
    }
}
