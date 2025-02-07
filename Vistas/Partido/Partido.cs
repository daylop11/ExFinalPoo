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
        public object comboBoxEq2Checked;

        public object comboBoxEq1SelectedIndex { get; set; }
        public object comboBoxEq1Checked { get; set; }
        public object ID { get; set; }
        public object Nombre { get;set; }
        public object Ciudad { get;set; }

        public frmPartido()
        {
            InitializeComponent();
        }

        public void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            btnGuardarPartido.Enabled = false;
            string text = txtNameTeam.Text;
        }

        public void btnEditarPartido_Click(object sender, EventArgs e)
        {
            btnEditarPartido.Enabled = true;
            string text = txtNameTeam.Text; text = txtNameTeam.Text;
        }
            public void ActualizarEquipo(frmPartido partido)
        {
            }       
        

        public void btnDeletePatido_Click(object sender, EventArgs e)
        {
            btnDeletePatido.Enabled = false;
        }

        public void EliminarEquipo(int id)
        {
        }

        public void txtNameTeam_TextChanged(object sender, EventArgs e)
        {
            txtNameTeam.Enabled = true;
        }

        public void comboBoxEq1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEq1Checked = true;
        }

        public void ComboBoxEq2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEq2Checked = true;
        }

        public void frmPartido_Load(object sender, EventArgs e)
        {
            this.equipoTableAdapter.Fill(this.gestion_EqDeportivosDataSet.Equipo);

        }
    }
}
