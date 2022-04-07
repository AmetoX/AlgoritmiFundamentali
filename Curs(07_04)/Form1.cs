using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Curs_07_04_
{   
    public partial class Form1 : Form
    {
        Bitmap sursa;
        Bitmap destinatie;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sursa = new Bitmap(Image.FromFile(@"../../Resurse/123.jpg"));
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            pictureBox1.Image = sursa;
        }

        private void btnDirect_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < sursa.Width; i++)
            {
                for(int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);                   
                }
            }
            pictureBox2.Image = destinatie;
        }

        private void greyScale_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    int t = (r + g + b) / 3;
                    Td = Color.FromArgb(t);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }

        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    int t = (r + g + b) / 3;
                    if (t < 128)
                    {
                        Td = Color.FromArgb(0,0,0);
                    }
                    else
                    {
                        Td = Color.FromArgb(255,255,255);
                    }                    
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }

        private void filterPhotoshop_Click(object sender, EventArgs e)
        {
            int K = 50;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = (Ts.R+K)%256;
                    int g = (Ts.G+K)% 256;
                    int b = (Ts.B+K) % 256;
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }

        public int min(int a,int b)
        {
            if (a > b)
                return b;
            else
                return a; //a<b:a?b         
        }
        public int max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        private void filtru2_Click(object sender, EventArgs e)
        {
            int K = 20;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = min(Ts.R + K, 255);
                    int g = min(Ts.G + K, 255);
                    int b = min(Ts.B + K, 255);
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }

        private void filitru2max_Click(object sender, EventArgs e)
        {
            int K = 20;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = max((Ts.R - K), 0);
                    int g = max((Ts.G - K), 0);
                    int b = max((Ts.B - K), 0);
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
            int K = 20;
            int t;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    t = (r + g + b);
                    if (t < 128)
                    {
                        r = max((Ts.R - K), 0);
                        g = max((Ts.G - K), 0);
                        b = max((Ts.B - K), 0);
                    }
                    else
                    {
                        r = min(Ts.R + K, 255);
                        g = min(Ts.G + K, 255);
                        b = min(Ts.B + K, 255);
                    }
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }

    }
}
