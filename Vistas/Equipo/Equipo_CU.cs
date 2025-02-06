using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFinal.Vistas.Equipo
{
    public partial class frmEquiposReport : Form
    {
        public frmEquiposReport()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_EqDeportivosDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.gestion_EqDeportivosDataSet.Equipo);
            this.reportViewer1.RefreshReport();
        }
    }
}
