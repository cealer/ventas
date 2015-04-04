using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    class CClientes
    {
        private string nombres, apellidos, dni, direccion, telefono;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public CClientes() { }

        public CClientes(string nom,string ape,string dni,string dire,string tele) {
            this.nombres = nom;
            this.apellidos = ape;
            this.dni = dni;
            this.direccion = dire;
            this.telefono = tele;
        }

        public CClientes(int id,string nom, string ape, string dni, string dire, string tele)
        {
            this.id = id;
            this.nombres = nom;
            this.apellidos = ape;
            this.dni = dni;
            this.direccion = dire;
            this.telefono = tele;
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

    }
}
