﻿using System;
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
    public partial class Clientes : Form
    {
        Operaciones operacion = new Operaciones();
        
        public Clientes()
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
            if (btnAgregar.Text.Equals("Agregar"))
            {
                try
                {
                    string nom, ape, dni, direccion, telefono;
                    nom = tbxNombresDatos.Text.Trim();
                    ape = tbxApellidosDatos.Text.Trim();
                    dni = mtbDNI.Text.Trim();
                    direccion = tbxDireccionDatos.Text.Trim();
                    telefono = mtbTelefonoDatos.Text.Trim();
                    CClientes aux = new CClientes(nom, ape, dni, direccion, telefono);
                    if (nom.Length > 0 && ape.Length > 0)
                    {
                        operacion.AgregarClientes(aux);
                        LimpiarDatos();
                        MessageBox.Show("Guardado");
                    }
                    else
                    {
                        MessageBox.Show("Los campos Nombres y Apellidos son obligatorio.");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "No se pudo realizar el guardado");
                }    
            }
         
            if (btnAgregar.Text.Equals("Modificar"))
            {
                try
                {
                    string nom, ape, dni, dir, tel;
                    int id = (int)dgvLista.CurrentRow.Cells[0].Value;
                    nom = tbxNombresDatos.Text.Trim();
                    ape = tbxApellidosDatos.Text.Trim();
                    dni = mtbDNI.Text.Trim();
                    dir = tbxDireccionDatos.Text.Trim();
                    tel = mtbTelefonoDatos.Text.Trim();
                    CClientes aux = new CClientes(id, nom, ape, dni, dir, tel);
                    operacion.ModificarCliente(aux);
                    LimpiarDatos();
                    MessageBox.Show("Modificado");
                    tabControl1.SelectedIndex = 0;
                    btnBuscar.PerformClick();
                    btnAgregar.Text="Agregar";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "Error al modificar.");
                }  
            }


            
        }

        void LimpiarLista() {
            tbxNombresLista.Focus();
            tbxApellidosLista.Clear();
            tbxNombresLista.Clear();
        }

        void LimpiarDatos()
        {
            tbxNombresDatos.Focus();
            tbxApellidosDatos.Clear();
            tbxNombresDatos.Clear();
            tbxDireccionDatos.Clear();
            mtbDNI.Clear();
            mtbTelefonoDatos.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvLista.CurrentRow.Cells[0].Value;
                operacion.ElminarCliente(id);
                btnBuscar.PerformClick();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString(),"Error al eliminar");
            }

        }
        
        private void tsmmodificar_Click(object sender, EventArgs e)
        {       
            tbxNombresDatos.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            tbxApellidosDatos.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();
            mtbDNI.Text = dgvLista.CurrentRow.Cells[3].Value.ToString();
            tbxDireccionDatos.Text = dgvLista.CurrentRow.Cells[4].Value.ToString();
            mtbTelefonoDatos.Text = dgvLista.CurrentRow.Cells[5].Value.ToString();
            btnAgregar.Text = "Modificar";
            tabControl1.SelectedIndex=1;    
            
        }
    }
}
