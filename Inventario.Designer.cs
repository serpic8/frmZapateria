namespace frmZapateria
{
    partial class Inventario
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
            dgvInventario = new DataGridView();
            txtBuscar = new TextBox();
            productsDtoBindingSource = new BindingSource(components);
            btnBorrar = new Button();
            btnActualizar = new Button();
            txtModelo = new TextBox();
            cboUbi = new ComboBox();
            txtPrecio = new TextBox();
            cboGenero = new ComboBox();
            cboTalla = new ComboBox();
            cboColor = new ComboBox();
            cboTipo = new ComboBox();
            cboMarca = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Dock = DockStyle.Bottom;
            dgvInventario.Location = new Point(0, 206);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.Size = new Size(594, 209);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellClick += dgvInventario_CellClick;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            dgvInventario.KeyDown += dgvInventario_KeyDown;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(52, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(282, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // productsDtoBindingSource
            // 
            productsDtoBindingSource.DataSource = typeof(ZapateriaAPI.Models.Dto.ProductsDto);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(385, 164);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(478, 164);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(237, 56);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(73, 22);
            txtModelo.TabIndex = 53;
            // 
            // cboUbi
            // 
            cboUbi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboUbi.FormattingEnabled = true;
            cboUbi.Items.AddRange(new object[] { "Bodega", "Sede Altamira", "Sede Metrocentro", "Sede Multicentro" });
            cboUbi.Location = new Point(248, 146);
            cboUbi.Name = "cboUbi";
            cboUbi.Size = new Size(62, 21);
            cboUbi.TabIndex = 52;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(73, 146);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(65, 22);
            txtPrecio.TabIndex = 51;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "F", "M" });
            cboGenero.Location = new Point(457, 99);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(51, 21);
            cboGenero.TabIndex = 50;
            // 
            // cboTalla
            // 
            cboTalla.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTalla.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboTalla.FormattingEnabled = true;
            cboTalla.Items.AddRange(new object[] { "20", "20.5", "21", "21.5", "22", "22.5", "23", "23.5", "24", "24.5", "25", "25.5", "26", "26.5", "27", "27.5", "28", "28.5", "29", "29.5", "30", "30.5", "31", "31.5", "32", "32.5", "33", "33.5", "34", "34.5", "35", "35.5", "36", "36.5", "37", "37.5", "38", "38.5", "39", "39.5", "40", "40.5", "41", "41.5", "42", "42.5", "43", "43.5", "44", "44.5", "45", "45.5", "46", "46.5", "47", "47.5", "48" });
            cboTalla.Location = new Point(237, 107);
            cboTalla.Name = "cboTalla";
            cboTalla.Size = new Size(73, 21);
            cboTalla.TabIndex = 49;
            // 
            // cboColor
            // 
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboColor.FormattingEnabled = true;
            cboColor.Items.AddRange(new object[] { "Negro", "Blanco", "Azul", "Rojo", "Verde", "Amarillo", "Rosa", "Morado", "Naranja", "Gris", "Marrón", "Beige", "Celeste", "Turquesa", "Plateado", "Dorado", "Ocre", "Violeta", "Coral", "Verde oliva" });
            cboColor.Location = new Point(73, 102);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(65, 21);
            cboColor.TabIndex = 48;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Zapatillas", "Zapatos de vestir", "Botas", "Sandalias", "Zapatos deportivos", "Zapatos casuales", "Mocasines", "Bailarinas", "Botines", "Chanclas", "Pantuflas", "Zapatos de tacón", "Zapatos planos", "Zapatos de plataforma" });
            cboTipo.Location = new Point(457, 62);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(60, 21);
            cboTipo.TabIndex = 47;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboMarca.FormattingEnabled = true;
            cboMarca.Items.AddRange(new object[] { "Nike", "Adidas", "Puma", "Reebok", "Converse", "Vans", "New Balance", "Timberland", "Skechers", "Clarks", "Dr Martens", "Gucci", "Balenciaga", "Fila", "Under Armour", "ASICS", "Jordan", "Salomon", "Merrell", "Brooks", "Mizuno", "Lacoste", "Versace", "Prada", "Dolce & Gabbana", "Burberry", "Calvin Klein", "Tommy Hilfiger", "Hugo Boss", "Ralph Lauren", "Coach", "Michael Kors", "Steve Madden" });
            cboMarca.Location = new Point(73, 57);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(65, 21);
            cboMarca.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(181, 155);
            label8.Name = "label8";
            label8.Size = new Size(61, 13);
            label8.TabIndex = 45;
            label8.Text = "Ubicacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 155);
            label7.Name = "label7";
            label7.Size = new Size(41, 13);
            label7.TabIndex = 44;
            label7.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(372, 107);
            label6.Name = "label6";
            label6.Size = new Size(48, 13);
            label6.TabIndex = 43;
            label6.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(181, 110);
            label5.Name = "label5";
            label5.Size = new Size(33, 13);
            label5.TabIndex = 42;
            label5.Text = "Talla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(38, 13);
            label4.TabIndex = 41;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(372, 65);
            label3.Name = "label3";
            label3.Size = new Size(33, 13);
            label3.TabIndex = 40;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 13);
            label2.TabIndex = 39;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(41, 13);
            label1.TabIndex = 38;
            label1.Text = "Marca:";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 415);
            Controls.Add(txtModelo);
            Controls.Add(cboUbi);
            Controls.Add(txtPrecio);
            Controls.Add(cboGenero);
            Controls.Add(cboTalla);
            Controls.Add(cboColor);
            Controls.Add(cboTipo);
            Controls.Add(cboMarca);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnBorrar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventario;
        private TextBox txtBuscar;
        private BindingSource productsDtoBindingSource;
        private Button btnBorrar;
        private Button btnActualizar;
        private TextBox txtModelo;
        private ComboBox cboUbi;
        private TextBox txtPrecio;
        private ComboBox cboGenero;
        private ComboBox cboTalla;
        private ComboBox cboColor;
        private ComboBox cboTipo;
        private ComboBox cboMarca;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}