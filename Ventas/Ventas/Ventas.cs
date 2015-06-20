using System;
using System.Collections;
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

    public partial class Ventas : Form
    {
        //Variables para guardar el cliente actual
        public static int idC=0;
        public static string datosC = "";
        //Variables para guardar el empleados actual
        public static int idE = 0;
        public static string datosE = "";
        //Variables para guardar el poducto actual
        public static int idP = 0;
        public static string datosP = "";
        public static decimal precioP = 0;
        public static int cantidadP=0;

        public Ventas()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        
        {    
            idC = 0;
            datosC = "";
            fClientesBuscar aux = new fClientesBuscar();
            aux.ShowDialog();
            if (idC>0)
            {
                tbxCliente.Text = datosC;
            }
            else
            {
                idC = 0;
                datosC = "";
                tbxCliente.Clear();
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            GenerarDocumento();            
        }

        void GenerarDocumento() {
            cboDocumento.Items.Add("Boleta");
            cboDocumento.Items.Add("Factura");
            cboDocumento.SelectedIndex = 0;
            var taV = new dsGeneralTableAdapters.taVentas();
            tbxSerie.Text = taV.GenerarSerie(cboDocumento.SelectedItem.ToString()).ToString();
            tbxNro.Text = taV.GenerarNro(cboDocumento.SelectedItem.ToString()).ToString();

        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            idE = 0;
            datosE = "";
            fEmpleadosBuscar aux = new fEmpleadosBuscar();
            aux.ShowDialog();
            if (idE > 0)
            {
                tbxEmpleado.Text = datosE;
            }
            else
            {
                idE = 0;
                datosE = "";
                tbxEmpleado.Clear();
            }
        }

        decimal Importe() { 
        return cantidadP*precioP;
        }

        void ObtenerCantidad() {
            string cant = Microsoft.VisualBasic.Interaction.InputBox("Cantidad: ");
            cantidadP = Convert.ToInt32(cant);
            
        }

        //void Subtotal
        public static decimal precio;
        public static decimal total = 0;
        void ActualizarTotales() {
            
            try
            {
                var subtotal = Convert.ToDouble(dgvProducto.CurrentRow.Cells[4].Value);
                var igv = ((cboDocumento.SelectedItem.ToString() == "Factura") ? subtotal * 0.19 : 0);
                var total = subtotal + igv;
                lblSubTotal.Text = "S/. " + subtotal.ToString();
                lblIGV.Text = "S/. " + igv.ToString("00.00");
                lblTotal.Text = "S/. " + total.ToString("00.00"); 
            }
            catch (Exception)
            {

                MessageBox.Show("Asegurese de que los datos sean correctos");
            }
        }

        int c = 0;
        decimal imp=0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            idP = 0;
            datosP = "";
            precioP = 0;
            cantidadP = 0;
            fProductosBuscar aux = new fProductosBuscar();
            aux.ShowDialog();
            bool nuevo = false;
                if (idP > 0)
                {
                    //ObtenerCantidad();
                    foreach (DataGridViewRow row in dgvProducto.Rows)
                    {
                            if (Convert.ToInt32(row.Cells[0].Value).Equals(idP))
                            {
                                var canX = Convert.ToInt16(row.Cells[1].Value);
                                var impX = Convert.ToDecimal(row.Cells[4].Value);
                                cantidadP += canX;
                                total -= impX;
                                imp = cantidadP *Convert.ToDecimal(precioP);
                                total += imp;
                                ActualizarTotales();
                                row.Cells[1].Value = cantidadP;
                                row.Cells[4].Value = imp;
                                nuevo = true;
                            }  
                    }
                    if (nuevo == false)
                    {
                        dgvProducto.Rows.Add(idP.ToString(), cantidadP.ToString(), datosP, precioP, Importe());
                        ActualizarTotales();
                    }
                }
                else
                {
                    idP = 0;
                    datosP = "";
                    precioP = 0;
                    cantidadP = 0;
                }
            }

        void Limpiar() {
            lblTotal.Text = "Total: S/.0.0";
            lblIGV.Text = "IGV: S/.0.0";
            lblSubTotal.Text = "Subtotal: S/.0.0";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
                dgvProducto.Rows.RemoveAt(dgvProducto.CurrentRow.Index);
                Limpiar();
        }

        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void cboDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count>0)
            {
                GenerarDocumento();
            ActualizarTotales();   
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.Rows.Count>0 && idC>0 && idE>0)
            {
                var taV = new dsGeneralTableAdapters.taVentas();
                var doc=cboDocumento.SelectedItem.ToString();
                var subtotal=doc=="Boleta" ? total :total/1.19m;
                taV.Agregar(idC, idE, doc, tbxSerie.Text, tbxNro.Text, subtotal, 0, total);
                var maxid = Convert.ToInt32(taV.MaxIdVenta());
                var taDV = new dsGeneralTableAdapters.taDetalles();
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {taDV.Agregar(maxid,Convert.ToInt32(row.Cells[0].Value),Convert.ToInt32(row.Cells[1].Value),Convert.ToDecimal(row.Cells[3].Value));
                
                }
                MessageBox.Show("Venta realizada");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}