using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sa se afle distanta de la E la G (2 puncte de greutate)
namespace Poligon_recurenta_05._05
{
    public partial class Form1 : Form
    {
        Graphics grp;
        Bitmap bmp;
        Point[] P;

        public Form1()
        {
            InitializeComponent();
        }

        public void draw(Point[] P)
        {
            for(int i = 0; i < P.Length-1; i++)
            {
                grp.DrawLine(Pens.Black, P[i].x, P[i].y, P[i + 1].x, P[i + 1].y);
            }
            grp.DrawLine(Pens.Black, P[P.Length - 1].x, P[P.Length - 1].y, P[0].x, P[0].y);
            for(int i = 0; i < P.Length; i++)
            {
                P[i].draw(grp);
            }
        }

        float det(Point a, Point b, Point c)
        {
            float t = a.x * b.y + b.x * c.y + c.x * a.y - c.x * b.y - c.x * a.x - a.y * b.x;
            return t;
        }
        float Arie(Point[] P)
        {
            float a = 0;
            Point O = new Point();
            O.x = 0;
            O.y = 0;
            for(int i = 0; i < P.Length - 1; i++)
            {
                a += det(O, P[i], P[i + 1]);
            }
            a += det(O, P[P.Length - 1], P[0]);
            return a;

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            //cu initializarile astea putem desena

            P = new Point[3];
            for(int i = 0; i < P.Length; i++)
            {
                P[i] = new Point((float)pictureBox1.Width, (float)pictureBox1.Height);
            }
            draw(P);

            pictureBox1.Image = bmp;//refresh
        }



    }
}
