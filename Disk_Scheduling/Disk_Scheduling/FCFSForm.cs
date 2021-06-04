using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disk_Scheduling;

namespace FCFS_Algorithm
{
    public partial class FCFSForm : Form
    {
        public List<int> L = new List<int>();
        public List<string> Ls = new List<string>();
        public FCFSForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string pos = "";
            string req1 = "";

            pos = textBox2.Text;
            req1 = textBox1.Text;

            string[] req = req1.Split(' ');

          

            //MessageBox.Show(""+req);
            L.Add(int.Parse(pos));
            Ls.Add(pos);
            for (int i=0; i<req.Length;i++)
            {
                int x = int.Parse(req[i]);
                Ls.Add(req[i]);
                L.Add(x);
            }
            int total = 0;
            for (int i = 0; i < L.Count-1; i++)
            {
                if (L[i] > L[i + 1] )
                {
                    total += (L[i] - L[i + 1]);
                }
                else
                {
                    total += (L[i + 1] - L[i]);
                }
            }
            richTextBox1.Text = String.Join(" > ", Ls);
            richTextBox2.Text = total.ToString();
            ///MessageBox.Show("" + pos + " " + req);
        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
   
}
