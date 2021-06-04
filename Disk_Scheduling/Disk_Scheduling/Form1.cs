using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCFS_Algorithm;
using SSTF_Algorithm;
using Scan_Algorithm;
using CScan_Algorithm;

namespace Disk_Scheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FCFSbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCFSForm FCFS = new FCFSForm();
            FCFS.Show();

        }
        private void SSTFbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            SSTFform SSTF = new SSTFform();
            SSTF.Show();
        }
        private void Scanbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            SCANForm SCAN = new SCANForm();
            SCAN.Show();

        }

        private void CSCANbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            CSCANForm cSCAN = new CSCANForm();
            cSCAN.Show();
        }

        
    }
}
