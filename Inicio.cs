﻿using System;
using System.Windows.Forms;
using ExFinal.Vistas;
using ExFinal.Vistas.Equipo;

namespace ExFinal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            frmCU_Equipo equipo = new frmCU_Equipo();
            equipo.Show();  
        }
        private void btnJugador_Click(object sender, EventArgs e)
        {


            //frmJugador jugador = new frmJugador();
            //jugador.ShowDialog();
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            frmPartido partidos=new frmPartido();
            partidos.ShowDialog();
        }

        public void LbelWelcome_Click(object sender, EventArgs e)
        {

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            btnSave_Click equipos=new btnSave_Click();
            equipos.ShowDialog();
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click equipos=new btnEdit_Click();
            equipos.ShowDialog();
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar_Click equipos=new btnCerrar_Click();
            equipos.ShowDialog();
        }

        public void PnlEditClose_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRp_Click(object sender, EventArgs e)
        {
            frmRepPartidos equipos = new frmRepPartidos();
            equipos.ShowDialog();
        }
        
        btnRp_Click partido=new btnRp_Click();
            
        }
    }

    internal class btnRp_Click
    {
        internal void ShowDialog()
        {
        }
    }

    internal class frmEquiposReport
    {
        internal void ShowDialog()
        {
        }
    }

    public class btnCerrar_Click
    {
        public void ShowDialog()
        {
        }
    }

    internal class btnEdit_Click
    {
        internal void ShowDialog()
        {
        }
    }

    public class btnSave_Click
    {
        internal void ShowDialog()
        {
        }
    }
