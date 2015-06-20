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
    public partial class BuscarClientes : Form
    {

        //Listar todo
        dsGeneral2 ds = new dsGeneral2();
        //Usar los procedimientos creados(inserta,elimnar,etc)
        dsGeneral2TableAdapters.ClienteTableAdapter tcliente = new dsGeneral2TableAdapters.ClienteTableAdapter();
        Operaciones operacion = new Operaciones();

        public BuscarClientes()
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
                tcliente.listar(ds.Cliente, nom, ape);

                foreach (DataRow fila in ds.Cliente.Rows)
                {
                    dgvLista.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString(), fila[5].ToString());
                }

                LimpiarLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error ");
            }
        }

        void LimpiarLista()
        {
            tbxNombresLista.Focus();
            tbxApellidosLista.Clear();
            tbxNombresLista.Clear();
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {

        }
    }

}