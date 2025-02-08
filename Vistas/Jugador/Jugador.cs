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

namespace ExFinal.Vistas
{
    public partial class frmJugador : Form
    {
        public object textNamePlayer { get; private set; }

        public frmJugador()
        {
            InitializeComponent();
        }

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
       
            string nombre = txtNamePlayer.Text;
            string telefono = txtPosition.Text;

            string datos = $"Nombre: {nombre}, Posicion: {txtPosition}";
            string file= "datos_guardados.txt";

            try
            {
                MessageBox.Show("Información guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnGuardarPlayer.Enabled = true;
           string text= txtPosition.Text;
            
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
    }
}
