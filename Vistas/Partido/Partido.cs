using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ExFinal.Config; 
using System.IO;


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
            string text = txtNameTeam.Text; text = txtNameTeam.Text;
        }
            private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNameTeam.Text;
            

            string datos = $"Nombre: {nombre}";
          
            try
            {
  
                MessageBox.Show("Información guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnEditarPartido_Click(object sender, EventArgs e)
        {
            btnEditarPartido.Enabled = true;
            string text = txtNameTeam.Text; text = txtNameTeam.Text;
            string filePath = "datos_guardados.txt";
            string[] lineas = File.ReadAllLines(filePath);
            string nuevoContenido = "";

            foreach (string linea in lineas)
            {
                if (linea.Contains(txtNameTeam.Text))
                {
                    nuevoContenido += $"Nombre: {txtNameTeam.Text} + Environment.NewLine;;;";
                }
                else
                {
                    nuevoContenido += linea + Environment.NewLine;
                }
            }

            try
            {
                MessageBox.Show("Información editada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        {
                try
                {
                MessageBox.Show("Información eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
