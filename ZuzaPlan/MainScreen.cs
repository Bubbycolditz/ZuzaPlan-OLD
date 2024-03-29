﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ZuzaPlan {
    public partial class MainScreen : Form {
        public MainScreen() {
            InitializeComponent();
            /*var calendar = new Dictionary<VARDESC, string>
            for (int i = 0; i < 31; i++) {
                string day = "calendarDay" + i.ToString();
                day.Text = i;
            }*/
        }
        private void Form1_Load(object sender, EventArgs e) {
    }

        private void buttonTest_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void notesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void Mouse_Move(object sender, MouseEventArgs e) {

        }
        private void MainScreen_MouseDown(object sender, MouseEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void notesLink_Click(object sender, EventArgs e) {

        }

        private void projectsLink_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            AboutScreen aboutScreen = new AboutScreen();
            aboutScreen.Show();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void resizeButton_Click(object sender, EventArgs e) {

        }

        private void exitButton_Click(object sender, EventArgs e) {

        }

        private void button1_Click_2(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
                maximizeButton.BackgroundImage = ZuzaPlan.Properties.Resources.Windowed;
            } else {
                WindowState = FormWindowState.Normal;
                maximizeButton.BackgroundImage = ZuzaPlan.Properties.Resources.Maximize;
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void navbar_MouseDown(object sender, MouseEventArgs e) {
            lastPoint = new Point(e.X, e.Y);
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        Point lastPoint;
        private void navbar_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) {
                return;
            }
            base.WndProc(ref m);
        }

        private void signInButton_Click(object sender, EventArgs e) {
            LoginScreen signinScreen = new LoginScreen();
            signinScreen.Show();
        }

        private void assignmentsButton_Click(object sender, EventArgs e) {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel33_Paint(object sender, PaintEventArgs e) {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e) {

        }

        private void MainScreen_Resize(object sender, EventArgs e) {
            AdjustForm();
        }

        private void AdjustForm() {
            switch (this.WindowState) {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != 0)
                        this.Padding = new Padding(0);
                    break;
            }
        }
        private void calendarDay3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
