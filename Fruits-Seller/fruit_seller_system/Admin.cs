using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_seller_system
{
    public partial class Adminwindow : Form
    {
        public Adminwindow()
        {
            InitializeComponent();
        }
      
        string path = "/";
        int view = 0;
        List<fruits> LF = new List<fruits>();
        private void uploadimageBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                path = OFD.FileName;
            }
        }
        private void additemBT_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && priceTB.Text != "" && colorTB.Text != "")
            {
                StreamWriter SW = new StreamWriter("fruits.txt", true);
                string name = nameTB.Text;
                string price = priceTB.Text;
                string color = colorTB.Text;
                if (path == "/")
                {
                    MessageBox.Show("please enter The image");
                }
                else
                {
                   
                    SW.WriteLine(name+ "," + price + "," + path + "," + color);
                    nameTB.Text = "";
                    priceTB.Text = "";
                    colorTB.Text = "";
                }
                SW.Close();
            }
        }

        private void Adminwindow_Load(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader("fruits.txt");
            while (!SR.EndOfStream)
            {
                fruits pnn = new fruits();
                string line = SR.ReadLine();
                string[] temp = line.Split(',');
                pnn.name = temp[0];
                pnn.price = temp[1];
                pnn.image = temp[2];
                pnn.color = temp[3];
                LF.Add(pnn);
            }
            SR.Close();

            pictureBox1.Image = Image.FromFile(LF[0].image);
            pricevalueLB.Text = LF[0].price;
            fruitnameLB.Text = LF[0].name;
            this.BackColor = Color.FromName(LF[0].color);

        }

        private void nextBT_Click(object sender, EventArgs e)
        {
            if(view!=LF.Count-1)
            {
                view++;
            }
            else
            {
                view = 0;
            }
           
            pictureBox1.Image = Image.FromFile(LF[view].image);
            pricevalueLB.Text = LF[view].price;
            fruitnameLB.Text = LF[view].name;
            this.BackColor=Color.FromName(LF[view].color);
        }

        private void previousBT_Click(object sender, EventArgs e)
        {
            if(view==0)
            {
                view = LF.Count - 1;
            }
            else
            {
                view--;
            }
            pictureBox1.Image = Image.FromFile(LF[view].image);
            pricevalueLB.Text = LF[view].price;
            fruitnameLB.Text = LF[view].name;
            this.BackColor = Color.FromName(LF[view].color);
        }
    }
    public class fruits
    {
        public string name;
        public string price;
        public string color;
        public string image;
        public int count = 1;
    }
}