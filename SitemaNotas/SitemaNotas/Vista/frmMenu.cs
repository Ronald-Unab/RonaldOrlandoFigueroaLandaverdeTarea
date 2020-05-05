using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SitemaNotas.Vista;
namespace SitemaNotas.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudiantesV Es = new EstudiantesV();
            Es.Show();
        }

        private void mantenimientoDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriasV Ma = new MateriasV();
            Ma.Show();
        }
    }
}
