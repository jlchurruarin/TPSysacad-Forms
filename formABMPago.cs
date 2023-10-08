using BibliotecaClases;
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
    public partial class formABMPago : Form
    {
        private Pago _pago;

        public formABMPago(Pago pago)
        {
            _pago = pago;
            InitializeComponent();
        }

        private void formABMPago_Load(object sender, EventArgs e)
        {
            CargarConceptosDePago();
            CargarEstadoDePago();

            nudMonto.Value = _pago.Monto;
            cmbConceptosDePago.Text = Enum.GetName(_pago.ConceptoDePago);
            cmbEstadoDePago.Text = Enum.GetName(_pago.EstadoDePago);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarPago();
                GuardarPago();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CargarConceptosDePago()
        {
            cmbConceptosDePago.DataSource = Enum.GetValues(typeof(ConceptoPago));
        }

        private void CargarEstadoDePago()
        {
            cmbEstadoDePago.DataSource = Enum.GetValues(typeof(EstadoDePago));
        }

        private void ValidarPago()
        {

            if (Enum.TryParse(typeof(ConceptoPago), cmbConceptosDePago.Text, out object? conceptoPago) == false) { throw new Exception("Concepto de pago no valido"); }
            if (nudMonto.Value <= 0) { throw new Exception("Monto de pago no valido"); }
            if (Enum.TryParse(typeof(EstadoDePago), cmbEstadoDePago.Text, out object? estadoPago) == false) { throw new Exception("Estado de pago no valido"); }
        }

        private void GuardarPago()
        {
            Enum.TryParse(typeof(ConceptoPago), cmbConceptosDePago.Text, out object? conceptoPago);
            Enum.TryParse(typeof(EstadoDePago), cmbEstadoDePago.Text, out object? estadoPago);
            _pago.Monto = nudMonto.Value;
            _pago.ConceptoDePago = (ConceptoPago) conceptoPago;
            _pago.EstadoDePago = (EstadoDePago) estadoPago;
        }
    }
}
