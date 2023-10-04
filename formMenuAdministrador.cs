using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formMenuAdministrador : Form
    {
        private Form _formAnterior;
        private BaseDeDatos _baseDeDatos;

        public formMenuAdministrador(Form formAnterior, BaseDeDatos baseDeDatos)
        {
            _formAnterior = formAnterior;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void formMenuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sistema.GuardarJson(_baseDeDatos);
            _formAnterior.Show();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            if (_baseDeDatos + estudiante)
            {
                formABMEstudiante formABMEstudiante = new formABMEstudiante(this, estudiante);
                DialogResult estudianteDialogResult = formABMEstudiante.ShowDialog();

                if (estudianteDialogResult == DialogResult.Abort)
                {
                    _ = _baseDeDatos - estudiante;
                }

                ActualizarListaEstudiantes();

            }

        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a editar", "Error"); return; }

            Estudiante estudianteSeleccionado = _baseDeDatos.ListaEstudiantes[lsbEstudiantes.SelectedIndex];
            formABMEstudiante formABMEstudiante = new formABMEstudiante(this, estudianteSeleccionado);
            formABMEstudiante.ShowDialog();
            ActualizarListaEstudiantes();
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (lsbEstudiantes.SelectedIndex == -1) { MessageBox.Show("Selecione un estudiante a eliminar", "Error"); return; }

            if (_baseDeDatos - _baseDeDatos.ListaEstudiantes[lsbEstudiantes.SelectedIndex])
            {
                ActualizarListaEstudiantes();
            }
            else
            {
                MessageBox.Show("Error al eliminar el estudiante", "Error");
            }
        }

        private void formMenuAdministrador_Load(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
        }

        private void ActualizarListaProfesores()
        {
            lsbProfesores.Items.Clear();
            foreach (Profesor profesor in _baseDeDatos.ListaProfesores)
            {
                lsbProfesores.Items.Add($"{profesor.Apellido}, {profesor.Nombre}");
            }
        }

        private void ActualizarListaEstudiantes()
        {
            lsbEstudiantes.Items.Clear();
            foreach (Estudiante estudiante in _baseDeDatos.ListaEstudiantes)
            {
                lsbEstudiantes.Items.Add($"{estudiante.Legajo}: {estudiante.Apellido}, {estudiante.Nombre}");
            }
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            if (_baseDeDatos + profesor)
            {
                //formABMProfesor formABMProfesor = new formABMProfesor(this, profesor);
                //DialogResult ProfesorDialogResult = formABMProfesor.ShowDialog();

                //if (ProfesorDialogResult == DialogResult.Abort)
                //{
                //    _ = _baseDeDatos - profesor;
                //}

                ActualizarListaProfesores();

            }
        }
    }
}
