using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(CopyFile);
            t.Start();
        }

        private void CopyFile()
        {
            FileManager fm = new FileManager();
            fm.InProgress += Fm_InProgress;
            fm.InProgress += Fm_InProgress2;
            fm.Copy("src.txt", "dest.txt");
        }

        private void Fm_InProgress2(object sender, double e)
        {
            Debug.WriteLine("Progress {0}", e);
        }

        private void Fm_InProgress(object sender, double e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<double>(Fm_InProgress), sender, e);
            }
            else
            {
                this.progressBar1.Value = (int)e;
                this.lblPct.Text = string.Format("{0} %", (int)e);
            }
            
        }
    }
}
