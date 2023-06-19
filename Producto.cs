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
        //Agrega multiples datos

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

            // Limpiar el mensaje de error del campo de precio
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

        //Solo envia los que estan en los controladores
        //private async void EnviarProducto(ProductsCreateDto product)
        //{
        //    try
        //    {
        //        // Serializar el objeto product a JSON
        //        var serializedProduct = JsonConvert.SerializeObject(product);

        //        // Crear el contenido de la solicitud HTTP
        //        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");

        //        // Realizar la solicitud HTTP POST a la API
        //        using (var client = new HttpClient())
        //        {
        //            var response = await client.PostAsync("https://localhost:9000/api/ZapateriaControllers/Products", content);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                // Producto agregado exitosamente
        //                MessageBox.Show("Producto agregado correctamente");
        //            }
        //            else    //Aqqui entra en la excecion pero aun asi guarda los datos en la base de datos, creo que entra en excepcion por culpa del metodo post.
        //            {
        //                // Error al agregar el producto
        //                //var statusCode = (int)response.StatusCode;
        //                //var reasonPhrase = response.ReasonPhrase;
        //                //var errorMessage = await response.Content.ReadAsStringAsync();
        //                //MessageBox.Show($"Error al agregar el producto. Código de estado: {statusCode}, Razón: {reasonPhrase}, Mensaje: {errorMessage}");
        //                MessageBox.Show("Producto agregado");
        //            }
        //        }

        //        //LimpiarControladores();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al agregar el producto: {ex.Message}");
        //    }


        //}


        //private async void ComprobarDatos()
        //{
        //    // Verificar si hay filas en el DataGridView
        //    if (dgvProductos.Rows.Count == 0)
        //    {
        //        MessageBox.Show("No hay productos para enviar.");
        //        return;
        //    }

        //    // Crear una lista de ProductsCreateDto para almacenar los productos
        //    List<ProductsCreateDto> productsList = new List<ProductsCreateDto>();

        //    // Recorrer todas las filas del DataGridView y convertir los datos en ProductsCreateDto
        //    foreach (DataGridViewRow row in dgvProductos.Rows)
        //    {
        //        // Comprobar si la fila es una nueva fila o está vacía
        //        if (!row.IsNewRow && row.Cells["Marca"].Value != null && row.Cells["Modelo"].Value != null &&
        //            row.Cells["Tipo"].Value != null && row.Cells["Color"].Value != null && row.Cells["Talla"].Value != null &&
        //            row.Cells["Precio"].Value != null && row.Cells["Ubicacion"].Value != null)
        //        {
        //            // Crear un objeto ProductsCreateDto y asignar los valores de las celdas correspondientes
        //            ProductsCreateDto product = new ProductsCreateDto
        //            {
        //                productMarca = row.Cells["Marca"].Value?.ToString(),
        //                productModelo = row.Cells["Modelo"].Value?.ToString(),
        //                productTipo = row.Cells["Tipo"].Value?.ToString(),
        //                productColor = row.Cells["Color"].Value?.ToString(),
        //                productTalla = Convert.ToDouble(row.Cells["Talla"].Value),
        //                productPrecio = Convert.ToDouble(row.Cells["Precio"].Value),
        //                productUbicacion = row.Cells["Ubicacion"].Value?.ToString()
        //            };

        //            // Agregar el producto a la lista
        //            productsList.Add(product);
        //        }
        //    }

        //    // Resto del código...
        //}


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
                    {}

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

            // Crear una lista de ProductsCreateDto a partir de las filas filtradas
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

            // Enviar los productos a través del método EnviarProducto
            foreach (var product in productsList)
            {
                await EnviarProducto(product);
            }

            LimpiarControladores();

            // Verificar si hay filas en el DataGridView

            //ProductsCreateDto product = new ProductsCreateDto();
            //product.productMarca = cboMarca.Text;
            //product.productModelo = txtModelo.Text;
            //product.productTipo = cboTipo.Text;
            //product.productColor = cboColor.Text;
            //product.productTalla = double.Parse(cboTalla.Text);
            //product.productPrecio = double.Parse(txtPrecio.Text);
            //product.productUbicacion = cboUbi.Text;

            //EnviarProducto(product);

        }     
    
    
     }
}






//ComprobarDatos();


//string apiUrl = "https://localhost:9000/api/ZapateriaControllers/";     Esto va en el boton enviar
//string marca = "Nike"; // Reemplaza con la marca deseada

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        HttpResponseMessage response = await client.GetAsync(apiUrl + marca);
//        if (response.IsSuccessStatusCode)
//        {
//            string responseData = await response.Content.ReadAsStringAsync();
//            // Aquí puedes procesar los datos de la respuesta, como deserializar el JSON, etc.
//            MessageBox.Show(responseData);
//        }
//        else
//        {
//            MessageBox.Show($"Error en la solicitud: {response.StatusCode}");
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
//    }
//}


//Esto es de btnEnviar
/*if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para enviar.");
                return;
            }

            // Crear una lista de ProductsCreateDto para almacenar los productos
            List<ProductsCreateDto> productsList = new List<ProductsCreateDto>();

            // Recorrer todas las filas del DataGridView y convertir los datos en ProductsCreateDto
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                // Comprobar si la fila es una nueva fila o está vacía
                if (!row.IsNewRow && row.Cells["Marca"].Value != null && row.Cells["Modelo"].Value != null &&
                    row.Cells["Tipo"].Value != null && row.Cells["Color"].Value != null && row.Cells["Talla"].Value != null &&
                    row.Cells["Precio"].Value != null && row.Cells["Ubicacion"].Value != null)
                {
                    // Crear un objeto ProductsCreateDto y asignar los valores de las celdas correspondientes
                    ProductsCreateDto product = new ProductsCreateDto
                    {
                        productMarca = row.Cells["Marca"].Value?.ToString(),
                        productModelo = row.Cells["Modelo"].Value?.ToString(),
                        productTipo = row.Cells["Tipo"].Value?.ToString(),
                        productColor = row.Cells["Color"].Value?.ToString(),
                        productTalla = Convert.ToDouble(row.Cells["Talla"].Value),
                        productPrecio = Convert.ToDouble(row.Cells["Precio"].Value),
                        productUbicacion = row.Cells["Ubicacion"].Value?.ToString()
                    };

                    // Agregar el producto a la lista
                    productsList.Add(product);

                    await EnviarProducto(product);
                }
*/