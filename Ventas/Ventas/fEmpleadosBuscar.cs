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
    public partial class fEmpleadosBuscar : Form
    {
        dsGeneral ds = new dsGeneral();
        dsGeneralTableAdapters.taEmpleadoo dte = new dsGeneralTableAdapters.taEmpleadoo();

        public fEmpleadosBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            try
            {
            string nom, ape,dni;
            nom = tbxNombresLista.Text;
            ape = tbxApellidosLista.Text;
            dni = tbxDNI.Text;
            dte.Buscar(ds.Empleadoo,nom,ape,dni);
            foreach (DataRow item in ds.Empleadoo.Rows)
            {
                dgvLista.Rows.Add(item[0].ToString(),item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString());
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLista.RowCount>0)
            {
                Ventas.idE =Convert.ToInt32( dgvLista.CurrentRow.Cells[0].Value);
                Ventas.datosE = dgvLista.CurrentRow.Cells[1].Value.ToString() + " " + dgvLista.CurrentRow.Cells[2].Value.ToString() + " " + dgvLista.CurrentRow.Cells[3].Value.ToString() + " " + dgvLista.CurrentRow.Cells[4].Value.ToString()+dgvLista.CurrentRow.Cells[5].Value.ToString();
                this.Close();
            }
        }
    }
}
