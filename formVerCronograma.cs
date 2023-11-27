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
    public partial class formVerCronograma : Form
    {
        private Usuario _estudiante;

        public formVerCronograma(Usuario estudiante)
        {
            _estudiante = estudiante;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void formVerCronograma_Load(object sender, EventArgs e)
        {
            List<object> cronograma = await HorarioCurso.GetCalendarioEstudiante(_estudiante);
            dgvCronograma.DataSource = cronograma;
        }
    }
}
