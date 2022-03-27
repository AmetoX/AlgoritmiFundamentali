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

namespace SortingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"C:\Users\Marius\Documents\.C#\AlgoritmiFundamentali\SortingApp\TextFile1.txt");
            int n = int.Parse(load.ReadLine());
            int[] v = new int[n];
            for(int i = 0; i < n-5; i++)
            {
                v[i] = int.Parse(load.ReadLine());
                listBox1.Items.Add(v[i]);
                //listBox1.Items.Add(load.ReadLine());
            }
            string buffer = load.ReadLine();
            string[] t = buffer.Split(' '); 
            for(int i = n-5; i < n; i++)
            {
                v[i] = int.Parse(t[i-n+5]);
                listBox1.Items.Add(v[i]);
            }

            string toV = "";
            for (int i = 0; i < n; i++)
            {
                toV += v[i] + " ";

            }
            listBox2.Items.Add(toV);
            toV = "";

            //--Bublle sort--
            bool ok;
            int aux;
            do
            {
                ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }
                }
            } while (!ok);
            //-----

            for(int i = 0; i < n; i++)
            {
                toV += v[i]+" ";
            }
            listBox2.Items.Add(toV);

            //--Selection Sort--

            //-----
        }
    }
}
