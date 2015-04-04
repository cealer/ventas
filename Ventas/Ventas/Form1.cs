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
    }
}
