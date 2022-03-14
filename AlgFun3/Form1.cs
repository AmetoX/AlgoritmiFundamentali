namespace AlgFun3
{
    public partial class Form1 : Form
    {
        Random rd = new Random();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //int c = int.Parse(textBox3.Text);
            int a = rd.Next(20);
            int b = rd.Next(20);
            int c = rd.Next(20);

            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Text = c.ToString();


            textBox4.Text = "";

            if (a == b && a == c)
            {
                textBox4.Text = "3 val id";
            }
            else if (a == b || b == c || a == c)
            {
                textBox4.Text = "2 val id";
            }
            else
            {
                if (a > b)
                {
                    int t = a;
                    a = b;
                    b = t;
                }
                if (a > c)
                {
                    int t = a;
                    a = c;
                    c = t;
                }
                if (b > c)
                {
                    int t = c;
                    c = b;
                    b = t;
                }


                if ((b - a == 1) && (c - b == 1))
                {
                    textBox4.Text = "pa";
                }
            }
        }
    }
}