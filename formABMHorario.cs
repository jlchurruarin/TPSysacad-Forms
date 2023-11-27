using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using BibliotecaClases.Logica;
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
    public partial class formABMHorario : Form
    {
        private LogicaGestionHorarios _logicaGestionHorarios;
        private string _cursoId;

        public formABMHorario(LogicaGestionHorarios logicaGestionHorarios, string cursoId)
        {
            _cursoId = cursoId;
            _logicaGestionHorarios = logicaGestionHorarios;
            InitializeComponent();
        }

        private void formHorario_Load(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Dia dia = (Dia) cmbDia.SelectedIndex;
            TimeOnly horaInicio = new TimeOnly((int) nudHoraInicio.Value, (int)nudMinutoInicio.Value);
            TimeOnly horaFin = new TimeOnly((int)nudHoraFin.Value, (int)nudMinutoFin.Value);

            _logicaGestionHorarios.AgregarHorario(_cursoId, dia, horaInicio, horaFin);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarDias()
        {
            cmbDia.DataSource = Enum.GetNames(typeof(Dia));
        }
    }
}

