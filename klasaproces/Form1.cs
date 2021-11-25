﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace klasaproces_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.exe");
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("wordpad.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;


            startInfo.Arguments = "www.sser.hr";


            Process.Start(startInfo);
        }
    }
}
