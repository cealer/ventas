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
    public partial class Registros : Form
    {   public Registros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nom, ape, dni;
            DateTime fecnac;
            nom = tbxNombres.Text;
            ape = tbxApellidos.Text;
            dni = mtbxDNI.Text;
            fecnac = dtpFecNac.Value;
            //ta.Insertar(nom, ape, fecnac, dni);
            var id=Convert.ToInt32 (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //ta.Modificar(nom, ape, fecnac,dni,id);
            //ta.Listar(ds.Persona, dni);
        }
    }
}
