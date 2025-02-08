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

namespace ExFinal.Vistas
{
    public partial class frmAgregarEquipo : Form
    {
        public frmAgregarEquipo()
        {
            InitializeComponent();
        }
        private Equipo_Controllers equipoControllers = new Equipo_Controllers();
 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Equipo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNameEq.Text == "" || txtCiudad.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Equipo_Models equipo = new Equipo_Models
            {
                Nombre = txtNameEq.Text,
                Ciudad = txtCiudad.Text
            };
            var mensaje = equipoControllers.AgregarEquipo(equipo);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void txtNameEq_TextChanged(object sender, EventArgs e)
        {
            txtNameEq.Enabled= true;
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            txtCiudad.Enabled = true;
        }
    }
}
