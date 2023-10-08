﻿using BibliotecaClases;
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

        private Curso _curso;
        private BaseDeDatos _baseDeDatos;

        public Curso Curso
        {
            get { return _curso; }
        }

        public formSeleccionarCurso(BaseDeDatos baseDeDatos)
        {
            _curso = new Curso();
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
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
                Curso curso = _baseDeDatos.ListaCursos[lsbCursos.SelectedIndex];
                _curso = curso;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void formSeleccionarCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void ActualizarListaCursos()
        {
            lsbCursos.Items.Clear();
            foreach (Curso curso in _baseDeDatos.ListaCursos)
            {
                lsbCursos.Items.Add($"{_baseDeDatos.BuscarMateriaPorID(curso.IdMateria)?.ToString()} - {curso.ToString()}");
            }
        }

    }
}
