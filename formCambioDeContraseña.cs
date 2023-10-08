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
    public partial class formCambioDeContraseña : Form
    {
        private Usuario _usuario;

        public formCambioDeContraseña(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
        }

        private bool ValidarContraseñasIguales()
        {
            if (textBox1.Text == textBox2.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarContraseñasIguales())
            {
                _usuario.Contraseña = Sistema.EncriptarTexto(textBox1.Text);
                _usuario.CambioDeContraseñaObligatorio = false;
                MessageBox.Show("Contraseña Modificada, por favor vuelva a ingresar", "Cambio de contraseña");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales");
            }
        }
    }
}
