﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        private int tiempo;
        private const int WN_SYSCOMMAND = 0x112;
        private const int SC_MONITORPOWER = 0xF170;

        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr hWnd, int wParam, int lParam);

        [DllImport("winmm")]
        private static extern void mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, long hwndCallback);

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ApagarMonitor()
        {
            SendMessage(this.Handle, WN_SYSCOMMAND, SC_MONITORPOWER, 2);
        }


        private void EncenderMonitor()
        {
            SendMessage(this.Handle, WN_SYSCOMMAND, SC_MONITORPOWER, -1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApagarMonitor();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            mciSendString("set CDAudio door open", "", 127, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tiempo = 5;
            ApagarMonitor();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo !=0)
            {
                tiempo--;
            }
            else
            {
                timer1.Stop();
                EncenderMonitor();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mciSendString("set CDAudio door close", "", 127, 0); 
        }


    }
}
