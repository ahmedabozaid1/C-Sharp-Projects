using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_seller_system
{
    public partial class Cartwindow : Form
    {
        List<fruits> LCR = new List<fruits>();
        int totalprice = 0;
        public Cartwindow(List<fruits> LC)
        {
            InitializeComponent();
            LCR = LC;
        }
        int f = 0;
        private void Cartwindow_Load(object sender, EventArgs e)
        {
             
            for(int i=0;i<LCR.Count;i++)
            {
                int c = 1;
                if (LCR[i].count>1)
                {
                    c = LCR[i].count;
                }
                int value = Int32.Parse(LCR[i].price);
                totalprice += value*c;
                
            }
            for (int i = 0; i < LCR.Count; i++)
            {
               listBox.Items.Add(LCR[i].name +"*"+ LCR[i].count);
            }    
            priceLB.Text =Convert.ToString(totalprice);
        }

        private void removeBT_Click(object sender, EventArgs e)
        {

            for (int k = 0; k < LCR.Count; k++)
            {
                if (LCR[k].name + "*" + LCR[k].count == listBox.GetItemText(listBox.SelectedItem))
                {
                    if (LCR[k].count > 1)
                    {
                        LCR[k].count -= 1;
                        listBox.Items.Clear();
                        for (int i = 0; i < LCR.Count; i++)
                        {
                            listBox.Items.Add(LCR[i].name + "*" + LCR[i].count);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < LCR.Count; i++)
                        {
                            if (LCR[i].name + "*" + LCR[k].count == listBox.GetItemText(listBox.SelectedItem))
                            {
                                int value = Int32.Parse(LCR[k].price);
                                totalprice -= value;
                                priceLB.Text = Convert.ToString(totalprice);
                                f = 1;
                                LCR.RemoveAt(i);
                            }
                        }
                        listBox.Items.RemoveAt(listBox.SelectedIndex);

                    }
                    if (f == 0)
                    {
                        int value = Int32.Parse(LCR[k].price);
                        totalprice -= value;
                        priceLB.Text = Convert.ToString(totalprice);
                    }
                    else
                    {
                        f = 0;
                    }
                }
            }
            if(totalprice==0)
            {
                this.BackColor = Color.Gray;
                pictureBox1.Hide();
                fruitnamelabel.Text = "";
            }
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int k = 0; k < LCR.Count; k++)
            {
                if (LCR[k].name + "*" + LCR[k].count == listBox.GetItemText(listBox.SelectedItem))
                {
                    this.BackColor = Color.FromName(LCR[k].color);
                    pictureBox1.Image=Image.FromFile(LCR[k].image);
                    fruitnamelabel.Text = LCR[k].name;
                }
            }
        }
    }
}
