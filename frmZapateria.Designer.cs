namespace frmZapateria
{
    partial class frmZapateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZapateria));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            btnRayita = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            MenuVertical = new Panel();
            panel4 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            panelContenedor = new Panel();
            button4 = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            MenuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.MediumSeaGreen;
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnRayita);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(800, 35);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTit_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.MediumSeaGreen;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(759, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRayita
            // 
            btnRayita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRayita.BackColor = Color.MediumSeaGreen;
            btnRayita.Cursor = Cursors.Hand;
            btnRayita.Image = (Image)resources.GetObject("btnRayita.Image");
            btnRayita.Location = new Point(675, 0);
            btnRayita.Name = "btnRayita";
            btnRayita.Size = new Size(41, 35);
            btnRayita.SizeMode = PictureBoxSizeMode.Zoom;
            btnRayita.TabIndex = 3;
            btnRayita.TabStop = false;
            btnRayita.Click += btnRayita_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.MediumSeaGreen;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(722, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(35, 35);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.MediumSeaGreen;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(722, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(41, 35);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.PowderBlue;
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(206, 415);
            MenuVertical.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumSeaGreen;
            panel4.Location = new Point(0, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 80);
            panel4.TabIndex = 6;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 271);
            button3.Name = "button3";
            button3.Size = new Size(206, 80);
            button3.TabIndex = 5;
            button3.Text = "Ventas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Location = new Point(0, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 89);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 192);
            button2.Name = "button2";
            button2.Size = new Size(203, 80);
            button2.TabIndex = 3;
            button2.Text = "Inventario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 84);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 122);
            button1.Name = "button1";
            button1.Size = new Size(203, 72);
            button1.TabIndex = 1;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 125);
            panel1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ControlLight;
            panelContenedor.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(206, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(594, 415);
            panelContenedor.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(99, 358);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // frmZapateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmZapateria";
            Text = "frmZapateria";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            MenuVertical.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox btnMaximizar;
        private PictureBox btnRayita;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button button3;
        private Panel panel3;
        private Button button2;
        private Button button4;
    }
}