using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketPlayer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            timerW.Enabled = true;
            timerAD.Enabled = true;
            timerLMB.Enabled = true;
            timerRBM.Enabled = true;
            timerEnter.Enabled = true;
            timerR.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keybd_event((byte)0x57, 0, 0x0002 | 0, 0);
            timerW.Enabled = false;
            timerAD.Enabled = false;
            timerLMB.Enabled = false;
            timerRBM.Enabled = false;
            timerEnter.Enabled = false;
            timerR.Enabled = false;
        }

        private void timerW_Tick(object sender, EventArgs e)
        {
            keybd_event((byte)0x57, 0, 0x0001 | 0, 0);
        }

        private void timerAD_Tick(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            List<int> delays = new List<int>();

            list.Add(0x41);
            list.Add(0x44);

            delays.Add(600);
            delays.Add(800);
            delays.Add(1000);

            int r = rnd.Next(list.Count);
            int key = list[r];
            int rd = rnd.Next(delays.Count);
            int time = delays[rd];

            keybd_event((byte)key, 0, 0x0001 | 0, 0);
            Thread.Sleep(time);
            keybd_event((byte)key, 0, 0x0002 | 0, 0);
        }

        private void timerLMB_Tick(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            list.Add(600);
            list.Add(800);
            list.Add(1000);

            int r = rnd.Next(list.Count);
            int time = list[r];

            keybd_event((byte)0x01, 0, 0x0001 | 0, 0);
            Thread.Sleep(time);
            keybd_event((byte)0x01, 0, 0x0002 | 0, 0);
        }

        private void timerRBM_Tick(object sender, EventArgs e)
        {
            keybd_event((byte)0x02, 0, 0x0001 | 0, 0);
            Thread.Sleep(100);
            keybd_event((byte)0x02, 0, 0x0002 | 0, 0);
            Thread.Sleep(100);
            keybd_event((byte)0x02, 0, 0x0001 | 0, 0);
            Thread.Sleep(100);
            keybd_event((byte)0x02, 0, 0x0002 | 0, 0);
        }

        private void timerEnter_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("r");
        }
    }
}
