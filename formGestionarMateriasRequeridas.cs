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
    public partial class formGestionarMateriasRequeridas : Form, IRecibidorDeItemSeleccionado<Materia>, IGestionMateriasRequeridas
    {
        private Materia _materia;
        private LogicaGestionMateriasRequeridas _logicaGestionMateriasRequeridas;
        public event Func<Materia, List<Materia>>? AlSolicitarMateria;

        public formGestionarMateriasRequeridas(object materia)
        {
            _materia = (Materia)materia;
            _logicaGestionMateriasRequeridas = new LogicaGestionMateriasRequeridas(this);
            InitializeComponent();
            lsbMateriasRequeridas.DisplayMember = "DisplayText";
        }

        public List<Materia> ItemsAMostrar()
        {
            // Seleccionador de item nos solicita las materias a mostrar
            return _logicaGestionMateriasRequeridas.ObtenerMateriasRequeridasPosibles(_materia);
        }

        public void MostrarListaMaterias(List<Materia> listaMateriasRequeridas)
        {
            lsbMateriasRequeridas.DataSource = listaMateriasRequeridas;
        }

        public void RecibirItemSeleccionada(object item)
        {
            // Seleccionador de item nos devuelte el item seleccionado
            Materia materiaSelecionada = (Materia)item;
            _logicaGestionMateriasRequeridas.AgregarMateriaRequerida(_materia, materiaSelecionada);
        }

        private void formGestionarMateriasRequeridas_Load(object sender, EventArgs e)
        {
            if (_materia is not null && AlSolicitarMateria is not null)
            {
                MostrarListaMaterias(AlSolicitarMateria.Invoke(_materia));
            }
        }

        private void btnAgregarMateriaRequerida_Click(object sender, EventArgs e)
        {
            formSeleccionarMateria formSeleccionarMateria = new formSeleccionarMateria(this);
            formSeleccionarMateria.ShowDialog();

            if (_materia is not null && AlSolicitarMateria is not null)
            {
                MostrarListaMaterias(AlSolicitarMateria.Invoke(_materia));
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            Materia materiaSeleccionada = (Materia)lsbMateriasRequeridas.SelectedItem;

            if (materiaSeleccionada is not null)
            {
                _logicaGestionMateriasRequeridas.EliminarMateriaRequerida(_materia, materiaSeleccionada);
                if (_materia is not null && AlSolicitarMateria is not null)
                {
                    MostrarListaMaterias(AlSolicitarMateria.Invoke(_materia));
                }
            }
            else
            {
                OnRemoveError("Selecciones una materia a eliminar");
            }

        }
        public void OnAddOk()
        {
            MessageBox.Show("Materia requerida agregada con exito");
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Materia requerida modificada con exito");
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar la materia requerida: {errorMessage}");
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar la materia requerida: {errorMessage}");
        }

        public void OnRemoveError(string errorMessage)
        {
            MessageBox.Show($"Error al eliminar la materia requerida: {errorMessage}");
        }

        public void OnRemoveOk()
        {
            MessageBox.Show("Materia requerida eliminada con exito");
        }
    }
}
