﻿using System;
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
           
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardarPlayer.Enabled = true;
           string text= txtPosition.Text;

        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            btnDeletePlayer.Enabled = false;
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
