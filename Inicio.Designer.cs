namespace frmZapateria
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yellowtail", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(251, 61);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido!!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(266, 159);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 1;
            label2.Text = "Gestión de Inventario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(351, 184);
            label3.Name = "label3";
            label3.Size = new Size(19, 23);
            label3.TabIndex = 2;
            label3.Text = "y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(328, 216);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "Ventas";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(299, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 90);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(12, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 107);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Cursor = Cursors.No;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 25);
            panel3.TabIndex = 6;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(594, 415);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}