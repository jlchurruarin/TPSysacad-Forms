using BibliotecaClases;
using BibliotecaClases.BD;
using BibliotecaClases.Interfaces;
using BibliotecaClases.Logica;

namespace TPSysacad___Forms
{
    public partial class formABMInscripcion : Form, IABMInscripcion, IRecibidorDeItemSeleccionado<Usuario>
    {
        private Curso _curso;
        private Usuario? _estudiante;
        private bool _updateFlag;
        private LogicaABMInscripcion _logicaABMInscripcion;

        public event Action<Curso, Usuario>? AlSolicitarInscripcion;

        public formABMInscripcion(Curso curso, Usuario? estudiante)
        {
            _estudiante = estudiante;
            _curso = curso;
            _logicaABMInscripcion = new LogicaABMInscripcion(this);
            InitializeComponent();
        }

        private void formABMInscripcion_Load(object sender, EventArgs e)
        {
            txbCurso.Text = _curso.DisplayText;
            cbbEstadoDeInscripción.DataSource = Enum.GetNames(typeof(EstadoDeInscripcion));

            if (_estudiante is not null)
            {
                _updateFlag = true;
                txbEstudiante.Text = _estudiante.DisplayText;
                btnBuscarEstudiante.Visible = false;
                AlSolicitarInscripcion?.Invoke(_curso, _estudiante);
            }
            else
            {
                _updateFlag = false;
                btnBuscarEstudiante.Visible = true;
            }
        }

        public List<Usuario> ItemsAMostrar()
        {
            return Usuario.GetAll(TipoDeUsuario.Estudiante);
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar la inscripción {errorMessage}");
        }

        public void OnAddOk()
        {
            MessageBox.Show("Inscripción agregada con exito");
            this.Close();
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar la inscripción {errorMessage}");
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Inscripción modificada con exito");
            this.Close();
        }

        public void RecibirItemSeleccionada(object item)
        {
            _estudiante = (Usuario)item;
            txbEstudiante.Text = _estudiante.DisplayText;
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            formSeleccionarEstudiante formSeleccionarEstudiante = new formSeleccionarEstudiante(this);
            formSeleccionarEstudiante.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_estudiante == null) { MessageBox.Show("Debe seleccionar un estudiante"); return; }

            DateTime fechaDeInscripcion = dateTimePicker1.Value;

            if (_updateFlag)
            {
                _logicaABMInscripcion.ModificarInscripcion(_estudiante.Id, _curso.Id, cbbEstadoDeInscripción.Text, fechaDeInscripcion);
            }
            else
            {
                _logicaABMInscripcion.AgregarInscripcion(_estudiante.Id, _curso.Id, cbbEstadoDeInscripción.Text, fechaDeInscripcion);
            }
        }

        public void MostrarInscripcion(Inscripcion inscripcion)
        {
            cbbEstadoDeInscripción.Text = Enum.GetName(inscripcion.EstadoDeInscripcion);
            dateTimePicker1.Value = inscripcion.FechaInscripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
