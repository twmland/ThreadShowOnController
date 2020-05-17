using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadShowOnController
{
    public partial class Form1 : Form
    {
        private delegate void DisplayTime(TextBox txtBx);
        private void ShowCurrentTime(TextBox txtBx)
        {
            txtBx.Text = DateTime.Now.ToString("hh:MM:ss");     
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ShowTime);
            Thread thread = new Thread(threadStart);
            thread.Start(null);
        }
        private void ShowTime(object obj)
        {
            while (true)
            {
                Thread.Sleep(100);
                if (TxtBxNow.InvokeRequired)
                {
                    DisplayTime displayTimeDelegate = new DisplayTime(ShowCurrentTime);
                    this.Invoke(displayTimeDelegate, TxtBxNow);
                }
                else
                {
                    TxtBxNow.Text = DateTime.Now.ToString("hh:MM:ss");
                }
            }
        }


    }
}
