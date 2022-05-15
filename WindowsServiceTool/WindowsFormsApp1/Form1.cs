using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C start cleanmgr.exe /LOWDISK");
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(1.2) > DateTime.Now);
            SendKeys.Send("{ENTER}");
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(1.2) > DateTime.Now);
            SendKeys.Send("{ENTER}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K wmic os get Caption & wmic cpu get name & wmic path win32_VideoController get name & systeminfo|findstr /C:Memory";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mmsys.cpl");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:windowsupdate");
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(1.13) > DateTime.Now);
            
            System.Diagnostics.Process.Start("CMD.exe", "/C UsoClient StartInteractiveScan");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:appsfeatures");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/C start explorer.exe %temp%");
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(1.50) > DateTime.Now);
            SendKeys.Send("^(a)");
            SendKeys.Send("{DELETE}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C start dfrgui.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;

            label2.BackColor = Color.Transparent;

            label3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe", "sysdm.cpl,,4");
        }
    }
    }