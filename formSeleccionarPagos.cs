using BibliotecaClases;
using BibliotecaClases.BD;
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
    public partial class formSeleccionarPagos : Form
    {
        private Usuario _estudiante;
        private List<Pago> _listaPagosPendientes;

        private BindingSource bindingSource = new BindingSource();

        public formSeleccionarPagos(Usuario estudiante)
        {
            _estudiante = estudiante;
            InitializeComponent();
        }

        private async void formSeleccionarPagos_Load(object sender, EventArgs e)
        {
            _listaPagosPendientes = await Pago.ObtenerPagoPorEstudiante(_estudiante.Id);

            bindingSource.DataSource = _listaPagosPendientes;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;

            DataGridViewColumn columnaPagar = new DataGridViewCheckBoxColumn();
            columnaPagar.Name = "Pagar";
            columnaPagar.HeaderText = "Pagar";
            dataGridView1.Columns.Add(columnaPagar);

            DataGridViewTextBoxColumn columnaConceptoDePago = new DataGridViewTextBoxColumn();
            columnaConceptoDePago.DataPropertyName = "ConceptoDePago";
            columnaConceptoDePago.Name = "Concepto de pago";
            columnaConceptoDePago.ReadOnly = true;
            dataGridView1.Columns.Add(columnaConceptoDePago);

            DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
            columnaEstado.DataPropertyName = "EstadoDePago";
            columnaEstado.Name = "Estado de Pago";
            columnaEstado.ReadOnly = true;
            dataGridView1.Columns.Add(columnaEstado);

            DataGridViewTextBoxColumn columnaMonto = new DataGridViewTextBoxColumn();
            columnaMonto.DataPropertyName = "Monto";
            columnaMonto.Name = "Monto";
            columnaMonto.ReadOnly = true;
            dataGridView1.Columns.Add(columnaMonto);

        }

        private void btnRealizarPagosSeleccionados_Click(object sender, EventArgs e)
        {
            decimal totalAPagar = 0;
            List<string> conceptos = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object value = row.Cells[0].Value;
                if (value != null && (bool) row.Cells[0].Value)
                {
                    totalAPagar = totalAPagar + (decimal) row.Cells["Monto"].Value;
                    conceptos.Add($"{row.Cells["Concepto de pago"]} - { row.Cells["Monto"].Value}");
                }
            }

            if (totalAPagar == 0) { MessageBox.Show("Debe seleccionar al menos un pago", "Aviso"); return; }

            formRealizarPago formRealizarPago = new formRealizarPago(this, totalAPagar, conceptos);
            formRealizarPago.ShowDialog();

        }

        public async void GuardarPagos(MetodoPago metodoDePago)
        {
            int contador = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object value = row.Cells[0].Value;
                if (value != null && (bool)row.Cells[0].Value)
                {
                    row.Cells["Estado de Pago"].Value = EstadoPago.Pagado;
                    _listaPagosPendientes[contador].MetodoDePago = metodoDePago;
                    _listaPagosPendientes[contador].FechaDePago = DateTime.Now;
                    await _listaPagosPendientes[contador].Update();

                }
                contador++;
            }
            MessageBox.Show("Pago realizado con exito", "Pagos");
        }
    }
}
