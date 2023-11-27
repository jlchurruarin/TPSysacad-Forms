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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSysacad___Forms
{
    public partial class formABMMateria : Form, IABMMateria
    {
        private LogicaABMMateria _logicaABMMateria;

        public Materia? Materia { get; }

        public event Action? AlSolicitarMateria;

        public formABMMateria()
        {
            _logicaABMMateria = new LogicaABMMateria(this);
            InitializeComponent();

            nudCreditosBrindados.Maximum = int.MaxValue;
            nudCreditosNecesarios.Maximum = int.MaxValue;
        }

        public formABMMateria(object selectedItem) : this()
        {
            Materia = selectedItem as Materia;
        }

        private void formABMMateria_Load(object sender, EventArgs e)
        {
            if (Materia is not null)
            {
                AlSolicitarMateria?.Invoke();
            }

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Materia is not null)
            {
                _logicaABMMateria.UpdateMateria(Materia.Id, txbNombre.Text, txbDescripcion.Text, nudCreditosBrindados.Value.ToString(), nudCreditosNecesarios.Value.ToString());
            }
            else
            {
                _logicaABMMateria.AddMateria(txbNombre.Text, txbDescripcion.Text, nudCreditosBrindados.Value.ToString(), nudCreditosNecesarios.Value.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarMateria(Materia? materia)
        {
            if (materia is null) return;

            txbNombre.Text = materia.Nombre;
            txbDescripcion.Text = materia.Descripcion;
            nudCreditosBrindados.Value = materia.CreditosBrindados;
            nudCreditosNecesarios.Value = materia.CreditosNecesarios;
        }

        public void OnAddOk()
        {
            MessageBox.Show("Materia agregada con exito", "Aviso");
            this.Close();
        }

        public void OnUpdateOk()
        {
            MessageBox.Show("Materia modificada con exito", "Aviso");
            this.Close();
        }

        public void OnAddError(string errorMessage)
        {
            MessageBox.Show($"Error al agregar la Materia: {errorMessage}", "Error");
        }

        public void OnUpdateError(string errorMessage)
        {
            MessageBox.Show($"Error al modificar la Materia: {errorMessage}", "Error");
        }
    }
}
