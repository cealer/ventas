using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Ventas
{
    public partial class BuscarVentas : Form
    {
        BD basedatos = new BD();
        public BuscarVentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLista.Rows.Clear();
                var cn = basedatos.con;
                var sql = "SELECT v.IdVentas,c.DNI+'-'+c.Nombres+', '+c.Apellidos,e.DNI +e.Nombre+','+e.Apellidos,v.Documento,v.Serie,v.Nro,v.Subtotal,v.IGV,v.Total FROM Ventas v inner join EmpleadoO e on v.IdCliente=e.IdEmpleado inner join Cliente c on v.IdCliente=c.IdCliente where v.Fecha >=@fi and v.Fecha<=@ff";
                var fi = dtpDesde.Value;
                var ff = dtpHasta.Value;
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@fi", fi);
                cmd.Parameters.AddWithValue("@ff", ff);
                basedatos.Abrir();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgvLista.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetDecimal(6).ToString(), dr.GetDecimal(7).ToString(), dr.GetDecimal(8).ToString());
                }
                basedatos.Cerrar();
            }
            catch (Exception hn)
            {
                MessageBox.Show(hn.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var ds = new FileStream("reporteventa.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            var doc = new Document(PageSize.A4);
            var escribir = PdfWriter.GetInstance(doc, ds);
            doc.AddAuthor("Team Programadores CS");
            doc.AddTitle("Reporte de ventas");
            doc.AddCreator("HN 2015");
            doc.Open();
            var Fila = new Paragraph("Reporte de Venta");
            Fila.Alignment = Element.ALIGN_CENTER;
            doc.Add(Fila);
            var fi = dtpDesde.Value.ToShortDateString();
            var ff = dtpDesde.Value.ToShortDateString();
            Fila = new Paragraph("Desde: " + fi + " Hasta: " + ff);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Fila);
            //
            var table = new PdfPTable(7);
            table.SetWidthPercentage(new float[] { 20, 110, 110, 150, 60, 60, 60 }, PageSize.A4);
            var texto = new[] { "Id", "Cliente", "Empleado", "Documento-Serie-Nro", "SubTotal", "IGV", "Total" };
            var celda = new PdfPCell();
            foreach (var item in texto)
            {
                celda = new PdfPCell(new Phrase(item));
                celda.BorderWidth = 0;
                celda.BorderWidthBottom = 0.5f;
                table.AddCell(celda);
            }
            //Crear las celdas de registros
            foreach (DataGridViewRow fila in dgvLista.Rows)
            {
                celda = new PdfPCell(new Phrase(fila.Cells[0].Value.ToString()));
                celda.BorderWidth = 0;celda.BorderWidthBottom = 0.5f;table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[1].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[2].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[3].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[4].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[5].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[6].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[7].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
                celda = new PdfPCell(new Phrase(fila.Cells[8].Value.ToString()));
                celda.BorderWidth = 0; celda.BorderWidthBottom = 0.5f; table.AddCell(celda);
            
            }
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(table);
            doc.Close();
            escribir.Close();
            var ruta = Path.Combine(Application.StartupPath, "reporteventa.pdf");
            Process.Start(ruta);
        }
    }
}