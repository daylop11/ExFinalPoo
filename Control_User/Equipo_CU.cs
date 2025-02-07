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
    public partial class Equipo_CU : UserControl
    {
        public Equipo_CU()
        {
            InitializeComponent();
        }

        private void Equipo_CU_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            this.txtBox1.Text= string.Empty;
        }
    }
}
