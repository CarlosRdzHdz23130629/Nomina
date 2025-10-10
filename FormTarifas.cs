using Newtonsoft.Json;
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

namespace Practica2Nomina
{
    public partial class FormTarifas : Form
    {
        public FormTarifas()
        {
            InitializeComponent();
            
        }
        private void FormTarifas_Load(object sender, EventArgs e)
        {
            // Mostrar valores actuales en los controles
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraRegular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtHoraRegular.Text) ||
                    string.IsNullOrWhiteSpace(txtHoraExtra.Text) ||
                    string.IsNullOrWhiteSpace(txtHoraDia.Text))
                {
                    MessageBox.Show("Debes ingresar todas las tarifas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Intentar convertir a decimal
                decimal regular, extra, doble;
                if (!decimal.TryParse(txtHoraRegular.Text, out regular) ||
                    !decimal.TryParse(txtHoraExtra.Text, out extra) ||
                    !decimal.TryParse(txtHoraDia.Text, out doble))
                {
                    MessageBox.Show("Las tarifas deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear objeto tarifas
                Tarifas tarifas = new Tarifas()
                {
                    HoraRegular = regular,
                    HoraExtra = extra,
                    HoraDia= doble
                };

                // Guardar en JSON
                TarifasHelper.Guardar(tarifas);

                MessageBox.Show("Tarifas guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Captura cualquier error inesperado
                MessageBox.Show($"Ocurrió un error al guardar las tarifas.\n\nDetalles: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class TarifasHelper
        {
            private static string rutaArchivo = "tarifas.json";

            public static void Guardar(Tarifas tarifas)
            {
                string json = JsonConvert.SerializeObject(tarifas, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json);
            }

            public static Tarifas Cargar()
            {
                if (!File.Exists(rutaArchivo))
                    return new Tarifas(); // por si no existe, devolver vacío

                string json = File.ReadAllText(rutaArchivo);
                return JsonConvert.DeserializeObject<Tarifas>(json);
            }
        }
    }
}

