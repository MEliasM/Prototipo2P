using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmFormulario : Form
    {
        clsControlador cn = new clsControlador();
        public frmFormulario()
        {
            InitializeComponent();
        }

       
        private void btnForm_Click(object sender, EventArgs e)
        {
            string tabla = "Alumnos";
            DataTable dt = cn.llenartbl(tabla);
            dgvForm.DataSource = dt;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "Maestros";
            DataTable dt = cn.llenartbl(tabla);
            dgvForm.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tabla = "Notas";
            DataTable dt = cn.llenartbl(tabla);
            dgvForm.DataSource = dt;
        }
    }
}
