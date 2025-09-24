using OfficeOpenXml;
using Practica2Nomina.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Practica2Nomina.FormTarifas;

namespace Practica2Nomina
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        List<string> columnas;
       
        

        public Form1()
        {
            InitializeComponent();
            columnas = new List<string>()
    {
        "EE",
        "Nombre",
        "Apellido",
        "Rg. Hrs",
        "OT. Hrs.",
        "D Hrs.",
        "$ Rg. Hrs",
        "$ OT. Hrs.",
        "$ D Hrs.",
        "Total"
    };

        }

        private void tarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivo = openFileDialog1.FileName;
                //MessageBox.Show("Archivo seleccionado: " + archivo);
                CargarExcel(archivo);

            }

        }
        private string[] SepararNombre(string nombreCompleto)
        {
            string[] partes = nombreCompleto.Split(',');
            if (partes.Length >= 2)
            {
                string apellido = partes[0].Trim();
                string nombre = partes[1].Trim();
                partes[0] = apellido;
                partes[1] = nombre;
            }
            return partes;
        }



        private void CargarExcel(string path)
        {
            DataTable dt = new DataTable();

            ExcelPackage.License.SetNonCommercialPersonal("Carlos");
            using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                    return;
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                foreach (var col in columnas)
                {
                    if (!dt.Columns.Contains(col))
                        dt.Columns.Add(col);
                }

                int rowCount = worksheet.Dimension.End.Row;

                for (int i = 3; i <= rowCount; i++)
                {
                    if (string.IsNullOrWhiteSpace(worksheet.Cells[i, 1].Text))
                        break;

                    DataRow row = dt.NewRow();

                    for (int j = 1; j <= columnas.Count; j++)
                    {
                        string valor = worksheet.Cells[i, j].Text;

                        if (j == 2) // Columna NombreCompleto
                        {
                            string[] partes = SepararNombre(valor);
                            row[1] = partes[1]; // Nombre
                            row[2] = partes[0]; // Apellido
                        }
                        else
                        {
                            row[j - 1] = valor;
                        }
                    }

                    dt.Rows.Add(row);
                }
            }

            //  Limpiar DataGridView
            dataGridView1.Rows.Clear();


            //Llenar el DataGridView con datos + cálculos
            foreach (DataRow dr in dt.Rows)
            {
                int index = dataGridView1.Rows.Add();

                //Datos basicos (ajusta el orden según tu grid)
                dataGridView1.Rows[index].Cells[0].Value = dr["EE"];
                dataGridView1.Rows[index].Cells[1].Value = dr["Nombre"];
                dataGridView1.Rows[index].Cells[2].Value = dr["Apellido"];
                dataGridView1.Rows[index].Cells[3].Value = dr["Rg. Hrs"];
                dataGridView1.Rows[index].Cells[4].Value = dr["OT. Hrs."];
                dataGridView1.Rows[index].Cells[5].Value = dr["D Hrs."];

                //Calculos
                decimal rg = decimal.TryParse(dr["Rg. Hrs"].ToString(), out rg) ? rg : 0;
                decimal ot = decimal.TryParse(dr["OT. Hrs."].ToString(), out ot) ? ot : 0;
                decimal dh = decimal.TryParse(dr["D Hrs."].ToString(), out dh) ? dh : 0;

                Tarifas tarifas = TarifasHelper.Cargar();

                decimal pagoRg = rg * tarifas.HoraRegular;
                decimal pagoOt = ot * tarifas.HoraExtra;
                decimal pagoDh = dh * tarifas.HoraDia;
                decimal total = pagoRg + pagoOt + pagoDh;

                dataGridView1.Rows[index].Cells[6].Value = pagoRg;
                dataGridView1.Rows[index].Cells[7].Value = pagoOt;
                dataGridView1.Rows[index].Cells[8].Value = pagoDh;
                dataGridView1.Rows[index].Cells[9].Value = total;
            }
        }




        private void asignarTarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarifas formTarifas = new FormTarifas();
            formTarifas.ShowDialog();
        }
    }
}