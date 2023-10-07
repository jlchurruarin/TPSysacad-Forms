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
    public partial class formSeleccionarMateria : Form
    {
        private string _idMateria;

        public formSeleccionarMateria(ref string idMateria)
        {
            _idMateria = idMateria;
            InitializeComponent();
        }
    }
}
