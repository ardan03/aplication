using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplication
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private int borderSize = 2;
        private Size formSize;
        public Form1()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor= Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF020;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            #region Изменение размера формы

            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                            {
                                m.Result = (IntPtr)HTTOPRIGHT;
                            }
                        }
                        else if (clientPoint.Y < (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X > (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }


                    }
                }
                return;
            }
            #endregion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
       
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {
                    }
                    this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (this.WindowState ==FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form2 ClosBt = new Form2();
            ClosBt.ShowDialog();
            if (ClosBt.resClose) {
               Application.Exit();
            }
            ClosBt.Dispose();
        }

        private void Colapse() {
            if (panel2.Width > 199)
            {
                panel2.Width = 50;
                panel1.Width = 50;
                pictureBox1.Visible = false;
                base.Dock = DockStyle.Top;
                foreach (Button b in panel2.Controls.OfType<Button>())
                {
                    b.Text = "";
                    b.ImageAlign = ContentAlignment.MiddleCenter;
                    b.Padding = new Padding(0);
                }
            }
            else
            {
                panel2.Width = 200;
                panel1.Width = 200;
                pictureBox1.Visible = true;
                base.Dock = DockStyle.None;
                foreach (Button b in panel2.Controls.OfType<Button>())
                {
                    b.Text = "  " + b.Tag.ToString();
                    b.ImageAlign = ContentAlignment.MiddleLeft;
                    b.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Colapse();
        }

        private void info_Click(object sender, EventArgs e)
        {
            OpenOtherForm(new FormApp.info(), sender);
        }
        private void OpenOtherForm(Form childForm,object sender) {
            if (activeForm != null)
            {
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void price_Click(object sender, EventArgs e)
        {
            OpenOtherForm(new FormApp.Chiki(), sender);
        }

        private void what_Click(object sender, EventArgs e)
        {
            OpenOtherForm(new FormApp.Form1(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}