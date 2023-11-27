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
using ZstdSharp.Unsafe;

namespace TPSysacad___Forms
{
    public partial class formGestionarInscriptos : Form, IGestionarInscripciones
    {
        private Curso _curso;
        private LogicaGestionInscripciones _logicaGestionDeInscripciones;
        public event Func<Curso, EstadoDeInscripcion?, List<Usuario>>? AlSolicitarEstudiantes;


        public formGestionarInscriptos(object curso)
        {
            _curso = (Curso)curso;
            _logicaGestionDeInscripciones = new LogicaGestionInscripciones(this);
            InitializeComponent();
        }

        private void formGestionarInscriptos_Load(object sender, EventArgs e)
        {
            if (AlSolicitarEstudiantes is not null)
            {
                MostrarListaEnEspera(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.EnListaDeEspera));
                MostrarListaCursando(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Cursando));
                MostrarListaLibre(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Libre));
                MostrarListaCursadaAprobada(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.CursadaAprobada));
                MostrarListaFinalAprobado(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.FinalAprobado));
            }
        }

        private void MostrarListaCursadaAprobada(List<Usuario> listaUsuarios)
        {
            lsbCursadaAprobada.DataSource = listaUsuarios;
        }

        private void MostrarListaCursando(List<Usuario> listaUsuarios)
        {
            lsbCursando.DataSource = listaUsuarios;
        }

        private void MostrarListaEnEspera(List<Usuario> listaUsuarios)
        {
            lsbEnListaDeEspera.DataSource = listaUsuarios;
        }

        private void MostrarListaFinalAprobado(List<Usuario> listaUsuarios)
        {
            lsbFinalAprobado.DataSource = listaUsuarios;
        }

        private void MostrarListaLibre(List<Usuario> listaUsuarios)
        {
            lsbLibres.DataSource = listaUsuarios;
        }

        public void OnRemoveError(string errorMessage)
        {
            MessageBox.Show($"Error al eliminar la inscripción: {errorMessage}");
        }

        public void OnRemoveOK()
        {
            MessageBox.Show($"Inscripción eliminada con exito");

            if (AlSolicitarEstudiantes is not null)
            {
                MostrarListaEnEspera(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.EnListaDeEspera));
                MostrarListaCursando(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Cursando));
                MostrarListaLibre(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Libre));
                MostrarListaCursadaAprobada(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.CursadaAprobada));
                MostrarListaFinalAprobado(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.FinalAprobado));
            }
        }

        private void btnEliminarCursando_Click(object sender, EventArgs e)
        {
            EliminarEstudiante(lsbCursando);
        }

        private void btnEliminarLibre_Click(object sender, EventArgs e)
        {
            EliminarEstudiante(lsbLibres);
        }

        private void btnEliminarCursadaAprobada_Click(object sender, EventArgs e)
        {
            EliminarEstudiante(lsbCursadaAprobada);
        }

        private void btnEliminarFinalAprobado_Click(object sender, EventArgs e)
        {
            EliminarEstudiante(lsbFinalAprobado);
        }

        private void btnEliminarEnEspera_Click(object sender, EventArgs e)
        {
            EliminarEstudiante(lsbEnListaDeEspera);
        }

        private void EliminarEstudiante(ListBox lsb)
        {
            if (lsb.SelectedIndex == -1) { MessageBox.Show("Debe selecionar un estudiante"); return; }
            Usuario estudiante = (Usuario)lsb.SelectedItem;

            _logicaGestionDeInscripciones.EliminarInscripcion(estudiante, _curso);

            if (AlSolicitarEstudiantes is not null)
            {
                MostrarListaEnEspera(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.EnListaDeEspera));
                MostrarListaCursando(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Cursando));
                MostrarListaLibre(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Libre));
                MostrarListaCursadaAprobada(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.CursadaAprobada));
                MostrarListaFinalAprobado(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.FinalAprobado));
            }
        }

        private void btnModificarCursando_Click(object sender, EventArgs e)
        {
            ModificarInscripcion(lsbCursando);
        }

        private void btnModificarLibre_Click(object sender, EventArgs e)
        {
            ModificarInscripcion(lsbLibres);
        }

        private void btnModificarCursadaAprobada_Click(object sender, EventArgs e)
        {
            ModificarInscripcion(lsbCursadaAprobada);
        }

        private void btnModificarFinalAprobado_Click(object sender, EventArgs e)
        {
            ModificarInscripcion(lsbFinalAprobado);
        }

        private void btnModificarEnListaDeEspera_Click(object sender, EventArgs e)
        {
            ModificarInscripcion(lsbEnListaDeEspera);
        }

        private void ModificarInscripcion(ListBox lsb)
        {
            if (lsb.SelectedIndex == -1) { MessageBox.Show("Debe selecionar un estudiante de la lista"); return; }

            Usuario estudiante = (Usuario)lsb.SelectedItem;
            formABMInscripcion formInscripcion = new formABMInscripcion(_curso, estudiante);
            formInscripcion.ShowDialog();

            if (AlSolicitarEstudiantes is not null)
            {
                MostrarListaEnEspera(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.EnListaDeEspera));
                MostrarListaCursando(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Cursando));
                MostrarListaLibre(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Libre));
                MostrarListaCursadaAprobada(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.CursadaAprobada));
                MostrarListaFinalAprobado(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.FinalAprobado));
            }
        }

        private void btnAgregarInscripción_Click(object sender, EventArgs e)
        {
            formABMInscripcion formInscripcion = new formABMInscripcion(_curso, null);
            formInscripcion.ShowDialog();

            if (AlSolicitarEstudiantes is not null)
            {
                MostrarListaEnEspera(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.EnListaDeEspera));
                MostrarListaCursando(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Cursando));
                MostrarListaLibre(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.Libre));
                MostrarListaCursadaAprobada(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.CursadaAprobada));
                MostrarListaFinalAprobado(AlSolicitarEstudiantes.Invoke(_curso, EstadoDeInscripcion.FinalAprobado));
            }
        }
    }
}
