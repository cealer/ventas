using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ventas
{
    class Operaciones:BD
    {
    /*public void ListarClientes(DataGridView datagridview) {
            Abrir();
            string query="select * from Cliente";
            SqlCommand cmd = new SqlCommand(query,con);
            var lista= cmd.ExecuteReader();
            while (lista.Read())
            {
                datagridview.Rows.Add(lista.GetString(1), lista.GetString(2), lista.GetString(3), lista.GetString(4),lista.GetString(5));
            }
            Cerrar();
        }
        */
       
        public List<CClientes> BuscarClientes(string nom,string ape)
        {
            List<CClientes> listaClientes = new List<CClientes>();
            string query = "select * from Cliente where Nombres like @nom + '%' and Apellidos like @ape + '%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("nom",nom);
            cmd.Parameters.AddWithValue("ape",ape);
            Abrir();
            var lista = cmd.ExecuteReader();
            while (lista.Read())
            {
                listaClientes.Add(new CClientes(lista.GetInt32(0),lista.GetString(1), lista.GetString(2), lista.GetString(3), lista.GetString(4), lista.GetString(5)));
            }
            Cerrar();
            return listaClientes;
        }

        public void AgregarClientes(CClientes aux) {
            string query = "insert into Cliente values (@nom,@ape,@dni,@direccion,@telefono)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("nom",aux.Nombres);
            cmd.Parameters.AddWithValue("ape",aux.Apellidos);
            cmd.Parameters.AddWithValue("dni",aux.Dni);
            cmd.Parameters.AddWithValue("direccion",aux.Direccion);
            cmd.Parameters.AddWithValue("telefono",aux.Telefono);
            Abrir();
            int rpt= cmd.ExecuteNonQuery();
            Cerrar();
        }

        public void ElminarCliente(int id) {            
                string query = "Delete from Cliente where IdCliente=@id ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("id", id);
                Abrir();
                cmd.ExecuteNonQuery();
                Cerrar();     
        }

        public void ModificarCliente(CClientes aux) {

            string query = "update Cliente set Nombres=@nom, Apellidos=@ape, DNI=@dni, Direccion=@dir, Telefono=@tel  where IdCliente= @id";
            var cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("id",aux.Id);
            cmd.Parameters.AddWithValue("nom",aux.Nombres);
            cmd.Parameters.AddWithValue("ape",aux.Apellidos);
            cmd.Parameters.AddWithValue("dni",aux.Dni);
            cmd.Parameters.AddWithValue("dir",aux.Direccion);
            cmd.Parameters.AddWithValue("tel",aux.Telefono);
            Abrir();
            cmd.ExecuteNonQuery();
            Cerrar(); 
        }
    
    }
}
