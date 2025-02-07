using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ExFinal.Config; 

namespace ExFinal.Vistas

{
    public partial class frmPartido : Form
    {
        private object comboBoxEq2Checked;

        public object comboBoxEq1SelectedIndex { get; private set; }
        public object comboBoxEq1Checked { get; private set; }
        public object ID { get; private set; }
        public object Nombre { get; private set; }
        public object Ciudad { get; private set; }

        public frmPartido()
        {
            InitializeComponent();
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            btnGuardarPartido.Enabled = false;
            string text = txtNameTeam.Text;
        }

        private void btnEditarPartido_Click(object sender, EventArgs e)
        {
            btnEditarPartido.Enabled = true;
            string text = txtNameTeam.Text; text = txtNameTeam.Text;
        }
            public void ActualizarEquipo(frmPartido partido)
        {
            }       
        

        private void btnDeletePatido_Click(object sender, EventArgs e)
        {
            btnDeletePatido.Enabled = false;
        }

        public void EliminarEquipo(int id)
        {
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
            this.equipoTableAdapter.Fill(this.gestion_EqDeportivosDataSet.Equipo);

        }
    }
}
