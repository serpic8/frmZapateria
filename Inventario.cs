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
        private int selectedProductId;
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


        }


        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvInventario.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(selectedRow.Cells["productId"].Value);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
                return;
            }


            ProductsUpdateDto product = new ProductsUpdateDto
            {
                productMarca = cboMarca.Text,
                productModelo = txtModelo.Text,
                productTipo = cboTipo.Text,
                productColor = cboColor.Text,
                productTalla = double.Parse(cboTalla.Text),
                productPrecio = double.Parse(txtPrecio.Text),
                productUbicacion = cboUbi.Text
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:9000/");

                    var jsonProduct = JsonConvert.SerializeObject(product);
                    var content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync($"api/ZapateriaControllers/{selectedProductId}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la API: " + ex.Message);
            }
        }

        private async void dgvInventario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }


        private void RealizarBusqueda()
        {
            dgvInventario.CurrentCell = null;

            if (txtBuscar.Text != "")
            {
                foreach (DataGridViewRow r in dgvInventario.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dgvInventario.Rows)
                {
                    bool found = false;

                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.Value != null && c.Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        r.Visible = true;
                        continue;
                    }


                    if (r.Cells["productMarca"].Value != null && r.Cells["productMarca"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        r.Visible = true;
                        continue;
                    }

                    if (r.Cells["productTipo"].Value != null && r.Cells["productTipo"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        r.Visible = true;
                        continue;
                    }

                    if (r.Cells["productColor"].Value != null && r.Cells["productColor"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        r.Visible = true;
                        continue;
                    }

                    if (r.Cells["productPrecio"].Value != null && r.Cells["productPrecio"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        r.Visible = true;
                        continue;
                    }

                    if (r.Cells["productId"].Value != null && r.Cells["productId"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        r.Visible = true;
                        continue;
                    }

                    if (r.Cells["productTalla"].Value != null && r.Cells["productTalla"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        r.Visible = true;
                        continue;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow r in dgvInventario.Rows)
                {
                    r.Visible = true;
                }
            }
        }

    }
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