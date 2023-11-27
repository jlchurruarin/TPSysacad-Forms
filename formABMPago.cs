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
            CargarMetodoDePago();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _logicaABMPago.AddPago(_estudiante.Id, cmbConceptosDePago.Text, nudMonto.Value, cmbEstadoDePago.Text, cbbMetodoDePago.Text, dpFechaPago.Value);
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

        private void CargarMetodoDePago()
        {
            cbbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoPago));
        }

        public void MostrarPago(Pago? pago)
        {
            nudMonto.Value = pago.Monto;
            cmbConceptosDePago.Text = Enum.GetName(pago.ConceptoDePago);
            cmbEstadoDePago.Text = Enum.GetName(pago.EstadoDePago);

            if (pago.MetodoDePago is not null) { cbbMetodoDePago.Text = Enum.GetName((MetodoPago)pago.MetodoDePago); }
            if (pago.FechaDePago is not null) { dpFechaPago.Value = (DateTime) pago.FechaDePago;  }
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

        private void cmbEstadoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstadoPago? estadoDePagoSeleccionado = (EstadoPago)cmbEstadoDePago.SelectedItem;
            if (estadoDePagoSeleccionado == EstadoPago.Pagado)
            {
                cbbMetodoDePago.Enabled = true;
                cbbMetodoDePago.SelectedIndex = 0;
                dpFechaPago.Enabled = true;
            }
            else
            {
                cbbMetodoDePago.Enabled = false;
                cbbMetodoDePago.SelectedIndex = -1;
                dpFechaPago.Enabled = false;
            }
        }
    }
}
