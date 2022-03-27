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

namespace Matrici_Curs_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"C:\Users\Marius\Documents\.C#\AlgoritmiFundamentali\Matrici(Curs)\TextFile1.txt");
            List<string> data = new List<string>();
            //data.Add(load.ReadLine());
            string buffer;
            while((buffer = load.ReadLine()) != null)
            {
                data.Add(buffer);
            }
            load.Close();

            foreach(string line in data)
            {
                listBox1.Items.Add(line);
            }
            int n = int.Parse(data[0].Split(' ')[0]);
            int m = int.Parse(data[1].Split(' ')[1]);
            int[,] matrix = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                string[] t = data[i + 1].Split(' ');
                for(int j = 0;j < m; j++)
                {
                    matrix[i,j] = int.Parse(t[j]);
                }
            }

            string b;
            for(int i = 0; i < n; i++)
            {
                b = "";
                for(int j = 0; j < m; j++)
                {
                    b += matrix[i, j]+" ";
                }
                listBox2.Items.Add(b);
            }
        }
    }
}
