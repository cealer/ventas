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
    public partial class fClientesBuscar : Form
    {
       // dsGeneral2 ds = new dsGeneral2();
      //  dsGeneral2TableAdapters.TACliente tacliente = new dsGeneral2TableAdapters.TACliente();
        Operaciones operacion = new Operaciones();
        
        public fClientesBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            try
            {       
                string nom, ape;
                nom = tbxNombresLista.Text;
                ape = tbxApellidosLista.Text;
                var lista = operacion.BuscarClientes(nom, ape);
                foreach (var item in lista)
                {
                    dgvLista.Rows.Add(item.Id,item.Nombres,item.Apellidos,item.Dni,item.Direccion,item.Telefono);
                }
                LimpiarLista(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error ");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            
        }

        void LimpiarLista() {
            tbxNombresLista.Focus();
            tbxApellidosLista.Clear();
            tbxNombresLista.Clear();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
        
        }
        
        private void tsmmodificar_Click(object sender, EventArgs e)
        {       
            
        }
        
        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLista.RowCount>0)
            {
                int id = (int)dgvLista.CurrentRow.Cells[0].Value;
                string datos = dgvLista.CurrentRow.Cells[1].Value.ToString() + " " + dgvLista.CurrentRow.Cells[2].Value.ToString() + " " + dgvLista.CurrentRow.Cells[3].Value.ToString() + " " + dgvLista.CurrentRow.Cells[4].Value.ToString() + " "  +dgvLista.CurrentRow.Cells[5].Value.ToString();
                
                Ventas.idC = id;
                Ventas.datosC = datos;
                this.Close();
            }
        }
    }
}