using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    class CClientes
    {
        public int Id{ get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
        public CClientes() { }

        public CClientes(string nom,string ape,string dni,string dire,string tele) {
            this.Nombres = nom;
            this.Apellidos = ape;
            this.Dni = dni;
            this.Direccion = dire;
            this.Telefono = tele;
        }

        public CClientes(int id,string nom, string ape, string dni, string dire, string tele)
        {
            this.Id = id;
            this.Nombres = nom;
            this.Apellidos = ape;
            this.Dni = dni;
            this.Direccion = dire;
            this.Telefono = tele;
        }
    }
}
