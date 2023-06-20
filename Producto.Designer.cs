namespace frmZapateria
{
    partial class Producto
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
            dgvProductos = new DataGridView();
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
            btnAgregar = new Button();
            btnEnviar = new Button();
            txtModelo = new TextBox();
            erpValidaciones = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpValidaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Bottom;
            dgvProductos.Location = new Point(0, 212);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(594, 203);
            dgvProductos.TabIndex = 33;
            // 
            // cboUbi
            // 
            cboUbi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbi.FormattingEnabled = true;
            cboUbi.Items.AddRange(new object[] { "Bodega", "Sede Altamira", "Sede Metrocentro", "Sede Multicentro" });
            cboUbi.Location = new Point(270, 101);
            cboUbi.Name = "cboUbi";
            cboUbi.Size = new Size(112, 23);
            cboUbi.TabIndex = 32;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(61, 106);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(108, 23);
            txtPrecio.TabIndex = 31;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "F", "M" });
            cboGenero.Location = new Point(466, 55);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(66, 23);
            cboGenero.TabIndex = 30;
            // 
            // cboTalla
            // 
            cboTalla.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTalla.FormattingEnabled = true;
            cboTalla.Items.AddRange(new object[] { "20", "20.5", "21", "21.5", "22", "22.5", "23", "23.5", "24", "24.5", "25", "25.5", "26", "26.5", "27", "27.5", "28", "28.5", "29", "29.5", "30", "30.5", "31", "31.5", "32", "32.5", "33", "33.5", "34", "34.5", "35", "35.5", "36", "36.5", "37", "37.5", "38", "38.5", "39", "39.5", "40", "40.5", "41", "41.5", "42", "42.5", "43", "43.5", "44", "44.5", "45", "45.5", "46", "46.5", "47", "47.5", "48" });
            cboTalla.Location = new Point(258, 55);
            cboTalla.Name = "cboTalla";
            cboTalla.Size = new Size(121, 23);
            cboTalla.TabIndex = 29;
            // 
            // cboColor
            // 
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColor.FormattingEnabled = true;
            cboColor.Items.AddRange(new object[] { "Negro", "Blanco", "Azul", "Rojo", "Verde", "Amarillo", "Rosa", "Morado", "Naranja", "Gris", "Marrón", "Beige", "Celeste", "Turquesa", "Plateado", "Dorado", "Ocre", "Violeta", "Coral", "Verde oliva" });
            cboColor.Location = new Point(57, 55);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(112, 23);
            cboColor.TabIndex = 28;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Zapatillas", "Zapatos de vestir", "Botas", "Sandalias", "Zapatos deportivos", "Zapatos casuales", "Mocasines", "Bailarinas", "Botines", "Chanclas", "Pantuflas", "Zapatos de tacón", "Zapatos planos", "Zapatos de plataforma" });
            cboTipo.Location = new Point(451, 4);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 27;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Items.AddRange(new object[] { "Nike", "Adidas", "Puma", "Reebok", "Converse", "Vans", "New Balance", "Timberland", "Skechers", "Clarks", "Dr Martens", "Gucci", "Balenciaga", "Fila", "Under Armour", "ASICS", "Jordan", "Salomon", "Merrell", "Brooks", "Mizuno", "Lacoste", "Versace", "Prada", "Dolce & Gabbana", "Burberry", "Calvin Klein", "Tommy Hilfiger", "Hugo Boss", "Ralph Lauren", "Coach", "Michael Kors", "Steve Madden" });
            cboMarca.Location = new Point(61, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(108, 23);
            cboMarca.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(201, 109);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 24;
            label8.Text = "Ubicacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 114);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 23;
            label7.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 63);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 22;
            label6.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 63);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 21;
            label5.Text = "Talla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 20;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 12);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 19;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 12);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 17;
            label1.Text = "Marca:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(395, 183);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(507, 183);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 36;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(258, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(121, 23);
            txtModelo.TabIndex = 37;
            // 
            // erpValidaciones
            // 
            erpValidaciones.ContainerControl = this;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 415);
            Controls.Add(txtModelo);
            Controls.Add(btnEnviar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Producto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpValidaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
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
        private Button btnAgregar;
        private Button btnEnviar;
        private TextBox txtModelo;
        private ErrorProvider erpValidaciones;
    }
}