namespace Stack_Queue_19_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue A = new Queue();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.Pop();
            A.view();
            Console.WriteLine();
            Stack B = new Stack();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.Pop();
            B.view();
            Console.ReadKey();*/
            /*Stack B = new Stack();
            string S = "2 1 + 3 * 7 1 * - 5 10 - 2 * +";
            string[] d = S.Split(' ');
            int t;
            for (int i = 0; i < d.Length; i++)
            {
                if ((d[i])[0] >= '0' && (d[i])[0] <= '9')
                {
                    t = int.Parse(d[i]);
                    *//*Console.Write(t + " ");*//*
                    B.Push(t);
                }
                else
                {
                    int t1 = B.Pop();
                    int t2 = B.Pop();
                    switch ((d[i])[0])
                    {
                        case '+': B.Push(t2 + t1);
                            break;
                        case '-':
                            B.Push(t2 - t1);
                            break;
                        case '*':
                            B.Push(t2 * t1);
                            break;
                        case '/':
                            B.Push(t2 / t1);
                            break;
                    }
                }
                
            }
            B.view();
            Console.ReadKey();*/
            Queue A1 = new Queue();
            A1.Push(new triData(1, 2, 3));
            A1.Push(new triData(4, 5, 6));
            A1.Push(new triData(5, 5, 5));
            A1.view();
            Console.ReadKey();
        }
    }
}