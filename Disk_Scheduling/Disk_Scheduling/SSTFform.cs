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
namespace SSTF_Algorithm
{
    public partial class SSTFform : Form
    { 
        public List<int> L = new List<int>();
      ///  public List<string> Ls = new List<string>();
        public List<Requests> Lr = new List<Requests>();
        public SSTFform()
        {
            InitializeComponent();
        }

        public bool getDirection(string prevhead, string dir, string pos)
        {
            if (prevhead == "")
            {
                if (dir == "Toward Larger Cylinder")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (int.Parse(prevhead) < int.Parse(pos))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int getNextvalue(int i, bool flag)
        {
            int distance = 999999999;
            int temp = 0;
            int next = -1;

            for (int k = 0; k < Lr.Count; k++)
            {
                if (i != k && Lr[k].visited == false)
                {
                    int x = 0;
                    if (Lr[i].value < Lr[k].value)
                    {
                        x = Lr[k].value - Lr[i].value;
                    }
                    else
                    {
                        x = Lr[i].value - Lr[k].value;
                    }
                    if (x < distance)
                    {
                        distance = x;
                        next = k;
                        temp = k;
                    }
                    else
                    {
                        if(distance==x)
                        {
                            if(flag)
                            {
                                if (Lr[temp].value < Lr[k].value)
                                {
                                    next = k;
                                    temp = k;
                                }
                            }
                            else
                            {
                                if (Lr[temp].value > Lr[k].value)
                                {
                                    next = k;
                                    temp = k;
                                }
                            }
                        }
                    }
                }
            }
            if(next>0)
            {
                Lr[next].visited = true;
                return next;
            }
            return next;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string pos = textBox1.Text;
            string req1 = textBox2.Text;
            string[] req = req1.Split(' ');

            string prevhead = textBox3.Text;
            string dir = comboBox1.Text;

            bool flag = getDirection(prevhead, dir, pos);

            Requests p = new Requests();
            p.value = int.Parse(pos);
            p.visited = true;
            Lr.Add(p);
            L.Add(int.Parse(pos));
            for (int i = 0; i < req.Length; i++)
            {
                int x = int.Parse(req[i]);
              
                Requests pnn = new Requests();
                pnn.value = x;
                Lr.Add(pnn);
            }

            int k = 0;
            for (int i = 0; i < Lr.Count-1; i++)
            {
                int x = getNextvalue(k, flag);
                    
                if(x>0)
                {
                    k = x;
                   /// MessageBox.Show(" " + Lr[x].value);
                    L.Add(Lr[x].value);
                }
            }

            int total = 0;
            for (int i = 0; i < L.Count - 1; i++)
            {
                if (L[i] > L[i + 1])
                {
                    total += (L[i] - L[i + 1]);
                }
                else
                {
                    total += (L[i + 1] - L[i]);
                }
            }
            richTextBox1.Text = String.Join(" > ", L);
            richTextBox2.Text = total.ToString();
        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
    public class Requests
    {
       public int value;
       public bool visited = false;

    }
}
