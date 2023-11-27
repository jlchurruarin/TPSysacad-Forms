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
    public partial class formGestionarPagosEstudiante : Form, IGestionPagoEstudiante
    {
        private Usuario _estudiante;
        private LogicaGestionPagoEstudiante _logicaGestionPagoEstudiante;
        public event Func<Usuario, List<Pago>>? AlSolicitarPagos;

        public formGestionarPagosEstudiante(object estudiante)
        {
            _estudiante = estudiante as Usuario;
            InitializeComponent();
            lsbPagos.DisplayMember = "DisplayText";
            _logicaGestionPagoEstudiante = new LogicaGestionPagoEstudiante(this);
        }

        private void formGestionarPagosEstudiante_Load(object sender, EventArgs e)
        {
            MostrarListaPagos(AlSolicitarPagos?.Invoke(_estudiante));
        }

        public void MostrarListaPagos(List<Pago>? listaPagos)
        {
            lsbPagos.DataSource = listaPagos;
        }

        public void OnRemoveError(string errorMessage)
        {
            MessageBox.Show($"Error al borrar el pago: {errorMessage}");
        }

        public void OnRemoveOk()
        {
            MessageBox.Show($"Pago borrado con exito");
            MostrarListaPagos(AlSolicitarPagos?.Invoke(_estudiante));
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            formABMPago formABMPago = new formABMPago(_estudiante);
            formABMPago.ShowDialog();
            MostrarListaPagos(AlSolicitarPagos?.Invoke(_estudiante));
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            _logicaGestionPagoEstudiante.EliminarPago(lsbPagos.SelectedItem);
        }
    }
}
