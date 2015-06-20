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
    public partial class Empleados : Form
    {
        dsGeneral ds = new dsGeneral();
        dsGeneralTableAdapters.taEmpleadoo dte = new dsGeneralTableAdapters.taEmpleadoo();

        public Empleados()
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
            if (btnAgregar.Text.Equals("Agregar"))
            {
                try
                {
                    string nom, ape, dni, direc, tel;
                    nom = tbxNombresDatos.Text;
                    ape = tbxApellidosDatos.Text;
                    dni = tbxDNI.Text;
                    direc = mtbDNI.Text;
                    tel = mtbTelefonoDatos.Text;
                    int i = dte.Agregar(nom, ape, dni, direc, tel);

                    if (i > 0)
                    {
                        MessageBox.Show("Agregado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }   
            }
            else
            {
                try
                {
                    var nf = dgvLista.Rows.Count;
                    string nom, ape, dni, dire, tel;
                    nom = tbxNombresDatos.Text;
                    ape = tbxApellidosDatos.Text;
                    dni = mtbDNI.Text;
                    dire = tbxDireccionDatos.Text;
                    tel = mtbTelefonoDatos.Text;
                    if (nf > 0)
                    {
                        int id = Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value);
                        int r = dte.Modificar(nom, ape, dire, tel, id);
                        if (r > 0)
                        {
                            MessageBox.Show("Modificado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
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
            try
            {
                var nf=dgvLista.Rows.Count;
                if (nf>0)
                {
                    int id =Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value);
                    int r=  dte.Eliminar(id);
                    if (r > 0)
                    {
                        btnBuscar.PerformClick();
                        MessageBox.Show("Eliminado");
                    }        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
