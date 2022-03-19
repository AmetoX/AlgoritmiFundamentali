using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlgFun3_framework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader note = new StreamReader(@"../../TextFile1.txt");

            string t1 = note.ReadLine();
            string t2 = note.ReadLine();

            int[] v;

            int s = 0;
            int n = int.Parse(t1);
            v = new int[n];
            string[] t3 = t2.Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t3[i]);
                s = s + v[i];
            }

            listBox1.Items.Add(t1);
            listBox1.Items.Add(t2);
            listBox1.Items.Add(s.ToString());
        }
    }
}
