using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2._2C2025
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
            btnIngresarLocal.Click += btnIngresarLocal_Click;
            btnCancelarIngreso.Click += btnCancelarIngreso_Click;
        }

        private async void btnIngresarLocal_Click(object sender, EventArgs e)
        {
            string nombreTipoLocal = txtNuevoLocal.Text.Trim();
            if (string.IsNullOrEmpty(nombreTipoLocal))
            {
                MessageBox.Show("Ingrese un nombre para el tipo de local.");
                return;
            }

            var tipoLocal = new
            {
                Id = 0, // El Id lo asigna el backend
                Nombre = nombreTipoLocal
            };

            using var client = new HttpClient();
            var json = JsonSerializer.Serialize(tipoLocal);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7211/api/TipoLocal", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Tipo de local ingresado correctamente.");
                txtNuevoLocal.Clear();
            }
            else
            {
                MessageBox.Show("Error al ingresar el tipo de local.");
            }
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
