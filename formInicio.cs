using BibliotecaClases;

namespace TPSysacad___Forms
{
    public partial class formInicio : Form
    {

        public formInicio()
        {
            InitializeComponent();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Form formIngresarEstudiante = new formIngresarEstudiante(this);
            formIngresarEstudiante.Show();
            this.Hide();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Form formIngresarProfesor = new formIngresarProfesor(this);
            formIngresarProfesor.Show();
            this.Hide();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            Form formIngresarAdministrador = new formIngresarAdministrador(this);
            formIngresarAdministrador.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formInicio_Load(object sender, EventArgs e)
        {

        }
    }
}