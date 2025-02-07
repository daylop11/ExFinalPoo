using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExFinal.Vistas;
using ExFinal.Properties;
using ExFinal.Controllers;

namespace ExFinal.Vistas
{
    public partial class frmPartido : Form
    {
        private object comboBoxEq2Checked;

        public object comboBoxEq1SelectedIndex { get; private set; }
        public object comboBoxEq1Checked { get; private set; }

        public frmPartido()
        {
            InitializeComponent();
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            btnGuardarPartido.Enabled = false;
        }

        private void btnEditarPartido_Click(object sender, EventArgs e)
        {
            btnEditarPartido.Enabled = true;
        }

        private void btnDeletePatido_Click(object sender, EventArgs e)
        {
            btnDeletePatido.Enabled = false;
        }

        private void txtNameTeam_TextChanged(object sender, EventArgs e)
        {
            txtNameTeam.Enabled = true;
        }

        private void comboBoxEq1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEq1Checked = true;
        }

        private void ComboBoxEq2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEq2Checked = true;
        }

        private void frmPartido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_EqDeportivosDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.gestion_EqDeportivosDataSet.Equipo);

        }
    }
}
