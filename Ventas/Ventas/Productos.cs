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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        //BD
        dsGeneral ds = new dsGeneral();
        dsGeneralTableAdapters.taProducto dte = new dsGeneralTableAdapters.taProducto();
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (btnGuardar.Text.Equals("Guardar"))
            {
                string des = tbxDescripcion.Text;
                decimal precio = Convert.ToDecimal(tbxPrecio.Text);
                string marca = tbxMarca.Text;
                int r = dte.Agregar(des, precio, marca);
                if (r > 0)
                {
                    MessageBox.Show("Agregar");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar.");
                }
                Limpiar();
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                var nf = dgvProductos.Rows.Count;
                string des, Marca;
                decimal precio;
                des = tbxDescripcion.Text;
                Marca = tbxMarca.Text;
                precio = Convert.ToDecimal(tbxPrecio.Text);

                if (nf > 0)
                {
                    int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                    int r = dte.Modificar(des,precio,Marca, id);
                    if (r > 0)
                    {
                        MessageBox.Show("Modificado");
                    }
                    Limpiar();
                    btnGuardar.Text = "Guardar";
                }
            }
        }

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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            int r= dte.Borrar(id);
            if (r > 0)
            {
                btnBuscar.PerformClick();
                MessageBox.Show("Eliminado");
            }   
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxDescripcion.Text=dgvProductos.CurrentRow.Cells[1].Value.ToString();
            tbxPrecio.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            tbxMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            btnGuardar.Text = "Modificar";
            tabControl1.SelectedIndex = 0;  
        }
        void Limpiar() {
            tbxDescripcion.Clear();
            tbxPrecio.Clear();
            tbxMarca.Clear();
            tbxDescripcion.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
    }
}
