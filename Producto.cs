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
    public partial class Producto : Form
    {
       

        public Producto()
        {
            InitializeComponent();
        }



        private void AgregarProducto(ProductsCreateDto product)
        {

            dgvProductos.Columns.Add("Marca", "Marca");
            dgvProductos.Columns.Add("Modelo", "Modelo");
            dgvProductos.Columns.Add("Tipo", "Tipo");
            dgvProductos.Columns.Add("Color", "Color");
            dgvProductos.Columns.Add("Talla", "Talla");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Ubicacion", "Ubicacion");

            int rowIndex = dgvProductos.Rows.Add();


            DataGridViewRow newRow = dgvProductos.Rows[rowIndex];


            newRow.Cells["Marca"].Value = product.productMarca;
            newRow.Cells["Modelo"].Value = product.productModelo;
            newRow.Cells["Tipo"].Value = product.productTipo;
            newRow.Cells["Color"].Value = product.productColor;
            newRow.Cells["Talla"].Value = product.productTalla;
            newRow.Cells["Precio"].Value = product.productPrecio;
            newRow.Cells["Ubicacion"].Value = product.productUbicacion;
        }

        private void LimpiarControladores()
        {
            cboMarca.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboTalla.SelectedIndex = -1;
            cboColor.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            cboUbi.SelectedIndex = -1;
            txtModelo.Text = "";
            txtPrecio.Text = "";

        }

        private void Limpiar_dgv(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(cboTipo.Text) ||
                string.IsNullOrWhiteSpace(cboColor.Text) ||
                string.IsNullOrWhiteSpace(cboTalla.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(cboUbi.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos correspondientes.");
                return;
            }


            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                erpValidaciones.SetError(txtPrecio, "El precio debe ser numerico");
                return;
            }

            
            erpValidaciones.SetError(txtPrecio, "");


            ProductsCreateDto product = new ProductsCreateDto();
            product.productMarca = cboMarca.Text;
            product.productModelo = txtModelo.Text;
            product.productTipo = cboTipo.Text;
            product.productColor = cboColor.Text;
            product.productTalla = double.Parse(cboTalla.Text);
            product.productPrecio = double.Parse(txtPrecio.Text);
            product.productUbicacion = cboUbi.Text;



            AgregarProducto(product);

            LimpiarControladores();
        }

       


        private async Task EnviarProducto(ProductsCreateDto product)
        {
            try
            {

                var serializedProduct = JsonConvert.SerializeObject(product);


                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");


                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync("https://localhost:9000/api/ZapateriaControllers/Products", content);

                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Producto agregado correctamente");
                    }
                    else
                    { }

                    MessageBox.Show("Producto agregado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }








        private async void btnEnviar_Click(object sender, EventArgs e)
        {

            var rowsWithData = dgvProductos.Rows.Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow &&
                     row.Cells["Marca"].Value != null &&
                     row.Cells["Modelo"].Value != null &&
                     row.Cells["Tipo"].Value != null &&
                     row.Cells["Color"].Value != null &&
                     row.Cells["Talla"].Value != null &&
                     row.Cells["Precio"].Value != null &&
                     row.Cells["Ubicacion"].Value != null);

            
            List<ProductsCreateDto> productsList = rowsWithData.Select(row => new ProductsCreateDto
            {
                productMarca = row.Cells["Marca"].Value?.ToString(),
                productModelo = row.Cells["Modelo"].Value?.ToString(),
                productTipo = row.Cells["Tipo"].Value?.ToString(),
                productColor = row.Cells["Color"].Value?.ToString(),
                productTalla = Convert.ToDouble(row.Cells["Talla"].Value),
                productPrecio = Convert.ToDouble(row.Cells["Precio"].Value),
                productUbicacion = row.Cells["Ubicacion"].Value?.ToString()
            }).ToList();

            foreach (var product in productsList)
            {
                await EnviarProducto(product);
            }

            LimpiarControladores();
            Limpiar_dgv(dgvProductos);
            
        }


    }
}






