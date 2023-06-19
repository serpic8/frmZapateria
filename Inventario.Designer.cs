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
            textBox1 = new TextBox();
            productsDtoBindingSource = new BindingSource(components);
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Dock = DockStyle.Bottom;
            dgvInventario.Location = new Point(0, 110);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.Size = new Size(594, 305);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 1;
            // 
            // productsDtoBindingSource
            // 
            productsDtoBindingSource.DataSource = typeof(ZapateriaAPI.Models.Dto.ProductsDto);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(441, 46);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "button1";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 415);
            Controls.Add(btnBorrar);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private BindingSource productsDtoBindingSource;
        private Button btnBorrar;
    }
}