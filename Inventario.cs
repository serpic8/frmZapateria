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
    public partial class Inventario : Form
    {
        List<ProductsDto> products;
        public Inventario()
        {
            InitializeComponent();
        }

        private async void Inventario_Load(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        private async Task CargarProductos()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://localhost:9000/api/ZapateriaControllers");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        products = JsonConvert.DeserializeObject<List<ProductsDto>>(json);

                        dgvInventario.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los productos de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los productos de la API: {ex.Message}");
            }
        }

        private async void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["productId"].Value);
                await EliminarProducto(productId, dgvInventario);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar el producto.");
            }
        }

        private async Task EliminarProducto(int productId, DataGridView dgvInventario)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"https://localhost:9000/api/ZapateriaControllers/{productId}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");

                        // Eliminar la fila correspondiente en el origen de datos
                        var product = products.FirstOrDefault(p => p.productId == productId);
                        if (product != null)
                        {
                            products.Remove(product);
                        }

                        // Volver a enlazar los datos al DataGridView
                        dgvInventario.DataSource = null;
                        dgvInventario.DataSource = products;

                        // Aquí puedes realizar cualquier acción adicional después de eliminar el producto
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }


            //try
            //{
            //    if (dgvInventario.SelectedRows.Count > 0)
            //    {
            //        productId = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["productId"].Value);

            //        using (var client = new HttpClient())
            //        {
            //            var response = await client.DeleteAsync($"https://localhost:9000/api/ZapateriaControllers/{productId}");

            //            if (response.IsSuccessStatusCode)
            //            {
            //                MessageBox.Show("Producto eliminado correctamente.");

            //                // Eliminar la fila seleccionada en el DataGridView
            //                dgvInventario.Rows.Remove(dgvInventario.SelectedRows[0]);

            //                // Aquí puedes realizar cualquier acción adicional después de eliminar el producto
            //            }
            //            else
            //            {
            //                MessageBox.Show("Error al eliminar el producto.");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Seleccione una fila para eliminar el producto.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            //}
        }

    }

}
