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
         frmEquiposReport equipos = new frmEquiposReport();
            equipos.ShowDialog();
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            frmAgregarEquipo equipos=new frmAgregarEquipo();
            equipos.ShowDialog();
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            frmPartido equipos=new frmPartido();
            equipos.ShowDialog();
        }

        private void LbelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave_Click equipos=new btnSave_Click();
            equipos.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click equipos=new btnEdit_Click();
            equipos.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar_Click equipos=new btnCerrar_Click();
            equipos.ShowDialog();
        }
    }

    internal class btnCerrar_Click
    {
        internal void ShowDialog()
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
}
