using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmclientes_Click(object sender, EventArgs e)
        {
            Clientes formcliente = new Clientes();
            formcliente.MdiParent = this;
            formcliente.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados formempleado = new Empleados();
            formempleado.MdiParent = this;
            formempleado.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Ventas aux = new Ventas();
            aux.MdiParent = this;
            aux.Show();
        }

    }
}
