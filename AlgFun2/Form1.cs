namespace AlgFun2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, b, c, d, e_,f,g;
        private void Form1_Load(object sender, EventArgs e)
        {
            int[] v = new int[7];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(10);
            }

            textBox3.Text = "Numerele inainte sa fie sortate";
            a = v[0];
            b = v[1];
            c = v[2];
            d = v[3];
            e_ = v[4];
            f = v[5];
            g = v[6];
            textBox1.Text = a + " " + b + " " + c + " " + d + " " + e_ + " " + f + " " + g;
            
            textBox4.Text = "Numerele dupa sortare";
            Array.Sort(v);
            a = v[0];
            b = v[1];
            c = v[2];
            d = v[3];
            e_ = v[4];
            f = v[5];
            g = v[6];
            textBox2.Text = a + " " + b + " " + c + " " + d + " " + e_ + " " + f + " " + g;

            if ((a == b) && (a == c) && (a == d) && (a == e_) && (a == f) && (a == g))
                textBox5.Text = "7 val id.";
            else
            {
                if (((a == b) && (a == c) && (a == d) && (a == e_) && (a == f)) || ((b == c) && (b == d) && (b == e_) && (b == f) && (b == g)))
                    textBox5.Text = "6 val id.";
                else
                {
                    if (((a == b) && (a == c) && (a == e_)) && (a == f) || ((a == b) && (c == d) && (d == e_) && (e_ == f))) 
                        textBox5.Text = "5 val id. + 2 val id.";
                    else
                    {
                        if (((a == b) && (a == c)) || ((b == c) && (b == d)) || ((c == d) && (c == e_)))
                            textBox5.Text = "3 val id.";
                        else
                        {
                            if (((a == b) && (c == d)) || ((a == b) && (d == e_)) || ((b == c) && (d == e_)))
                                textBox5.Text = "2 val id. + 2 val id.";
                            else
                            {
                                if ((a == b) || (b == c) || (c == d) || (d == e_))
                                    textBox5.Text = "2 val id.";
                                else
                                    textBox5.Text = "nimic";
                            }

                        }
                    }
                }
            }
        }
    }
}