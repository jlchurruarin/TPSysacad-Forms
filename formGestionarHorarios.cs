using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using BibliotecaClases.Logica;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class formGestionarHorarios : Form, IGestionHorarios
    {
        private Curso _curso;
        private LogicaGestionHorarios _logicaGestionHorarios;
        public event Func<Curso, Task<List<HorarioCurso>>>? AlSolicitarHorarios;

        public formGestionarHorarios(object curso)
        {
            _curso = (Curso)curso;
            _logicaGestionHorarios = new LogicaGestionHorarios(this);
            InitializeComponent();
            lsbHorarios.DisplayMember = "DisplayText";
        }

        public void MostrarListaHorarios(List<HorarioCurso> horarios)
        {
            lsbHorarios.DataSource = horarios;
        }

        private async void formGestionarHorarios_Load(object sender, EventArgs e)
        {
            if (_curso is not null && AlSolicitarHorarios is not null)
            {
                MostrarListaHorarios(await AlSolicitarHorarios.Invoke(_curso));
            }
        }

        private async void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            formABMHorario formHorario = new formABMHorario(_logicaGestionHorarios, _curso.Id);
            formHorario.ShowDialog();

            if (_curso is not null && AlSolicitarHorarios is not null)
            {
                MostrarListaHorarios(await AlSolicitarHorarios.Invoke(_curso));
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            if (lsbHorarios.SelectedIndex == -1) { OnRemoveError("Error al eliminar el horario, seleccione uno de la lista"); return; }
            HorarioCurso? horarioSeleccionado = lsbHorarios.SelectedItem as HorarioCurso;
            if (horarioSeleccionado is not null)
            {
                _logicaGestionHorarios.EliminarHorario(horarioSeleccionado);
            }
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar el horario: {errorMessage}");
        }

        public async void OnAddOk()
        {
            MessageBox.Show("Horario agregado con exito");
            if (_curso is not null && AlSolicitarHorarios is not null)
            {
                MostrarListaHorarios(await AlSolicitarHorarios.Invoke(_curso));
            }
        }

        public void OnRemoveError(string errorMessage)
        {
            MessageBox.Show($"Error al eliminar el horario: {errorMessage}");
        }

        public async void OnRemoveOk()
        {
            MessageBox.Show("Horario eliminado con exito");
            if (_curso is not null && AlSolicitarHorarios is not null)
            {
                MostrarListaHorarios(await AlSolicitarHorarios.Invoke(_curso));
            }
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar el horario: {errorMessage}");
        }

        public async void OnUpdateOk()
        {
            MessageBox.Show("Horario modificado con exito");
            if (_curso is not null && AlSolicitarHorarios is not null)
            {
                MostrarListaHorarios(await AlSolicitarHorarios.Invoke(_curso));
            }
        }
    }
}
