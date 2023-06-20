using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaAPI.Models.Dto;

namespace frmZapateria
{
    public partial class Ventas : Form
    {
        List<SalesDto> sales;
        public Ventas()
        {
            InitializeComponent();
            CargarVentas();
        }

        private async Task CargarVentas()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://localhost:9000/api/Sales");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        sales = JsonConvert.DeserializeObject<List<SalesDto>>(json);

                        dgvVentas.DataSource = sales;
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener las ventas de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las ventas de la API: {ex.Message}");
            }
        }
    }
}
