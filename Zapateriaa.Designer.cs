namespace Zapateria
{
    partial class Zapateriaa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zapateriaa));
            barraTit = new Panel();
            btnCerrar = new PictureBox();
            btnRayita = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            btnAtras = new FontAwesome.Sharp.IconButton();
            btnAdmin = new FontAwesome.Sharp.IconButton();
            btnUser = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label1 = new Label();
            pasword = new TextBox();
            adminUserName = new TextBox();
            userUserName = new TextBox();
            panel1 = new Panel();
            lblValidar = new Label();
            panel8 = new Panel();
            panel5 = new Panel();
            panel11 = new Panel();
            btnLoginUsuario = new Button();
            btnLoginAdmin = new Button();
            barraTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // barraTit
            // 
            barraTit.BackColor = Color.SeaGreen;
            barraTit.Controls.Add(btnCerrar);
            barraTit.Controls.Add(btnRayita);
            barraTit.Controls.Add(panel4);
            barraTit.Dock = DockStyle.Top;
            barraTit.Location = new Point(0, 0);
            barraTit.Name = "barraTit";
            barraTit.Size = new Size(511, 50);
            barraTit.TabIndex = 0;
            barraTit.MouseDown += barraTit_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.SeaGreen;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(468, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 4;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRayita
            // 
            btnRayita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRayita.BackColor = Color.SeaGreen;
            btnRayita.Cursor = Cursors.Hand;
            btnRayita.Image = (Image)resources.GetObject("btnRayita.Image");
            btnRayita.Location = new Point(412, 0);
            btnRayita.Name = "btnRayita";
            btnRayita.Size = new Size(41, 35);
            btnRayita.SizeMode = PictureBoxSizeMode.Zoom;
            btnRayita.TabIndex = 5;
            btnRayita.TabStop = false;
            btnRayita.Click += btnRayita_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 50);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(btnAtras);
            panel2.Controls.Add(btnAdmin);
            panel2.Controls.Add(btnUser);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 293);
            panel2.TabIndex = 1;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.ForeColor = Color.Black;
            btnAtras.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnAtras.IconColor = Color.White;
            btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtras.IconSize = 20;
            btnAtras.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtras.Location = new Point(12, 249);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(91, 23);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            btnAdmin.IconColor = Color.Black;
            btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmin.IconSize = 40;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(35, 66);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(150, 50);
            btnAdmin.TabIndex = 8;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Transparent;
            btnUser.ForeColor = Color.Black;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUser.IconColor = Color.Black;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 40;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(35, 132);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(150, 50);
            btnUser.TabIndex = 9;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(btnLoginAdmin);
            panel3.Controls.Add(btnLoginUsuario);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pasword);
            panel3.Controls.Add(adminUserName);
            panel3.Controls.Add(userUserName);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(lblValidar);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel11);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(229, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 293);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 98);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 60;
            label1.Text = "REGISTRESE";
            // 
            // pasword
            // 
            pasword.Location = new Point(41, 188);
            pasword.Name = "pasword";
            pasword.Size = new Size(171, 23);
            pasword.TabIndex = 59;
            // 
            // adminUserName
            // 
            adminUserName.Location = new Point(41, 147);
            adminUserName.Name = "adminUserName";
            adminUserName.Size = new Size(168, 23);
            adminUserName.TabIndex = 58;
            // 
            // userUserName
            // 
            userUserName.Location = new Point(41, 147);
            userUserName.Name = "userUserName";
            userUserName.Size = new Size(169, 23);
            userUserName.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(31, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 91);
            panel1.TabIndex = 56;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Location = new Point(41, 212);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(0, 15);
            lblValidar.TabIndex = 55;
            lblValidar.Visible = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkSlateGray;
            panel8.Location = new Point(35, 142);
            panel8.Name = "panel8";
            panel8.Size = new Size(179, 3);
            panel8.TabIndex = 47;
            panel8.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Location = new Point(33, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 3);
            panel5.TabIndex = 52;
            panel5.Visible = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkSlateGray;
            panel11.Location = new Point(33, 211);
            panel11.Name = "panel11";
            panel11.Size = new Size(179, 3);
            panel11.TabIndex = 49;
            panel11.Visible = false;
            // 
            // btnLoginUsuario
            // 
            btnLoginUsuario.Location = new Point(41, 230);
            btnLoginUsuario.Name = "btnLoginUsuario";
            btnLoginUsuario.Size = new Size(163, 42);
            btnLoginUsuario.TabIndex = 61;
            btnLoginUsuario.Text = "LOG IN";
            btnLoginUsuario.UseVisualStyleBackColor = true;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(41, 230);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(163, 42);
            btnLoginAdmin.TabIndex = 62;
            btnLoginAdmin.Text = "LOG IN";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            // 
            // Zapateriaa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 343);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(barraTit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Zapateriaa";
            Text = "Zapateriaa";
            barraTit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTit;
        private PictureBox btnCerrar;
        private PictureBox btnRayita;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Label lblValidar;
        private Panel panel8;
        private Panel panel5;
        private Panel panel11;
        private FontAwesome.Sharp.IconButton btnAtras;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnUser;
        private TextBox pasword;
        private TextBox adminUserName;
        private TextBox userUserName;
        private Label label1;
        private Button btnLoginAdmin;
        private Button btnLoginUsuario;
    }
}