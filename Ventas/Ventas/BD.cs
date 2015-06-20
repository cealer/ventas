using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ventas
{
    class BD
    {
        public  SqlConnection con = new SqlConnection("Data Source=CEALER-LAPTOP;Initial Catalog=dbVentas;Integrated Security=True");

        public void Abrir() {
            con.Open();
        }

        public void Cerrar() {
            con.Close();
        }

    }
}
