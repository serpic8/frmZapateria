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

namespace Zapateria
{
    public partial class Zapateriaa : Form
    {
        private string valorTextBox;
        private int intentos = 0;
        private const int maxIntentos = 3;

        public Zapateriaa()
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
            btnUser.Visible = false;
            btnAtras.Visible = true;
            adminUserName.Enabled = true;
            pasword.Enabled = true;
            btnLoginAdmin.Enabled = true;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnAdmin.Visible = false;
            btnAtras.Visible = true;
            userUserName.Enabled = true;
            btnLoginUsuario.Enabled = true;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            btnAdmin.Visible = true;
            btnUser.Visible = true;
            userUserName.Enabled = false;
            pasword.Enabled = false;
            adminUserName.Enabled = false;
        }
    }
}
