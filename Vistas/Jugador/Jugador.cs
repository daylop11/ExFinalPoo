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
using ExFinal.Modelos;
using ExFinal.Vistas;

namespace ExFinal.Vistas
{
    public partial class frmJugador : Form
    {
        public object textNamePlayer { get; private set; }

        public frmJugador()
        {
            InitializeComponent();
        }
        private Equipo_Controllers equipoControllers = new Equipo_Controllers();
        private Jugador_Controllers jugador_Controllers = new Jugador_Controllers();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nuevoContenido = "";

            try
            {
                
                MessageBox.Show("Información editada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNamePlayer.Text == "" || txtPosition.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Jugador_Models jugador = new Jugador_Models
            {
                Nombre = txtNamePlayer.Text,
                Posicion = txtPosition.Text,
                ID_Equipo = (int)comboBox1.SelectedValue
            };
            var mensaje = jugador_Controllers.insertar(jugador);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                MessageBox.Show("Información guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void btnDelete_Click(object sender, EventArgs e)
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

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameEq_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmJugador_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = equipoControllers.ObtenerEquipos();

            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
