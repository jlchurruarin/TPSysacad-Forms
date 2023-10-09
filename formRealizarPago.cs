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

        public formRealizarPago(decimal montoAPagar, List<string> conceptos)
        {
            _montoAPagar = montoAPagar;
            _conceptos = conceptos;
            InitializeComponent();
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxs())
            {
                DialogResult = DialogResult.OK;
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
            cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoDePago));
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

            MetodoDePago metodoDePago = (MetodoDePago)cmbMetodoDePago.SelectedItem;
            if (metodoDePago == MetodoDePago.Debito || metodoDePago == MetodoDePago.Credito)
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
            } else if (metodoDePago == MetodoDePago.Transferencia)
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
            MetodoDePago metodoDePago = (MetodoDePago)cmbMetodoDePago.SelectedItem;

            VaciarTextBoxs();

            gbPagoConTarjeta.Visible = false;
            gbPagoTransferencia.Visible = false;
            gbPagoEfectivo.Visible = false;
            gbPagoConMP.Visible = false;

            switch (metodoDePago)
            {
                case MetodoDePago.Transferencia:
                    gbPagoTransferencia.Visible = true;
                    break;
                case MetodoDePago.Efectivo:
                    gbPagoEfectivo.Visible = true;
                    break;
                case MetodoDePago.Debito:
                    gbPagoConTarjeta.Visible = true;
                    break;
                case MetodoDePago.Credito:
                    gbPagoConTarjeta.Visible = true;
                    break;
                case MetodoDePago.MercadoPago:
                    gbPagoConMP.Visible = true;
                    break;
                default:
                    MessageBox.Show("Seleccione un metodo de pago valido");
                    break;
            }

        }
    }
}
