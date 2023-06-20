using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmZapateria
{
    public partial class Login : Form
    {
        private string valorTextBox;
        private int intentos = 0;
        private const int maxIntentos = 3;

        public Login()
        {
            InitializeComponent();

            userUserName.Enabled = false;
            userUserName.BackColor = Color.LightGray;
            adminUserName.Enabled = false;
            adminUserName.BackColor = Color.LightGray;
            pasword.Enabled = false;
            pasword.BackColor = Color.LightGray;
            btnAtras.Visible = false;
            btnLoginUsuario.Enabled = false;
            btnLoginAdmin.Enabled = false;
        }

        private void AbrirFormHija(Form formHija)
        {
            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            this.Controls.Add(formHija);
            formHija.Show();
            this.Hide();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barraTit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRayita_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            userUserName.Visible = true;
            adminUserName.Visible = true;
            btnAdmin.Visible = true;
            btnUser.Visible = true;
            userUserName.Enabled = false;
            pasword.Enabled = false;
            adminUserName.Enabled = false;
        }

        private void btnLoginUsuario_Click(object sender, EventArgs e)
        {
            string UsernameUser = userUserName.Text;
            valorTextBox = userUserName.Text;

            if (!string.IsNullOrEmpty(UsernameUser))
            {
                AbrirFormHija(new Usuario());
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario vacio. Intenta de nuevo.");
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string username = adminUserName.Text;
            string password = pasword.Text;


            string UsernameAdmin = "Admin";
            string PassAdmin = "1234";



            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblValidar.Text = "Por favor, ingrese su nombre de usuario y contraseña.";
            }
            else if (username == UsernameAdmin && password == PassAdmin)
            {
                this.Hide();

                AbrirFormHija(new frmZapateria());
                

            }
            else
            {
                intentos++;

                if (intentos == maxIntentos)
                {
                    MessageBox.Show("Contraseña o usuario incorrectos. Has excedido el número máximo de intentos.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Contraseña o usuario incorrectos. Intento " + intentos + " de " + maxIntentos);
                    pasword.Text = "";
                    adminUserName.Text = "";
                    pasword.Focus();

                }
            }
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            userUserName.Visible = false;
            btnUser.Visible = false;
            btnAtras.Visible = true;
            adminUserName.Enabled = true;
            pasword.Enabled = true;
            btnLoginAdmin.Enabled = true;
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            adminUserName.Visible = false;
            btnAdmin.Visible = false;
            btnAtras.Visible = true;
            userUserName.Enabled = true;
            btnLoginUsuario.Enabled = true;
        }
    }
}
