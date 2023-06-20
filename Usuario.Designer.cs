namespace frmZapateria
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            btnCerrar = new PictureBox();
            btnRayita = new PictureBox();
            btnMaximizar = new PictureBox();
            BarraTitulo = new Panel();
            lblHora = new Label();
            panel1 = new Panel();
            lblFecha = new Label();
            txtBuscar = new TextBox();
            pictureBox2 = new PictureBox();
            btnMinimizar = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvProductos = new DataGridView();
            dgvCarrito = new DataGridView();
            productId = new DataGridViewTextBoxColumn();
            productMarca = new DataGridViewTextBoxColumn();
            productModelo = new DataGridViewTextBoxColumn();
            productTipo = new DataGridViewTextBoxColumn();
            productColor = new DataGridViewTextBoxColumn();
            productTalla = new DataGridViewTextBoxColumn();
            productGenero = new DataGridViewTextBoxColumn();
            productPrecio = new DataGridViewTextBoxColumn();
            productUbicacion = new DataGridViewTextBoxColumn();
            productsDtoBindingSource = new BindingSource(components);
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            btnComprar = new Button();
            btnCancelar = new Button();
            erpError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDtoBindingSource).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.MediumSeaGreen;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1359, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            // 
            // btnRayita
            // 
            btnRayita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRayita.BackColor = Color.MediumSeaGreen;
            btnRayita.Cursor = Cursors.Hand;
            btnRayita.Image = (Image)resources.GetObject("btnRayita.Image");
            btnRayita.Location = new Point(1275, 0);
            btnRayita.Name = "btnRayita";
            btnRayita.Size = new Size(41, 35);
            btnRayita.SizeMode = PictureBoxSizeMode.Zoom;
            btnRayita.TabIndex = 3;
            btnRayita.TabStop = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.MediumSeaGreen;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1322, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(35, 35);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.MediumSeaGreen;
            BarraTitulo.Controls.Add(lblHora);
            BarraTitulo.Controls.Add(panel1);
            BarraTitulo.Controls.Add(lblFecha);
            BarraTitulo.Controls.Add(txtBuscar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnRayita);
            BarraTitulo.Controls.Add(pictureBox2);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(800, 35);
            BarraTitulo.TabIndex = 1;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Sitka Text", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(648, 8);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(37, 16);
            lblHora.TabIndex = 10;
            lblHora.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(212, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 23);
            panel1.TabIndex = 56;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Sitka Text", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(578, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(37, 16);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "label2";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(252, 6);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(293, 23);
            txtBuscar.TabIndex = 55;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.MediumSeaGreen;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(712, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.MediumSeaGreen;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1322, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(41, 35);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.MediumSeaGreen;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(759, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(82, 35);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(718, 156);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { productId, productMarca, productModelo, productTipo, productColor, productTalla, productGenero, productPrecio, productUbicacion });
            dgvCarrito.Location = new Point(82, 256);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(718, 150);
            dgvCarrito.TabIndex = 6;
            // 
            // productId
            // 
            productId.HeaderText = "productId";
            productId.Name = "productId";
            productId.ReadOnly = true;
            // 
            // productMarca
            // 
            productMarca.HeaderText = "productMarca";
            productMarca.Name = "productMarca";
            productMarca.ReadOnly = true;
            // 
            // productModelo
            // 
            productModelo.HeaderText = "productModelo";
            productModelo.Name = "productModelo";
            productModelo.ReadOnly = true;
            // 
            // productTipo
            // 
            productTipo.HeaderText = "productTipo";
            productTipo.Name = "productTipo";
            productTipo.ReadOnly = true;
            // 
            // productColor
            // 
            productColor.HeaderText = "productColor";
            productColor.Name = "productColor";
            productColor.ReadOnly = true;
            // 
            // productTalla
            // 
            productTalla.HeaderText = "productTalla";
            productTalla.Name = "productTalla";
            productTalla.ReadOnly = true;
            // 
            // productGenero
            // 
            productGenero.HeaderText = "productGenero";
            productGenero.Name = "productGenero";
            productGenero.ReadOnly = true;
            // 
            // productPrecio
            // 
            productPrecio.HeaderText = "productPrecio";
            productPrecio.Name = "productPrecio";
            productPrecio.ReadOnly = true;
            // 
            // productUbicacion
            // 
            productUbicacion.HeaderText = "productUbicacion";
            productUbicacion.Name = "productUbicacion";
            productUbicacion.ReadOnly = true;
            // 
            // productsDtoBindingSource
            // 
            productsDtoBindingSource.DataSource = typeof(ZapateriaAPI.Models.Dto.ProductsDto);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 33);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 7;
            label1.Text = "Carrito Compras";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(83, 48);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumAquamarine;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(82, 434);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumAquamarine;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(82, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(718, 67);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumAquamarine;
            panel5.Controls.Add(btnComprar);
            panel5.Controls.Add(btnCancelar);
            panel5.Location = new Point(82, 403);
            panel5.Name = "panel5";
            panel5.Size = new Size(718, 66);
            panel5.TabIndex = 11;
            // 
            // btnComprar
            // 
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Image = (Image)resources.GetObject("btnComprar.Image");
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(542, 0);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(176, 66);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(310, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(211, 63);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar Compra";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 469);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Controls.Add(pictureBox1);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuario";
            Text = "Usuario";
            Load += Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDtoBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnCerrar;
        private PictureBox btnRayita;
        private PictureBox btnMaximizar;
        private Panel BarraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button btnComprar;
        private Button btnCancelar;
        private BindingSource productsDtoBindingSource;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn productMarca;
        private DataGridViewTextBoxColumn productModelo;
        private DataGridViewTextBoxColumn productTipo;
        private DataGridViewTextBoxColumn productColor;
        private DataGridViewTextBoxColumn productTalla;
        private DataGridViewTextBoxColumn productGenero;
        private DataGridViewTextBoxColumn productPrecio;
        private DataGridViewTextBoxColumn productUbicacion;
        private ErrorProvider erpError;
        private Label lblHora;
        private Label lblFecha;
    }
}