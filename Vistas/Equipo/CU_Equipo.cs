using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExFinal.Controllers;

namespace ExFinal.Vistas.Equipo
{
    public partial class frmCU_Equipo : Form
    {
        public frmCU_Equipo()
        {
            InitializeComponent();
        }
        private Equipo_Controllers equipoController = new Equipo_Controllers();
        private void txtCuEquipo_TextChanged(object sender, EventArgs e)
        {
            txtCuEquipo.Focus();
        }

        private void btnAgregarCU_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBuscarCU_Click(object sender, EventArgs e)
        {
            btnBuscarCU.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarEquipo frm = new frmAgregarEquipo();
            frm.ShowDialog();
        }

        private void frmCU_Equipo_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }
        public void llenarGrilla()
        {
            
            dgvEquipo.DataSource = "";
            dgvEquipo.Columns.Clear();

                dgvEquipo.DataSource = equipoController.ObtenerEquipos();
    
   






            dgvEquipo.Columns["ID"].Visible = false;

        }
    }
}
