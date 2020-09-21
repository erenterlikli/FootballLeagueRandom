using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLeague
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Random rand = new Random();
            int a = rand.Next(0, 6);
            int b = rand.Next(0, 6);
            int c = rand.Next(0, 6);
            int d = rand.Next(0, 6);
            label7.Text = a.ToString();
            label8.Text = b.ToString();
            label9.Text = c.ToString();
            label10.Text = d.ToString();

            if (Convert.ToInt32(label7.Text) > (Convert.ToInt32(label8.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label35.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) > (Convert.ToInt32(label7.Text)))
            {
                tspuan = tspuan + 3;
                label37.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == (Convert.ToInt32(label8.Text)))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                label35.Text = bjkpuan.ToString();
                label37.Text = tspuan.ToString();
            }


            if (Convert.ToInt32(label9.Text) > (Convert.ToInt32(label10.Text)))
            {
                fbpuan = fbpuan + 3;
                label36.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) < (Convert.ToInt32(label10.Text)))
            {
                gspuan = gspuan + 3;
                label38.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) == (Convert.ToInt32(label10.Text)))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label36.Text = fbpuan.ToString();
                label38.Text = gspuan.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Random rand = new Random();
            int a = rand.Next(0, 6);
            int b = rand.Next(0, 6);
            int c = rand.Next(0, 6);
            int d = rand.Next(0, 6);
            label15.Text = a.ToString();
            label14.Text = b.ToString();
            label13.Text = c.ToString();
            label12.Text = d.ToString();

            if (Convert.ToInt32(label15.Text) > (Convert.ToInt32(label14.Text)))
            {
                fbpuan = fbpuan + 3;
                label36.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) < (Convert.ToInt32(label14.Text)))
            {
                tspuan = tspuan + 3;
                label37.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) == (Convert.ToInt32(label14.Text)))
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                label36.Text = fbpuan.ToString();
                label37.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label13.Text) > (Convert.ToInt32(label12.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label35.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) < (Convert.ToInt32(label12.Text)))
            {
                gspuan = gspuan + 3;
                label38.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) == (Convert.ToInt32(label12.Text)))
            {
                bjkpuan = bjkpuan + 1;
                gspuan = tspuan + 1;
                label35.Text = bjkpuan.ToString();
                label38.Text = gspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Random rand = new Random();
            int a = rand.Next(0, 6);
            int b = rand.Next(0, 6);
            int c = rand.Next(0, 6);
            int d = rand.Next(0, 6);
            label25.Text = a.ToString();
            label24.Text = b.ToString();
            label23.Text = c.ToString();
            label22.Text = d.ToString();


            if (Convert.ToInt32(label25.Text) > (Convert.ToInt32(label24.Text)))
            {
                bjkpuan = bjkpuan + 3;
                label35.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) < (Convert.ToInt32(label24.Text)))
            {
                fbpuan = fbpuan + 3;
                label36.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label25.Text) == (Convert.ToInt32(label24.Text)))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                label35.Text = bjkpuan.ToString();
                label36.Text = fbpuan.ToString();
                
            }
            if (Convert.ToInt32(label23.Text) > (Convert.ToInt32(label22.Text)))
            {
                tspuan = tspuan + 3;
                label37.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label23.Text) < (Convert.ToInt32(label22.Text)))
            {
                gspuan = gspuan + 3;
                label38.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label23.Text) == (Convert.ToInt32(label22.Text)))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                label37.Text = tspuan.ToString();
                label38.Text = gspuan.ToString();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(label35.Text) > Convert.ToInt32(label36.Text) && Convert.ToInt32(label35.Text) > Convert.ToInt32(label37.Text) && Convert.ToInt32(label35.Text) > Convert.ToInt32(label38.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\bjk.jpg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\bjk1.mp3";
               
                
            }
            if (Convert.ToInt32(label36.Text) > Convert.ToInt32(label35.Text) && Convert.ToInt32(label36.Text) > Convert.ToInt32(label37.Text) && Convert.ToInt32(label36.Text) > Convert.ToInt32(label38.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\fb.jpg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\fb1.mp3";
                
            }
            if(Convert.ToInt32(label37.Text) > Convert.ToInt32(label35.Text) && Convert.ToInt32(label37.Text) > Convert.ToInt32(label36.Text) && Convert.ToInt32(label37.Text) > Convert.ToInt32(label38.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\ts.jpg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\ts1.mp3";
               
            }
            if(Convert.ToInt32(label38.Text) > Convert.ToInt32(label35.Text) && Convert.ToInt32(label38.Text) > Convert.ToInt32(label36.Text) && Convert.ToInt32(label38.Text) > Convert.ToInt32(label37.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\gs.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Eren\\Desktop\\Yeni klasör\\gs1.mp3";
                
            }
        }
    }
}
