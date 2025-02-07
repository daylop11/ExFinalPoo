using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFinal.Vistas.Equipo
{
    public partial class frmCU_Equipo : Form
    {
        public frmCU_Equipo()
        {
            InitializeComponent();
        }

        private void txtCuEquipo_TextChanged(object sender, EventArgs e)
        {
            txtCuEquipo.Focus();
        }

        private void btnAgregarCU_Click(object sender, EventArgs e)
        {
            btnCancelarCU.Enabled = false;
        }

        private void btnBuscarCU_Click(object sender, EventArgs e)
        {
            btnBuscarCU.Enabled = true;
        }
    }
}
