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
    public partial class formVerCronograma : Form
    {
        private Estudiante _estudiante;
        private BaseDeDatos _baseDeDatos;

        public formVerCronograma(Estudiante estudiante, BaseDeDatos baseDeDatos)
        {
            _estudiante = estudiante;
            _baseDeDatos = baseDeDatos;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formVerCronograma_Load(object sender, EventArgs e)
        {
            List<Curso> listaCursos = _baseDeDatos.BuscarCursosInscriptos(_estudiante);
            string[] arr = new string[listaCursos.Count];
            foreach (Curso curso in listaCursos)
            {
                textBox1.Text += curso.ToString() + Environment.NewLine;
            }
        }
    }
}
