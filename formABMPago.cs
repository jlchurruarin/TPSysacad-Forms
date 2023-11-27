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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formABMPago : Form, ISQLAddUpdateVista
    {
        private Usuario _estudiante;
        private LogicaABMPago _logicaABMPago;

        public event Action<string>? AlSolicitarPago;

        public formABMPago(Usuario estudiante)
        {
            _logicaABMPago = new LogicaABMPago(this);
            _estudiante = estudiante;
            InitializeComponent();
        }

        private void formABMPago_Load(object sender, EventArgs e)
        {
            CargarConceptosDePago();
            CargarEstadoDePago();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _logicaABMPago.AddPago(_estudiante.Id, cmbConceptosDePago.Text, nudMonto.Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarConceptosDePago()
        {
            cmbConceptosDePago.DataSource = Enum.GetValues(typeof(ConceptoPago));
        }

        private void CargarEstadoDePago()
        {
            cmbEstadoDePago.DataSource = Enum.GetValues(typeof(EstadoPago));
        }

        public void MostrarPago(Pago? pago)
        {
            nudMonto.Value = pago.Monto;
            cmbConceptosDePago.Text = Enum.GetName(pago.ConceptoDePago);
            cmbEstadoDePago.Text = Enum.GetName(pago.EstadoDePago);
        }

        public void OnAddOk()
        {
            MessageBox.Show("Se agrego el pago con exito");
            this.Close();
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Se modifico el pago con exito");
            this.Close();
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar el pago: {errorMessage}");
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar el pago: {errorMessage}");
        }
    }
}
