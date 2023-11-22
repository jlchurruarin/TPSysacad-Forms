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
    public partial class formHorario : Form
    {
        private HorarioCurso _horario;

        public HorarioCurso Horario
        {
            get { return _horario; }
        }

        public formHorario()
        {
            InitializeComponent();
        }

        private void formHorario_Load(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Dia dia = (Dia)cmbDia.SelectedIndex;
            DateTime tiempo = new DateTime(1900, 1, 1, (int)nudHora.Value, (int)nudMinuto.Value, 0);
            int cargaHoraria = (int)nudCargaHoraria.Value;

            _horario.Dia = dia;
            //_horario.Hora = tiempo;
            //_horario.CargaHoraria = cargaHoraria;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void formHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //this.DialogResult = DialogResult.Abort;
            }
        }

        private void ActualizarDias()
        {
            cmbDia.Items.Clear();
            foreach (string dia in Enum.GetNames(typeof(Dia)))
            {
                cmbDia.Items.Add(dia);
            }
        }
    }
}
