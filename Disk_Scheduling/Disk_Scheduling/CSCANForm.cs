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
namespace CScan_Algorithm
{
    public partial class CSCANForm : Form
    { 
        public List<int> L = new List<int>();
        public List<Requests> Lr = new List<Requests>();
        public List<Requests> Ls = new List<Requests>();
        public CSCANForm()
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
        public void CScan(bool flag)
        {
            int head = -1;
            for (int k = 0; k < Ls.Count; k++)
            {
                if (Ls[k].head)
                {
                    Ls[k].visited = true;
                    head = k;
                }
            }
            if (flag)
            {
                for(int i=head+1;i<Ls.Count;i++)
                {
                    L.Add(Ls[i].value);
                    Ls[i].visited = true;
                }
                L.Add(0);
                for(int i = 0;i<head;i++)
                {
                    L.Add(Ls[i].value);
                    Ls[i].visited = true;
                }
            }
            else
            {
               
                for (int i = head - 1; i >= 0; i--)
                {
                    L.Add(Ls[i].value);
                    Ls[i].visited = true;
                }
                L.Add(0);
                for (int i = Ls.Count-1; i > head; i--)
                {
                    L.Add(Ls[i].value);
                    Ls[i].visited = true;
                }
            }
          
        }
        public void sort(string Lastnum,bool flag)
        {
            
                Requests d = new Requests();
                d.value = int.Parse(Lastnum);
                d.end = true;
                Lr.Add(d);
            

            Ls = Lr.OrderBy(o => o.value).ToList();
          
        }
        public int calcSeekTime(List<int> L)
        {
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
            return total;
        }
        
        
        private void submit_Click(object sender, EventArgs e)
        {
            string pos = textBox1.Text;
            string req1 = textBox2.Text;
            string[] req = req1.Split(' ');
            string prevhead = textBox3.Text;
            string dir = comboBox1.Text;

            string Lastnum = textBox5.Text;
            bool flag = getDirection(prevhead, dir, pos); /// flag = true right flag = false left

            Requests p = new Requests();
            p.value = int.Parse(pos);
            p.head = true;
            Lr.Add(p);
            L.Add(int.Parse(pos));

            for (int i = 0; i < req.Length; i++)
            {
                int x = int.Parse(req[i]);
                Requests pnn = new Requests();
                pnn.value = x;
                Lr.Add(pnn);
            }
            sort(Lastnum, flag);

            CScan(flag);

            int total = calcSeekTime(L);
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
       public bool head = false;
       public bool end = false;

    }
}