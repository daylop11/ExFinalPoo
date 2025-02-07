using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFinal.Vistas
{
    public partial class frmRepPartidos : Form
    {
        public frmRepPartidos()
        {
            InitializeComponent();
        }

        private void frmRepPartidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
