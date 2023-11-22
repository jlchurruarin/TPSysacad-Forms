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
        private FakeBaseDeDatos _baseDeDatos;

        public formVerCronograma(Usuario estudiante, FakeBaseDeDatos baseDeDatos)
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
            //List<string> calendario = Sistema.GenerarCalendario(_baseDeDatos.ListaCursos, _estudiante);
            List<string> calendario = new List<string>();
            foreach (string linea in calendario)
            {
                textBox1.Text += linea + Environment.NewLine;
            }
        }
    }
}
