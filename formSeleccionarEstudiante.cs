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
    public partial class formSeleccionarEstudiante : Form
    {
        private IRecibidorDeItemSeleccionado<Usuario> _recibidorDeEstudiante;

        public formSeleccionarEstudiante(IRecibidorDeItemSeleccionado<Usuario> recibidorDeUsuario)
        {
            _recibidorDeEstudiante = recibidorDeUsuario;
            InitializeComponent();
            lsbEstudiantes.DisplayMember = "DisplayText";
        }
        private void formSeleccionarEstudiante_Load(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar una materia", "Error"); return; }
            else
            {
                _recibidorDeEstudiante.RecibirItemSeleccionada(lsbEstudiantes.SelectedItem);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarListaEstudiantes()
        {
            lsbEstudiantes.DataSource = _recibidorDeEstudiante.ItemsAMostrar();
        }
    }
}
