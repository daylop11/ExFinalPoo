using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ExFinal.Config; 
using System.IO;
using ExFinal.Modelos;
using ExFinal.Controllers;


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
        private Equipo_Controllers equipoControllers = new Equipo_Controllers();
        private Partido_Controllers partidoControllers = new Partido_Controllers();
        public void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            if(comboBoxEq1.SelectedIndex == -1 || comboBoxEq2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtResultado.Text == "")
            {
                MessageBox.Show("Ingrese un resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboBoxEq1.SelectedValue == comboBoxEq2.SelectedValue)
            {
                MessageBox.Show("Los equipos tienen que ser distintos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string text = txtResultado.Text; 
            var partido = new Partido_Models
            {
                Fecha = dateTimePicker.Value.ToString(),
                id_Equipo1 = (int)comboBoxEq1.SelectedValue,
                id_Equipo2 = (int)comboBoxEq2.SelectedValue,
                Resultado = txtResultado.Text
            };

            var mensaje = partidoControllers.AgregarPartido(partido);
            if (mensaje == "OK") {
                MessageBox.Show("Partido guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar el partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtResultado.Text;
            

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
            string text = txtResultado.Text; text = txtResultado.Text;
            string filePath = "datos_guardados.txt";
            string[] lineas = File.ReadAllLines(filePath);
            string nuevoContenido = "";

            foreach (string linea in lineas)
            {
                if (linea.Contains(txtResultado.Text))
                {
                    nuevoContenido += $"Nombre: {txtResultado.Text} + Environment.NewLine;;;";
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
            txtResultado.Enabled = true;
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
            comboBoxEq1.DataSource =  equipoControllers.ObtenerEquipos();

            comboBoxEq1.ValueMember = "ID";
            comboBoxEq1.DisplayMember = "Nombre";

            comboBoxEq2.DataSource =  equipoControllers.ObtenerEquipos();
            comboBoxEq2.ValueMember = "ID";
            comboBoxEq2.DisplayMember = "Nombre";
        }
    }
}
