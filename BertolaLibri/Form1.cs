using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BertolaLibri.Page;
using BertolaLibri.Control;
using BertolaLibri.Model;
using System.IO;

namespace BertolaLibri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRes.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRes.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitolo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Left;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnAnagrafiche_Click(object sender, EventArgs e)
        {
            faq frm = new faq();
            frm.ShowDialog();
        }

        private void btnLibri_Click(object sender, EventArgs e)
        {
            faq frm = new faq();
            frm.ShowDialog();
        }

        private void btnReparti_Click(object sender, EventArgs e)
        {
            pReparti.Visible = true;
            pOfferte.Visible = false;
            pEditori.Visible = false;
            pAutori.Visible = false;
            pInserisci.Visible = false;

            pageReparti uc = new pageReparti();
            addUserControl(uc);
        }

        private void btnOfferte_Click(object sender, EventArgs e)
        {
            pReparti.Visible = false;
            pOfferte.Visible = true;
            pEditori.Visible = false;
            pAutori.Visible = false;
            pInserisci.Visible = false;

            pageOfferte uc = new pageOfferte();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pageHome uc = new pageHome();
            addUserControl(uc);
        }
        private void btnEditori_Click(object sender, EventArgs e)
        {
            pReparti.Visible = false;
            pOfferte.Visible = false;
            pEditori.Visible = true;
            pAutori.Visible = false;
            pInserisci.Visible = false;
            pageEditori uc = new pageEditori();
            addUserControl(uc);
        }

        private void btnAutori_Click(object sender, EventArgs e)
        {
            pAutori.Visible = true;
            pReparti.Visible = false;
            pOfferte.Visible = false;
            pEditori.Visible = false;
            pInserisci.Visible = false;
            pageAutori uc = new pageAutori();
            addUserControl(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pAutori.Visible = false;
            pReparti.Visible = false;
            pOfferte.Visible = false;
            pEditori.Visible = false;
            pInserisci.Visible = false;
            pageHome uc = new pageHome();
            addUserControl(uc);
        }

        private void btnDomande_Click(object sender, EventArgs e)
        {
            faq frm = new faq();
            frm.ShowDialog();
        }

        private void btnInserisciLibro_Click(object sender, EventArgs e)
        {
            pInserisci.Visible = true;
            pAutori.Visible = false;
            pReparti.Visible = false;
            pOfferte.Visible = false;
            pEditori.Visible = false;

            pageLibri uc = new pageLibri();
            addUserControl(uc);
        }

    }
}
