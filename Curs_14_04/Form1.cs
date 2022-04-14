using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_14_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Complex summ(Complex a, Complex b)
        {
            Complex t2 = new Complex();
            t2.re = a.re + b.re;
            t2.im = a.im + b.im;
            return t2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Complex a = new Complex();
            a.init(2, 3);
            listBox1.Items.Add(a.view());
            Complex b = new Complex();
            b.init(5, -3);
            listBox1.Items.Add(b.view());
            Complex c = new Complex();
            c.init(2, 7);
            listBox1.Items.Add(c.view());
            Complex d = new Complex();
            d.init(3, 1);
            listBox1.Items.Add(d.view());

            
            Complex t = a.sum(b);
            listBox1.Items.Add(t.view());
            Complex t2 = summ(a, b);
            listBox1.Items.Add(t2.view());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();
        }
    }
}
