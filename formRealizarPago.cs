using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formRealizarPago : Form
    {
        private decimal _montoAPagar;
        private List<string> _conceptos;
        private formSeleccionarPagos _formAnterior;

        public formRealizarPago(formSeleccionarPagos formAnterior, decimal montoAPagar, List<string> conceptos)
        {
            _montoAPagar = montoAPagar;
            _conceptos = conceptos;
            _formAnterior = formAnterior;
            InitializeComponent();
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxs())
            {
                _formAnterior.GuardarPagos((MetodoPago)cmbMetodoDePago.SelectedItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos invalidos", "Error");
            }
        }

        private void formRealizarPago_Load(object sender, EventArgs e)
        {
            CargarMetodosDePago();
            txbMontoTotal.Text = $"${_montoAPagar}";
        }

        private void CargarMetodosDePago()
        {
            cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoPago));
        }

        private void VaciarTextBoxs()
        {
            txbCBU.Text = string.Empty;
            txbCCV.Text = string.Empty;
            txbFechaVencimiento.Text = string.Empty;
            txbNumeroTarjeta.Text = string.Empty;
        }

        private bool ValidarTextBoxs()
        {
            string patronTarjeta = @"^[0-9]{16}$";
            string patronCBU = @"^[0-9]{22}$";
            string patronCVV = @"^[0-9]{3}$";
            string patronFecha = @"^(0[0-9]|1[0-2])\/[0-9]{2}$";

            Regex rgTarjeta = new Regex(patronTarjeta);
            Regex rgCBU = new Regex(patronCBU);
            Regex rgCVV = new Regex(patronCVV);
            Regex rgFecha = new Regex(patronFecha);

            MetodoPago metodoDePago = (MetodoPago)cmbMetodoDePago.SelectedItem;
            if (metodoDePago == MetodoPago.Debito || metodoDePago == MetodoPago.Credito)
            {
                if (!rgTarjeta.IsMatch(txbNumeroTarjeta.Text)) 
                {
                    return false;
                }
                else if (!rgCVV.IsMatch(txbCCV.Text))
                {
                    return false;
                }
                else if (!rgFecha.IsMatch(txbFechaVencimiento.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            } else if (metodoDePago == MetodoPago.Transferencia)
            {
                if (!rgCBU.IsMatch(txbCBU.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
                    
        }

        private void cmbMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPago metodoDePago = (MetodoPago)cmbMetodoDePago.SelectedItem;

            VaciarTextBoxs();

            gbPagoConTarjeta.Visible = false;
            gbPagoTransferencia.Visible = false;
            gbPagoEfectivo.Visible = false;
            gbPagoConMP.Visible = false;

            switch (metodoDePago)
            {
                case MetodoPago.Transferencia:
                    gbPagoTransferencia.Visible = true;
                    break;
                case MetodoPago.Efectivo:
                    gbPagoEfectivo.Visible = true;
                    break;
                case MetodoPago.Debito:
                    gbPagoConTarjeta.Visible = true;
                    break;
                case MetodoPago.Credito:
                    gbPagoConTarjeta.Visible = true;
                    break;
                case MetodoPago.MercadoPago:
                    gbPagoConMP.Visible = true;
                    break;
                default:
                    MessageBox.Show("Seleccione un metodo de pago valido");
                    break;
            }

        }
    }
}
