namespace frmZapateria
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            barraTit = new Panel();
            panel4 = new Panel();
            btnCerrar = new PictureBox();
            btnRayita = new PictureBox();
            panel2 = new Panel();
            btnAtras = new Button();
            btnUser = new Button();
            btnAdmin = new Button();
            panel3 = new Panel();
            panel6 = new Panel();
            btnLoginAdmin = new Button();
            btnLoginUsuario = new Button();
            label1 = new Label();
            pasword = new TextBox();
            adminUserName = new TextBox();
            userUserName = new TextBox();
            lblValidar = new Label();
            panel8 = new Panel();
            panel5 = new Panel();
            panel11 = new Panel();
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
            barraTit.Controls.Add(panel4);
            barraTit.Controls.Add(btnCerrar);
            barraTit.Controls.Add(btnRayita);
            barraTit.Dock = DockStyle.Top;
            barraTit.Location = new Point(0, 0);
            barraTit.Name = "barraTit";
            barraTit.Size = new Size(511, 50);
            barraTit.TabIndex = 0;
            barraTit.MouseDown += barraTit_MouseDown;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 50);
            panel4.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.SeaGreen;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(469, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 6;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRayita
            // 
            btnRayita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRayita.BackColor = Color.SeaGreen;
            btnRayita.Cursor = Cursors.Hand;
            btnRayita.Image = (Image)resources.GetObject("btnRayita.Image");
            btnRayita.Location = new Point(413, 3);
            btnRayita.Name = "btnRayita";
            btnRayita.Size = new Size(41, 35);
            btnRayita.SizeMode = PictureBoxSizeMode.Zoom;
            btnRayita.TabIndex = 7;
            btnRayita.TabStop = false;
            btnRayita.Click += btnRayita_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(btnAtras);
            panel2.Controls.Add(btnUser);
            panel2.Controls.Add(btnAdmin);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 293);
            panel2.TabIndex = 1;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 258);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(34, 144);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(150, 50);
            btnUser.TabIndex = 1;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(34, 70);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(150, 50);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(btnLoginAdmin);
            panel3.Controls.Add(btnLoginUsuario);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pasword);
            panel3.Controls.Add(adminUserName);
            panel3.Controls.Add(userUserName);
            panel3.Controls.Add(lblValidar);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel11);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(228, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 293);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(47, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(158, 84);
            panel6.TabIndex = 73;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(57, 235);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(141, 42);
            btnLoginAdmin.TabIndex = 72;
            btnLoginAdmin.Text = "LOG IN";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnEntrar_Click;
            // 
            // btnLoginUsuario
            // 
            btnLoginUsuario.Location = new Point(57, 235);
            btnLoginUsuario.Name = "btnLoginUsuario";
            btnLoginUsuario.Size = new Size(141, 42);
            btnLoginUsuario.TabIndex = 71;
            btnLoginUsuario.Text = "LOG IN";
            btnLoginUsuario.UseVisualStyleBackColor = true;
            btnLoginUsuario.Click += btnLoginUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 103);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 70;
            label1.Text = "REGISTRESE";
            // 
            // pasword
            // 
            pasword.Location = new Point(47, 193);
            pasword.Name = "pasword";
            pasword.Size = new Size(171, 23);
            pasword.TabIndex = 69;
            // 
            // adminUserName
            // 
            adminUserName.Location = new Point(47, 152);
            adminUserName.Name = "adminUserName";
            adminUserName.Size = new Size(168, 23);
            adminUserName.TabIndex = 68;
            // 
            // userUserName
            // 
            userUserName.Location = new Point(47, 152);
            userUserName.Name = "userUserName";
            userUserName.Size = new Size(169, 23);
            userUserName.TabIndex = 67;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Location = new Point(47, 217);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(0, 15);
            lblValidar.TabIndex = 66;
            lblValidar.Visible = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkSlateGray;
            panel8.Location = new Point(41, 147);
            panel8.Name = "panel8";
            panel8.Size = new Size(179, 3);
            panel8.TabIndex = 63;
            panel8.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Location = new Point(39, 184);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 3);
            panel5.TabIndex = 65;
            panel5.Visible = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkSlateGray;
            panel11.Location = new Point(39, 216);
            panel11.Name = "panel11";
            panel11.Size = new Size(179, 3);
            panel11.TabIndex = 64;
            panel11.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 343);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(barraTit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "frmLogin";
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
        private Panel panel4;
        private PictureBox btnCerrar;
        private PictureBox btnRayita;
        private Panel panel2;
        private Button btnAtras;
        private Button btnUser;
        private Button btnAdmin;
        private Panel panel3;
        private Panel panel6;
        private Button btnLoginAdmin;
        private Button btnLoginUsuario;
        private Label label1;
        private TextBox pasword;
        private TextBox adminUserName;
        private TextBox userUserName;
        private Label lblValidar;
        private Panel panel8;
        private Panel panel5;
        private Panel panel11;
    }
}