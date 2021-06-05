using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybirds
{
    public class bird
    {
        public int X, Y;
        public Bitmap img;
        public Bitmap img2;
        public Bitmap img3;
        public Bitmap img4;
        public Bitmap img5;
        public Bitmap img6;
    }
    public class tower
    {
        public int X, Y;
        public int H;
        public Bitmap img;
        public Boolean defeated = false;
    }
    public class evil
    {
        public int X, Y;
        public Bitmap img;
        public Boolean up= false;
        public Boolean defeated = false;
    }
    public class coin
    {
        public int X, Y;
        public Bitmap img;
        public Boolean eaten = false;
    }
    public partial class Form1 : Form 
    {
        Timer tt = new Timer();
        Random RR = new Random();
        Bitmap off;
        Bitmap background = new Bitmap("background.png");
        Bitmap image;
        List<bird> LB = new List<bird>();
        List<tower> Ltup = new List<tower>();
        List<tower> Ltdown = new List<tower>();
        List<evil> LE = new List<evil>();
        List<coin> LC = new List<coin>();
        int speeddown = 0;
        int speedup = 0;
        int fmove = 0;
        int xb = 0;
        int xp = 0;
        int ft = 1;
        int f = 1;
        int fm = 0;
        int score = 0;
        int coins = 0;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            tt.Tick += Tt_Tick;
            this.Load += Form1_Load1;
            tt.Start();
        }
        private void Tt_Tick(object sender, EventArgs e)
        {
            if (ft == 0)
            {
                f = 0;
                for (int i = 0; i < Ltup.Count; i++)
                {
                    if (LB[0].X < Ltup[i].X + xp + Ltup[i].img.Width/5 &&
                                  LB[0].X + LB[0].img.Width/10 > Ltup[i].X + xp &&
                                  LB[0].Y < Ltup[i].Y + Ltup[i].H &&
                                  LB[0].Y + LB[0].img.Height/10 > Ltup[i].Y
                              )
                    {
                        ft = 1;
                        speeddown = 0;

                    }
                    if (LB[0].X < Ltdown[i].X + xp + Ltdown[i].img.Width / 5 &&
                                 LB[0].X + LB[0].img.Width / 10 > Ltdown[i].X + xp &&
                                 LB[0].Y < Ltdown[i].Y + Ltdown[i].H &&
                                 LB[0].Y + LB[0].img.Height / 10 > Ltdown[i].Y
                             )
                    {
                        ft = 1;
                        speeddown = 0;
                    }
                    if (LB[0].X >= Ltdown[i].X + xp + Ltdown[i].img.Width / 5)
                    {
                        if (!Ltdown[i].defeated)
                        {
                            score++;
                            Ltdown[i].defeated = true;
                        }
                    }
                }
                for(int i=0;i<LE.Count;i++)
                {
                    if (LB[0].X < LE[i].X + xp + LE[i].img.Width / 7 &&
                                  LB[0].X + LB[0].img.Width / 11 > LE[i].X + xp &&
                                  LB[0].Y < LE[i].Y + LE[i].img.Height / 7 &&
                                  LB[0].Y + LB[0].img.Height / 11 > LE[i].Y
                              )
                    {
                        ft = 1;
                        speeddown = 0;
                    }

                    if (LB[0].X >= LE[i].X + xp + LE[i].img.Width / 5)
                    {
                        if (!LE[i].defeated)
                        {
                            score+=5;
                            LE[i].defeated = true;
                        }
                    }
                }
                for(int i=0;i<LC.Count; i++)
                {
                    if (LB[0].X < LC[i].X + xp + LC[i].img.Width / 10 &&
                                 LB[0].X + LB[0].img.Width / 11 > LC[i].X + xp &&
                                 LB[0].Y < LC[i].Y + LC[i].img.Height / 10 &&
                                 LB[0].Y + LB[0].img.Height / 11 > LC[i].Y
                             )
                    {
                        if (!LC[i].eaten)
                        {
                            coins ++;
                            LC[i].eaten = true;
                        }
                    }
                }
                xp -= 10;
                if (fmove == 1)
                {
                    speeddown = 0;
                    speedup += 2;
                    LB[0].Y -= speedup;
                }
                else
                {
                    speedup = 0;
                    speeddown += 1;
                    LB[0].Y += speeddown += 1;
                }
                if (this.ClientSize.Width + xb == 0)
                {
                    xb = 0; 
                }
                else
                {
                    xb -= 10;
                }
                if (image == LB[0].img)
                {
                    image = LB[0].img2;
                }
                else if (image == LB[0].img2)
                {
                    image = LB[0].img3;
                }
                else if (image == LB[0].img3)
                {
                    image = LB[0].img4;
                }
                else if (image == LB[0].img4)
                {
                    image = LB[0].img;
                }
                for (int i = 0; i < LE.Count; i++)
                {
                    if(LE[i].Y>=800)
                    {
                        LE[i].up = true;
                    }
                    else if(LE[i].Y<=140)
                    {
                        LE[i].up = false;
                    }

                    if (LE[i].up)
                    {
                       
                        LE[i].Y -= 20;
                    }
                    else
                    {
                        LE[i].Y += 20;

                    }
                }
                DrawDubb(this.CreateGraphics());
            }
            else
            {
                if (f == 0)
                {
                    fm = 1;
                    if (LB[0].Y < this.ClientSize.Height)
                    {
                        speeddown += 2;
                        LB[0].Y += speeddown;
                        if(image==LB[0].img5)
                        {
                            image = LB[0].img6;
                        }
                        else
                        {
                            image = LB[0].img5;
                        }
                        DrawDubb(this.CreateGraphics());
                    }
                    else
                    {
                        tt.Stop();
                        MessageBox.Show("Your Score: " + score +'\n' + "Your coins: " + coins);
                        this.Hide();
                    }
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            fmove = 0;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (fm == 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    fmove = 1;
                    ft = 0;
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load1(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            createActor();
            createEnemies();
        }
        void createActor()
        {
            bird bird = new bird();
            bird.X = this.ClientSize.Width / 12;
            bird.Y = this.ClientSize.Height / 2;
            bird.img = new Bitmap("frame-1.png");
            bird.img2 = new Bitmap("frame-2.png");
            bird.img3 = new Bitmap("frame-3.png");
            bird.img4 = new Bitmap("frame-4.png");
            bird.img5 = new Bitmap("hit-frame-1.png");
            bird.img6 = new Bitmap("hit-frame-2.png");
            LB.Add(bird);
            image =LB[0].img;
        }
        void createEnemies()
        {
            int ct = 0;
            int xt = 500;
            for (int i = 0; i < 50; i++)
            {
                ct++;
                int h = RR.Next(5, 500);
                if (ct%5==0)
                {
                    xt += 500;
                    evil evil = new evil();
                    evil.X = Ltdown[i - 1].X + 400;
                    evil.Y = 110;
                    evil.img = new Bitmap("evil.png");
                    evil.img.MakeTransparent(evil.img.GetPixel(0, 0));
                    LE.Add(evil);

                    int x = Ltdown[i - 1].X + (Ltdown[i - 1].img.Width / 5) / 4 + 350;
                    int y = Ltdown[i - 1].Y + (Ltdown[i - 1].img.Height / 5 + h) + 70;
                    for (int k = 0; k < 4; k++)
                    {
                        coin coin = new coin();
                        coin.img = new Bitmap("coin.png");
                        coin.img.MakeTransparent(coin.img.GetPixel(0, 0));
                        if (k == 1)
                        {
                            x += coin.img.Width / 10 + 20;
                        }
                        if (k == 2)
                        {
                            y += coin.img.Height / 10 + 20;
                           
                        }
                        if (k == 3)
                        {
                           x= Ltdown[i - 1].X + (Ltdown[i - 1].img.Width / 5) / 4 + 350;
                        }

                        coin.X = x;
                        coin.Y = y;
                        LC.Add(coin);
                    }

                }
                int yt = 0;
               
                tower tower2 = new tower();
                tower2.X = xt;
                tower2.Y = yt;
                tower2.img = new Bitmap("tdown.png");
                tower2.img.MakeTransparent(tower2.img.GetPixel(0, 0));
                tower2.H = tower2.img.Height / 5 + h;
                Ltdown.Add(tower2);
                
                tower tower = new tower();
                tower.X = xt;
                tower.img = new Bitmap("tup.png");
                tower.img.MakeTransparent(tower.img.GetPixel(0, 0));
                tower.Y = tower2.Y + tower2.H + LB[0].img.Height / 10 + 70;
                tower.H = this.ClientSize.Height - tower.Y;
                Ltup.Add(tower);
                xt += 350;
            }
        }
        void DrawScene(Graphics g)
        {
            g.Clear(Color.Black);
            g.DrawImage(background,
                        new Rectangle(xb, 0, this.ClientSize.Width, this.ClientSize.Height),// Dst // Screen
                        new Rectangle(0, 0, background.Width, background.Height),   // Src // Image
                        GraphicsUnit.Pixel);
            g.DrawImage(background,
                        new Rectangle(this.ClientSize.Width + xb - 10, 0, this.ClientSize.Width, this.ClientSize.Height),// Dst // Screen
                        new Rectangle(0, 0, background.Width, background.Height),   // Src // Image
                        GraphicsUnit.Pixel);
            for(int i=0;i<LC.Count;i++)
            {
                if (!LC[i].eaten)
                {

                    g.DrawImage(LC[i].img,
                         new Rectangle(LC[i].X + xp, LC[i].Y, LC[i].img.Width / 10, LC[i].img.Height / 10),// Dst // Screen
                         new Rectangle(0, 0, LC[i].img.Width, LC[i].img.Height),   // Src // Image
                             GraphicsUnit.Pixel);
                }
            }
            for(int i=0;i<LE.Count;i++)
            {
                g.DrawImage(LE[i].img,
                        new Rectangle(LE[i].X + xp, LE[i].Y, LE[i].img.Width / 5, LE[i].img.Height / 5),// Dst // Screen
                        new Rectangle(0, 0, LE[i].img.Width, LE[i].img.Height),   // Src // Image
                            GraphicsUnit.Pixel);
            }
            for (int i = 0; i < Ltup.Count; i++)
            {
                g.DrawImage(Ltup[i].img,
                            new Rectangle(Ltup[i].X + xp, Ltup[i].Y, Ltup[i].img.Width / 5, Ltup[i].H),// Dst // Screen
                            new Rectangle(0, 0, Ltup[i].img.Width, Ltup[i].img.Height),   // Src // Image
                            GraphicsUnit.Pixel);


                g.DrawImage(Ltdown[i].img,
                        new Rectangle(Ltdown[i].X + xp, Ltdown[i].Y, Ltdown[i].img.Width / 5, Ltdown[i].H),// Dst // Screen
                        new Rectangle(0, 0, Ltdown[i].img.Width, Ltdown[i].img.Height),   // Src // Image
                            GraphicsUnit.Pixel);
            }
            for (int i = 0; i < LB.Count; i++)
            {
                g.DrawImage(image,
                            new Rectangle(LB[i].X, LB[i].Y, LB[i].img.Width / 11, LB[i].img.Height / 11),// Dst // Screen
                            new Rectangle(0, 0, LB[i].img.Width, LB[i].img.Height),   // Src // Image
                            GraphicsUnit.Pixel);
            }
            string drawString = "Score: " + score + '\n'+"Coins: " + coins;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 30);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}
