using BibliotecaClases;
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
        private List<Pago> _listaPagos;

        private BindingSource bindingSource = new BindingSource();

        public formSeleccionarPagos(List<Pago> pagos)
        {
            _listaPagos = pagos;

            InitializeComponent();
        }

        private void formSeleccionarPagos_Load(object sender, EventArgs e)
        {
            List<Pago> _listaPagosPendientes = _listaPagos.Where(p => p.EstadoDePago != EstadoDePago.Pagado).ToList();

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

            formRealizarPago formRealizarPago = new formRealizarPago(totalAPagar, conceptos);
            DialogResult dialogResultRealizarPago = formRealizarPago.ShowDialog();

            if (dialogResultRealizarPago == DialogResult.OK) 
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    object value = row.Cells[0].Value;
                    if (value != null && (bool)row.Cells[0].Value)
                    {
                        row.Cells["Monto"].Value = 0m;
                        row.Cells["Estado de Pago"].Value = EstadoDePago.Pagado;
                    }
                }
                MessageBox.Show("Pago realizado con exito", "Pagos");
            }
            else
            {
                MessageBox.Show("No se realizó el pago correctamente", "Pagos");
            }


        }
    }
}
