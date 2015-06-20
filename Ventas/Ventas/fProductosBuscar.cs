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
    public partial class fProductosBuscar : Form
    {
        public fProductosBuscar()
        {
            InitializeComponent();
        }

        dsGeneral ds = new dsGeneral();
        dsGeneralTableAdapters.taProducto dte = new dsGeneralTableAdapters.taProducto();

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvProductos.Rows.Clear();
            string des = tbxDesBuscar.Text.Trim();
            string mar= tbxMarcaBuscar.Text.Trim();
            dte.Buscar(ds.Producto,des,mar);

            foreach (DataRow item in ds.Producto.Rows)
            {
                dgvProductos.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }

        void LimpiarBuscar() {
            tbxMarcaBuscar.Clear();
            tbxDesBuscar.Clear();
            tbxDesBuscar.Focus();
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            LimpiarBuscar();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount>0)
            {
                Ventas.idP =(int) dgvProductos.CurrentRow.Cells[0].Value;
                Ventas.precioP = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[2].Value.ToString());
                Ventas.datosP = dgvProductos.CurrentRow.Cells[1].Value+" -  "+dgvProductos.CurrentRow.Cells[3].Value;
                Ventas.cantidadP =Convert.ToInt32(numCantidad.Value);
                this.Close();
            }
        }

        private void fProductosBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}