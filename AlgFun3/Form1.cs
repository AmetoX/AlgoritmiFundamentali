using System.IO;
namespace AlgFun3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextReader note = new StreamReader(@"D:\Coding\Sem 2\AlgoritmiFundamentali\AlgFun3\TextFile1.txt");
        private void button1_Click(object sender, EventArgs e)
        {
            
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