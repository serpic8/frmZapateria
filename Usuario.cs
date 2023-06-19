﻿using Newtonsoft.Json;
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
    public partial class Usuario : Form
    {
        List<ProductsDto> products;

        public Usuario()
        {
            InitializeComponent();
        }

        private async void Usuario_Load(object sender, EventArgs e)
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

                        dgvProductos.DataSource = products;
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

        private void RealizarBusqueda()
        {
            dgvProductos.CurrentCell = null;

            if (txtBuscar.Text != "")
            {
                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dgvProductos.Rows)
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
                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    r.Visible = true;
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dgvProductos.Columns.Count)
            {

                DialogResult result = MessageBox.Show("¿Desea agregar al carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = dgvProductos.Rows[e.RowIndex];


                    dgvCarrito.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (dgvCarrito.Rows.Count == 0)
            {
                erpError.SetError(btnCancelar, "No hay datos en el carrito para borrar.");
                return;
            }


            DialogResult result = MessageBox.Show("¿Está seguro de borrar los datos del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvCarrito.Rows.Clear();
            }
        }


    }
}
