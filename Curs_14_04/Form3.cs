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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Complex a = new Complex();
            Complex b = new Complex();
            Complex c = new Complex();
            Complex d = new Complex();
            a.init(2, 6);
            b.init(5, 9);            
            c = a + b;
            d = a / b;
            //listBox1.Items.Add(c.view());
            textBox1.Text = c.view();
            listBox1.Items.Add(d.view());

        }
    }
}
